using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD
{
    internal class RPN
    {
        List<string> rtokens = new List<string>();
        List<string> tokens = new List<string>();
        Dictionary<string, (uint, Func<double, double, double>)> operators = new Dictionary<string, (uint, Func<double, double, double>)> {
            { "+", (1u,(l,r) => l+r) },
            { "-", (1u,(l,r) => l-r) },
            { "*", (2u,(l,r) => l*r) },
            { "/", (2u,(l,r) => l/r) },
            { "^", (3u,(l,r) => Math.Pow(l,r)) }
        };
        char[] separators = new char[] { '+', '-', '*', '\\','^', '(', ')' };
        public RPN(string inp)
        {
            while (inp.Length > 0)
            {
                string curr = inp.Substring(0, 1);
                inp = inp.Substring(1);
                if (IsBracket(curr))
                {
                    tokens.Append(curr);
                } else if (IsOperator(curr))
                {
                    if (IsOperator(tokens.Last()))
                    {
                        throw new Exception();
                    }
                    else if (tokens.Last() == "(")
                    {

                        // watch for number
                        tokens.Append(GetNumber(ref inp, curr));
                    }
                    else
                    {
                        tokens.Append(curr);
                    }
                }
                else
                {
                    //watch for number
                    tokens.Append(GetNumber(ref inp, curr));
                }
            }


            // form postfix notation
            Stack<string> stack = new Stack<string>(tokens.Size);
            List<string> list = tokens;
            while (!list.IsEmpty)
            {
                string curr = list.First();
                list.RemoveFront();
                if (IsNumber(curr))
                {
                    rtokens.Append(curr);
                }
                else if (curr == "(")
                {
                    stack.Push(curr);
                } else if (curr == ")")
                {
                    while (stack.Peek() != "(")
                    {
                        rtokens.Append(stack.Pop());
                    }
                    if (stack.IsEmpty)
                        throw new Exception();
                    stack.Pop();
                }
                else if (IsOperator(curr))
                {
                    while (true)
                    {
                        if (stack.IsEmpty)
                            break;
                        if (stack.Peek() == "(")
                            break;
                        if (!operators.ContainsKey(stack.Peek()))
                            throw new Exception();
                        if (operators[stack.Peek()].Item1 >= operators[curr].Item1)
                        {
                            rtokens.Append(stack.Pop());
                        }
                        else
                        {
                            break;
                        }
                    }
                    stack.Push(curr);
                }
            }
            while (!stack.IsEmpty)
            {
                if (!IsOperator(stack.Peek()))
                    throw new Exception();
                rtokens.Append(stack.Pop());
            }
        }

        public double Result
        {
            get {
                Stack<double> stack = new Stack<double>(rtokens.Size);
                List<string> list = rtokens;

                while (!list.IsEmpty)
                {
                    string curr = list.First();
                    list.RemoveFront();
                    if (IsOperator(curr))
                    {
                        double second = stack.Pop();
                        double first = stack.Pop();
                        stack.Push(operators[curr].Item2.Invoke(first,second));
                    }
                    else
                    {
                        stack.Push(Convert.ToDouble(curr));
                    }
                }
                return stack.Peek();
            }
        } 
        public string InfixNotation { 
            get
            {
                string res = "";
                for(uint i = 0; i < tokens.Size; i++)
                {
                    res += tokens.At(i);
                }
                return res;
            } 
        }
        public string PostfixNotation
        {
            get
            {
                string res = "";
                for(uint i = 0; i < rtokens.Size; i++)
                {
                    res += rtokens.At(i) + ((i == rtokens.Size - 1) ? ("") : (" "));
                }
                return res;
            }
        }
        private string GetNumber(ref string inp, string curr)
        {
            int idx = inp.IndexOfAny(separators);
            if (idx == -1)
                idx = inp.Length;
            string res = "";
            if (idx == inp.Length)
            {
                res = curr + inp;
                inp = "";
            }
            else
            {
                res = curr + inp.Substring(0, idx);
                inp = inp.Substring(idx);
            }

            if (!IsNumber(res))
                throw new Exception();
            return res;
        }
        private bool IsNumber(string val)
        {
            try
            {
                Convert.ToDouble(val);
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        private bool IsBracket(string val)
        {
            return val == "(" || val == ")";
        }
        private bool IsOperator(string val)
        {
            return operators.ContainsKey(val);
        }
    }
}
