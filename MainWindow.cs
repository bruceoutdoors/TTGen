using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTGen
{
    public partial class MainWindow : Form
    {
        private BoolExpr expression1;
        private BoolExpr expression2;
        private bool error1 = false;
        private bool error2 = false;
        private bool errors = false;

        public MainWindow()
        {
            InitializeComponent();
            ErrorMsgLbl.Text = "";
            EqualityLbl.Text = "";
        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void Input2_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void checkInputs()
        {
            if (Input1.Text != "") {
                try {
                    expression1 = new BoolExpr(Input1.Text);
                    expression1.Solve();
                    error1 = false;
                    Input2.Enabled = true;
                } catch (Exception ex) {
                    ErrorMsgLbl.Text = "Error in #1: " + ex.Message;
                    error1 = true;
                    Input2.Enabled = false;
                }
            } else {
                error1 = false;
                Input2.Enabled = false;
            }

            if (Input2.Enabled && Input2.Text != "") {
                try {
                    expression2 = new BoolExpr(Input2.Text);
                    expression2.Solve();
                    error2 = false;
                } catch (Exception ex) {
                    ErrorMsgLbl.Text = "Error in #2: " + ex.Message;
                    error2 = true;
                }
            } else {
                error2 = false;
            }

            errors = (error1 || error2) ? true : false;
            if (!errors) ErrorMsgLbl.Text = "";
        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            if (!validateInputs()) return;

            // clear the previous table:
            TruthTableView.Columns.Clear();
            TruthTableView.Items.Clear();

            List<char> boolVars;

            if (isInput2Enabled()) {
                // combine both variables from 2 equations:
                boolVars = 
                    expression1.GetBoolVars()
                    .Concat(expression2.GetBoolVars())
                    .Distinct().ToList();
            } else {
                boolVars = expression1.GetBoolVars();
            }

            bool[,] inputTable = GenInputTable(boolVars.Count);

            foreach (char c in boolVars) {
                TruthTableView.Columns.Add(c.ToString());
            }

            // solve:
            bool[] answer1 = new bool[inputTable.GetLength(0)];
            bool[] answer2 = new bool[inputTable.GetLength(0)]; ;
            for (int i = 0; i < inputTable.GetLength(0); i++) {
                for (int j = 0; j < inputTable.GetLength(1); j++) {
                    expression1.SetValue(boolVars[j], inputTable[i, j]);
                    if (isInput2Enabled()) expression2.SetValue(boolVars[j], inputTable[i, j]);
                }
                answer1[i] = expression1.Solve();
                if (isInput2Enabled()) answer2[i] = expression2.Solve();
            }

            bool equal = false;
            if (isInput2Enabled()) equal = answer1.SequenceEqual(answer2);

            TruthTableView.Columns.Add("#1");
            if (isInput2Enabled() && !equal) TruthTableView.Columns.Add("#2");
            for (int i = 0; i < inputTable.GetLength(0); i++) {
                ListViewItem L = TruthTableView.Items.Add(getBoolStr(inputTable[i, 0]));
                for (int j = 1; j < inputTable.GetLength(1); j++) {
                    L.SubItems.Add(getBoolStr(inputTable[i, j]));
                }
                L.SubItems.Add(getBoolStr(answer1[i]));
                if (isInput2Enabled() && !equal) L.SubItems.Add(getBoolStr(answer2[i])); ;
            }

            if (isInput2Enabled()) {
                if (equal) {
                    EqualityLbl.Text = "#1 and #2 are equivalent";
                    EqualityLbl.ForeColor = Color.Green;
                } else {
                    EqualityLbl.Text = "#1 and #2 are NOT equivalent";
                    EqualityLbl.ForeColor = Color.Crimson;
                }
            } else {
                EqualityLbl.Text = "";
            }
        }

        private string getBoolStr(bool b)
        {
            return b ? "1" : "0";
        }

        private bool isInput2Enabled()
        {
            return Input2.Enabled && Input2.Text != "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog box = new AboutDialog();
            box.ShowDialog();
        }

        private bool validateInputs()
        {
            if (Input1.Text == "") {
                MessageBox.Show("I can't generate a truth table without any input.");
                return false;
            }

            if (errors) {
                MessageBox.Show("Please make sure there are no errors with your input before generate the truth table.");
                return false;
            }

            return true;
        }

        private bool[,] GenInputTable(int col)
        {
            bool[,] table;
            int row = (int)Math.Pow(2, col);

            table = new bool[row, col];

            int divider = row;

            // iterate by column
            for (int c = 0; c < col; c++) {
                divider /= 2;
                bool cell = false;
                // iterate every row by this column's index:
                for (int r = 0; r < row; r++) {
                    table[r, c] = cell;
                    if ((divider == 1) || ((r + 1) % divider == 0)) {
                        cell = !cell;
                    }
                }
            }

            return table;
        }

        private void howArToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text =
                "+ => OR gate\n" +
                "* => AND gate\n" +
                "^ => XOR gate\n" +
                "' => NOT gate\n\n" +
                "All letters are converted to upper case and\n" +
                "interpreted as variables. All other inputs\n" +
                "are invalid.\n\n" +
                "Example: A(B^C')'+D\n\n" +
                "#2 input allows you to compare 2 expressions.";
            MessageBox.Show(text);
        }
    }
}
