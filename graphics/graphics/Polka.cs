using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics
{
    public class Polka
    {

        public string x = "-97,3";
        const double PI = Math.PI;
        public bool isAsymptote = false;
        public string Calculate(string input)
        {
            isAsymptote = false;
            //crutch :D
            if (x[0]=='-')
            {
                x = x.Remove(0, 1);
                x = "(0-" + x+")";
                
            }
            if (input[0] == '-')
            {
                input = input.Remove(0, 1);
                input = "0-" + input;


            }
            while (input.IndexOf("x") != -1)
            {
                int ind = input.IndexOf("x");
                input = input.Remove(ind, 1);
                input = input.Insert(ind, x);
            }
            while (input.IndexOf(".") != -1)
            {
                int ind = input.IndexOf(".");
                input = input.Remove(ind, 1);
                input = input.Insert(ind, ",");
            }
            string deb = RemoveMathFunc(input);

            string output = GetExpression(deb);
          //  if (output[output.Length - 1] == ' ')
        //        output = output.Remove(output.Length - 1, 1);
            double result = Counting(output); 
            string ret = result.ToString();
            if(ret.Length>6)
            {
                ret = ret.Substring(0, 6);
            }
            return ret; 
        }
        private string GetExpression(string input)
        {
            string output = ""; 
            Stack<char> operStack = new Stack<char>(); 

            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i]==' ')
                    continue; 
                
                if (Char.IsDigit(input[i]))
                {
                    
                    while (!(input[i]==' ') && !IsOperator(input[i]))
                    {
                        output += input[i]; 
                        i++; 

                        if (i == input.Length) break; 
                    }

                    output += " ";
                    i--; 
                }
                if(input[i]=='x')
                  output += 'x';
                
                
                if (IsOperator(input[i])) 
                {
                    if (input[i] == '(') 
                        operStack.Push(input[i]); 
                    else if (input[i] == ')') 
                    {
                       
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else 
                    {
                        if (operStack.Count > 0) 
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek())) 
                                output += operStack.Pop().ToString() + " ";

                        operStack.Push(char.Parse(input[i].ToString())); 

                    }
                }
            }
            
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output; 
        }
        //private string CheckExpression(string input)
        //{
        //    //string GetArgument(string input)
        //    while (input.IndexOf("sin") != -1)
        //    {
        //        int ind = input.IndexOf("sin")+4;
        //        int count = 1,eind=ind;
        //        while(count!=0)
        //        {
        //            if (input[eind] == ')')
        //                count--;
        //            if (input[eind] == '(')
        //                count++;
        //            eind++;
        //        }
        //        eind = eind - ind - 1;
        //        string arg = sin(input.Substring(ind,eind));
        //        input = input.Remove(ind - 4, eind + 5);
        //        input = input.Insert(ind - 4, arg);
        //    }
            
        //    while(input.IndexOf("cos") != -1)
        //    {
        //        int ind = input.IndexOf("cos")+4;
        //        int count = 1, eind = ind;
        //        while (count != 0)
        //        {
        //            if (input[eind] == ')')
        //                count--;
        //            if (input[eind] == '(')
        //                count++;
        //            eind++;
        //        }
        //        eind = eind - ind - 1;
        //        string arg = cos(input.Substring(ind, eind));
        //        input = input.Remove(ind - 4, eind + 5);
        //        input = input.Insert(ind - 4, arg);
        //    }
        //    // ln     
        //    //while (input.IndexOf("ln") != -1)
        //    //{
        //    //    int ind = input.IndexOf("ln") + 3;
        //    //    int count = 1, eind = ind;
        //    //    while (count != 0)
        //    //    {
        //    //        if (input[eind] == ')')
        //    //            count--;
        //    //        if (input[eind] == '(')
        //    //            count++;
        //    //        eind++;
        //    //    }
        //    //    eind = eind - ind - 1;
        //    //    string arg = ln(input.Substring(ind, eind));
        //    //    input = input.Remove(ind - 3, eind + 5);
        //    //    input = input.Insert(ind - 3, arg);
        //    //}
        //    return input;
        //}
        private int GetInd(string input, int ind)
        {
            int count = 1, eind = ind;
            while (count != 0)
            {
                if (input[eind] == ')')
                    count--;
                if (input[eind] == '(')
                    count++;
                eind++;
            }
            eind = eind - ind - 1;
            return eind;
        }
        private string RemoveCurr(string input, string nameFunc, int num)
        {
            int ind = input.IndexOf(nameFunc) + nameFunc.Length + 1;
            int eind = GetInd(input, ind);
            string arg = input.Substring(ind, eind);
            arg = RemoveMathFunc(arg);
            double res = Counting(GetExpression(arg));
            switch (num)
            {
                case 1: res = Math.Sin(res); break;
                case 2: res = Math.Cos(res); break;
                case 3:
                    double l = 0.01;
                    if (res <= PI/2 + l && res >= PI/2 - l)
                            isAsymptote = true;

                    if (res <= (-PI/2) + l && res >= (-PI/2) - l)
                        isAsymptote = true;
                    res = Math.Tan(res);
                    break;
                case 4:
                    if(res<=0)
                    {
                        isAsymptote = true;
                        return "0";
                    }
                    res = Math.Log(res); break;
                case 5:
                    if(res<0)
                    {
                        isAsymptote = true;
                        return "0";
                    }
                    res = Math.Sqrt(res);
                    break;


            }
            string ar = res.ToString();
            if (ar[0] == '-')
            {
                ar = ar.Remove(0, 1);
                ar = "(0-" + ar + ")";

            }
            input = input.Remove(ind - nameFunc.Length - 1, eind + nameFunc.Length+2);
            input = input.Insert(ind - nameFunc.Length - 1, ar);
            return input;
        }
        private string RemoveMathFunc(string input)
        {
            while(input.IndexOf("sin") != -1)
            {
                //int ind = input.IndexOf("sin") + 4;
                //int eind = GetInd(input, ind);
                //string arg =  input.Substring(ind, eind);
                //arg = RemoveMathFunc(arg);
                //double res = Counting(GetExpression(arg));
                //res = Math.Sin(res);
                //string ar = res.ToString();
                //if (ar[0] == '-')
                //{
                //    ar = ar.Remove(0, 1);
                //    ar = "(0-" + ar + ")";

                //}
                //input = input.Remove(ind - 4, eind + 5);
                //input = input.Insert(ind - 4, ar);
                input = RemoveCurr(input, "sin", 1);
            }
            while (input.IndexOf("cos") != -1)
            {
                input = RemoveCurr(input, "cos", 2);
            }
            while (input.IndexOf("tg") != -1)
            {
                input = RemoveCurr(input, "tg", 3);
            }
            while (input.IndexOf("ln") != -1)
            {
                input = RemoveCurr(input, "ln", 4);

            }
            while (input.IndexOf("sqrt") != -1)
            {
                input = RemoveCurr(input, "sqrt", 5);
            }

            return input;
        }
        private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }
        private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }
        private double Counting(string input)
        {
            double result = 0; 
            Stack<double> temp = new Stack<double>(); 
            //Stack<double> debug = new Stack<double>();
            for (int i = 0; i < input.Length; i++) 
            {
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!(input[i]==' ') && !IsOperator(input[i])) 
                    {
                        a += input[i]; 
                        i++;
                        if (i == input.Length) break;
                    }
                    if(a.Length>16)
                    {
                        a = a.Substring(0, 16);
                    }
                    if(a.IndexOf("E") != -1)
                      a = a.Remove(a.IndexOf("E"));
                    
                    temp.Push(double.Parse(a)); 
                    i--;
                }
                else if (IsOperator(input[i])) 
                {
                    double a = temp.Pop();
                    double b = temp.Pop();
                    //debug.Pop();
                    //debug.Pop();
                    switch (input[i]) 
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/':
                            double l = 0.00001;
                            if (a<=0+l && a>=0-l)
                            {
                                isAsymptote = true;
                                return 0;
                            }
                            result = b / a;
                            break;
                        case '^':

                            result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString());
                            break;
                    }
                    temp.Push(result); 
                }
            }
            return temp.Peek(); 
        }
        static long Factorial(long x)
        {
            return (x == 0) ? 1 : x * Factorial(x - 1);
        }
        //Teylor.
        // tg,ctg,log... in develop
        //string cos(string input)
        //{
            
        //    string output = "(1";
        //    string z = "(" + input + ")";
        //    for (int i = 1; i < 9; i++)
        //    {
        //        if (i % 2 != 0)
        //            output += "-";
        //        else
        //            output += "+";
        //        output += "(";
        //        output += "(";
        //        output += z;
        //        output += "^";
        //        output += (2 * i).ToString();
        //        output += ")";
        //        output += "/";
        //        output += "(";
        //        output += Factorial(i * 2).ToString();
        //        output += ")";
        //        output += ")";
        //    }
        //    output += ")";
        //    return output;
        //}
        //string sin(string input)
        //{
        //    string output = "(";
        //    string z = "(" + input + ")";
        //    output += input;
        //    for (int i = 1; i < 9; i++)
        //    {
        //        if (i % 2 != 0)
        //            output += "-";
        //        else
        //            output += "+";
        //        output += "(";
        //        output += "(";
        //        output += z;
        //        output += "^";
        //        output += (2 * i + 1).ToString();
        //        output += ")";
        //        output += "/";
        //        output += "(";
        //        output += Factorial(i * 2 + 1).ToString();
        //        output += ")";
        //        output += ")";
        //    }
        //    output += ")";
        //    return output;
        //}
    }


  


}
