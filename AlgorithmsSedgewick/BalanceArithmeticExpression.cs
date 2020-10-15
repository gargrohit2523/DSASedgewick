using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSedgewick
{
    public static class BalanceArithmeticExpression
    {
        public static string BalanceForLeftParenthesis(string input)
        {
            Stack<char> operatorStack = new Stack<char>();
            Stack<string> expressionStack = new Stack<string>();


            foreach (var c in input)
            {
                if (char.IsWhiteSpace(c))
                    continue;

                if (isOperator(c))
                {
                    operatorStack.Push(c);
                }
                else if(c == '}' || c == ']' || c == ')')
                {
                    if (operatorStack.Count == 0)
                        break;

                    var topOperator = operatorStack.Pop();

                    if (expressionStack.Count == 0)
                        break;

                    var secondOperand = expressionStack.Pop();
                    var firstOperand = expressionStack.Pop();

                    var evaluatedExpression = (getMatchingParenthesis(c) + firstOperand + topOperator + secondOperand + c).ToString();
                    expressionStack.Push(evaluatedExpression);
                }
                else
                {
                    expressionStack.Push(c.ToString());
                }
            }

            operatorStack = null;
            expressionStack = null;

            return expressionStack.Pop();
        }

        private static bool isOperator(char c)
        {
            return c == '+' || c == '-' || c == '/' || c == '*';
        }

        private static char getMatchingParenthesis(char rightParenthesis)
        {
            char leftParenthesis;

            if (rightParenthesis == '}')
                leftParenthesis = '{';
            else if (rightParenthesis == ']')
                leftParenthesis = '[';
            else if (rightParenthesis == ')')
                leftParenthesis = '(';
            else
                return 'e';

            return leftParenthesis;
        }
    }
}
