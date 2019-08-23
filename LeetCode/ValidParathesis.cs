using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidParathesis
    {
        public bool IsValid(string s)
        {
            Stack<char> Openparanthesis = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                try
                {
                    if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                    {
                        Openparanthesis.Push(s[i]);
                    }
                    else if (s[i] == '}' && Openparanthesis.Peek() == '{')
                    {
                        Openparanthesis.Pop();
                    }
                    else if (s[i] == ']' && Openparanthesis.Peek() == '[')
                    {
                        Openparanthesis.Pop();
                    }
                    else if (s[i] == ')' && Openparanthesis.Peek() == '(')
                    {
                        Openparanthesis.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }
            return Openparanthesis.Count== 0;
        }
    }
}
