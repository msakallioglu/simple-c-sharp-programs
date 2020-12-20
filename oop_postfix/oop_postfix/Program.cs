using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_postfix
{
    class Stack
    {
        string[] stck;
        int tos;

        public Stack(int size)
        {
            stck = new string[size];
            tos = 0;
        }

        public void Push(string i)
        {
            if (tos == stck.Length)
            {
                Console.WriteLine("Stack Full.");
                return;
            }
            stck[tos] = i;
            tos++;
        }

        public string Pop()
        {
            if (tos == 0)
            {
                Console.WriteLine("Stack is empty.");
                return "";
            }
            tos--;
            return stck[tos];
        }
        public bool dolumu()
        {
            return tos == stck.Length;
        }
        public bool bosmu()
        {
            return tos == 0;
        }

        public int Kapasite()
        {
            return stck.Length;
        }

        public int sayac()
        {
            return tos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arithmetic expressions in postfix format: ");
            string sayilar = Console.ReadLine();
            string[] dizi = sayilar.Split(' ');
            Stack stk = new Stack(dizi.Length);


            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == "+")
                {
                    string songiren = stk.Pop();

                    if (stk.sayac() < 1)
                    {
                        Console.WriteLine("Stack is empty");
                        Console.ReadKey();
                        return;
                    }

                    string ilkgiren = stk.Pop();

                    Double num1 = Convert.ToDouble(songiren);
                    Double num2 = Convert.ToDouble(ilkgiren);
                    Double s = 0;

                    s = (num2) + (num1);

                    stk.Push(s.ToString());
                }
                else if (dizi[i] == "-")
                {
                    string songiren = stk.Pop();

                    if (stk.sayac() < 1)
                    {
                        Console.WriteLine("Stack is empty");
                        Console.ReadKey();
                        return;
                    }

                    string ilkgiren = stk.Pop();

                    Double num1 = Convert.ToDouble(songiren);
                    Double num2 = Convert.ToDouble(ilkgiren);
                    Double s = 0;

                    s = (num2) - (num1);
                    stk.Push(s.ToString());
                }
                else if (dizi[i] == "*")
                {
                    string songiren = stk.Pop();

                    if (stk.sayac() < 1)
                    {
                        Console.WriteLine("Stack is empty");
                        Console.ReadKey();
                        return;
                    }

                    string ilkgiren = stk.Pop();

                    Double num1 = Convert.ToDouble(songiren);
                    Double num2 = Convert.ToDouble(ilkgiren);
                    Double s = 0;

                    s = (num2) * (num1);

                    stk.Push(s.ToString());
                }
                else if (dizi[i] == "/")
                {
                    string songiren = stk.Pop();

                    if (stk.sayac() < 1)
                    {
                        Console.WriteLine("Stack is empty");
                        Console.ReadKey();
                        return;
                    }

                    string ilkgiren = stk.Pop();

                    Double num1 = Convert.ToDouble(songiren);
                    Double num2 = Convert.ToDouble(ilkgiren);
                    Double s = 0;

                    s = (num2) / (num1);
                    stk.Push(s.ToString());
                }
                else
                {
                    stk.Push(dizi[i].ToString());
                }

            }

            if (stk.sayac() > 1)
            {
                Console.WriteLine("Stack full. Wrong");
                Console.ReadKey();
                return;
            }

            while (!stk.bosmu())
            {
                Console.WriteLine(stk.Pop());
            }
            Console.ReadKey();
        }
    }
}
