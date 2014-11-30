using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TTGen
{
    class Token
    {
        public enum TokenCategory
        {
            Undefined,
            Bool,
            Op,
            LeftParen,
            RightParen
        };

        // higher precendence gets executed first
        public int Precedence { get; private set; }
        public TokenCategory Category { get; private set; }
        public char Symbol { get; private set; } // default value is 0
        // if it not left associative, it is right.
        public bool IsLeftAssoc { get; private set; }
        public bool BoolVal { get; set; }
        public bool isVariable { get; private set; }
        public int ArgCount { get; private set; }

        public Token(char symbol, 
            TokenCategory cat = TokenCategory.Undefined, 
            int precedence = -1,
            int argCount = 0,
            bool isLeftAssoc = true)
        {
            if (cat == TokenCategory.Bool) isVariable = true;
            this.Category = cat;
            this.Symbol = symbol;
            this.Precedence = precedence;
            this.IsLeftAssoc = isLeftAssoc;
            this.ArgCount = argCount;
        }

        // constructor for values
        public Token(char symbol, bool boolVal)
        {
            this.Category = TokenCategory.Bool;
            this.BoolVal = boolVal;
            this.Symbol = symbol;
        }

        public override string ToString()
        {
            return String.Format("Category: {0}\nValue: {1}\nPrecedence: {2}\nAssociativity: {3}\n",
                Category.ToString(),
                Symbol == 0 ? BoolVal.ToString() : Symbol.ToString(),
                Precedence,
                IsLeftAssoc ? "left" : "right");
        }

        public static List<Token> Tokenize(string input)
        {
            List<Token> result = new List<Token>();
            input = Regex.Replace(input, @"\s+", "");
            foreach (char c in input) {
                if (Char.IsLetter(c)) {
                    // assume all variables are uppercase
                    result.Add(new Token(Char.ToUpper(c), TokenCategory.Bool));
                    continue;
                }
                switch (c) {
                    case '0':
                        result.Add(new Token(c, false));
                        break;
                    case '1':
                        result.Add(new Token(c, true));
                        break;
                    case '(':
                        result.Add(new Token(c, TokenCategory.LeftParen));
                        break;
                    case ')':
                        result.Add(new Token(c, TokenCategory.RightParen));
                        break;
                    case '+':
                        result.Add(new Token(c, TokenCategory.Op, 2, 2));
                        break;
                    case '^':
                        result.Add(new Token(c, TokenCategory.Op, 3, 2));
                        break;
                    case '*':
                        result.Add(new Token(c, TokenCategory.Op, 4, 2));
                        break;
                    case '\'':
                        result.Add(new Token(c, TokenCategory.Op, 5, 1, false));
                        break;
                    default:
                        throw new Exception("Unable to tokenize. Make sure all characters are valid.");
                }
            }
            return result;
        }
    }
}
