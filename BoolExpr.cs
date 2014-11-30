using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTGen
{
    class BoolExpr
    {
        private List<Token> Expression;
        private const string mismatchParenErrorMsg =
            "Error! Mismatched parenthesis in your expression!";

        public BoolExpr(string input)
        {
            Expression = Token.Tokenize(input);
            InsertANDs();

            // convert to Reverse Polish Notation
            Expression = ShuntingYard(Expression);
        }

        public bool Solve()
        {
            Stack<bool> stack = new Stack<bool>();

            foreach (Token t in Expression) {
                if (t.Category == Token.TokenCategory.Bool) {
                    stack.Push(t.BoolVal);
                } else if (t.Category == Token.TokenCategory.Op) {
                    if (t.ArgCount > stack.Count) {
                        throw new Exception("The user has not input sufficient values in the expression!");
                    }

                    // evaluate the operator:
                    switch (t.Symbol) {
                        case '+':
                            stack.Push(stack.Pop() | stack.Pop());
                            break;
                        case '^':
                            stack.Push(stack.Pop() ^ stack.Pop());
                            break;
                        case '*':
                            stack.Push(stack.Pop() & stack.Pop());
                            break;
                        case '\'':
                            stack.Push(!stack.Pop());
                            break;
                        default:
                            throw new Exception("Error: Invalid operation!!");
                    }
                }
            }

            if (stack.Count > 1) throw new Exception("Error: The user input has too many values.");

            return stack.Pop();
        }

        // converts the token list to Reverse Polish Notation (RPN)
        // using the Dijkstra's Shunting Yard algorithm
        private List<Token> ShuntingYard(List<Token> list)
        {
            List<Token> outputQueue = new List<Token>();
            Stack<Token> operatorStack = new Stack<Token>();

            foreach (Token t in list) {
                if (t.Category == Token.TokenCategory.Bool) {
                    outputQueue.Add(t);
                } else if (t.Category == Token.TokenCategory.Op) {
                    while ((operatorStack.Count > 0) &&
                        (operatorStack.Peek().Category == Token.TokenCategory.Op) &&
                        (
                        (t.IsLeftAssoc && t.Precedence <= operatorStack.Peek().Precedence) ||
                        (!t.IsLeftAssoc && t.Precedence < operatorStack.Peek().Precedence)
                        )) {
                        outputQueue.Add(operatorStack.Pop());
                    }
                    operatorStack.Push(t);
                } else if (t.Category == Token.TokenCategory.LeftParen) {
                    operatorStack.Push(t);
                } else if (t.Category == Token.TokenCategory.RightParen) {
                    try {
                        while (operatorStack.Peek().Category != Token.TokenCategory.LeftParen) {
                            outputQueue.Add(operatorStack.Pop());
                        }
                        // pop left parenthesis from the stack
                        operatorStack.Pop();
                    } catch (InvalidOperationException) {
                        throw new Exception(mismatchParenErrorMsg);
                    }
                }
            }

            // pop remaining operators in the stack to the output queue:
            while (operatorStack.Count > 0) {
                // If the operator token on the top of the stack is a parenthesis
                if (operatorStack.Peek().Category == Token.TokenCategory.LeftParen ||
                    operatorStack.Peek().Category == Token.TokenCategory.RightParen) {
                    throw new Exception(mismatchParenErrorMsg);
                }
                outputQueue.Add(operatorStack.Pop());
            }

            return outputQueue;
        }

        private void InsertANDs()
        {
            // compare 2 tokens at a time:
            int a = 0; int b = 1;
            while (b < Expression.Count) {
                // iterates through every possible location 
                // where * should be inserted
                if ((Expression[a].Category == Token.TokenCategory.Bool &&
                     Expression[b].Category == Token.TokenCategory.LeftParen)
                     ||
                    (Expression[a].Category == Token.TokenCategory.Bool &&
                     Expression[b].Category == Token.TokenCategory.Bool)
                     ||
                    (Expression[a].Category == Token.TokenCategory.RightParen &&
                     Expression[b].Category == Token.TokenCategory.LeftParen)
                     ||
                    (Expression[a].Category == Token.TokenCategory.RightParen &&
                     Expression[b].Category == Token.TokenCategory.Bool)
                     || // conditions involving NOT (')
                    (Expression[a].Symbol == '\'' &&
                     Expression[b].Category == Token.TokenCategory.Bool)
                     ||
                    (Expression[a].Symbol == '\'' &&
                     Expression[b].Category == Token.TokenCategory.LeftParen)
                    ) {
                    Expression.Insert(b, new Token('*', Token.TokenCategory.Op, 4));
                    a++; b++;
                }
                a++; b++;
            }
        }

        public List<char> GetBoolVars()
        {
            List<char> boolVars = new List<char>();
            foreach (var t in Expression) {
                if (t.Category == Token.TokenCategory.Bool && t.isVariable) {
                    boolVars.Add(t.Symbol);
                }
            }
            boolVars = boolVars.Distinct().ToList();
            boolVars.Sort();

            return boolVars;
        }

        // set variable value, returns true if successfully changed
        public bool SetValue(char c, bool val)
        {
            bool success = false;
            char ch = Char.ToUpper(c);
            foreach (var t in Expression) {
                if (t.Symbol == ch) {
                    t.BoolVal = val;
                    success = true;
                }
            }

            return success;
        }
    }
}
