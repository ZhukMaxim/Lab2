using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string letters = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int symbolCount = 4;
            int lenletters = letters.Length;
            bool ver = false;
            int index = 0;
            string found = "";
            Console.WriteLine("Input pass");
            string password = Console.ReadLine();
            if (password.Length > symbolCount)
            {
                Console.WriteLine("Password invalid");
            }
            else
            {
                for (int i = 0; i < lenletters; i++)
                {
                    Console.WriteLine(letters[i].ToString());
                    if (letters[i].ToString() == password)
                    {
                        found += letters[i].ToString();
                        goto lable;
                    }
                    for (int j = 0; j < lenletters; j++)
                    {
                        Console.WriteLine(letters[i].ToString() + letters[j].ToString());
                        if ((letters[i].ToString() + letters[j].ToString()) == password)
                        {
                            found += letters[i].ToString() + letters[j].ToString();
                            goto lable;
                        }
                        for (int k = 0; k < lenletters; k++)
                        {
                            Console.WriteLine(letters[i].ToString() + letters[j].ToString() + letters[k].ToString());
                            if ((letters[i].ToString() + letters[j].ToString() + letters[k].ToString()) == password)
                            {
                                found += letters[i].ToString() + letters[j].ToString() + letters[k].ToString();
                                goto lable;
                            }
                            for (int l = 1; l < lenletters; l++)
                            {
                                Console.WriteLine(letters[i].ToString() + letters[j].ToString() + letters[k].ToString() + letters[l].ToString());
                                if ((letters[i].ToString() + letters[j].ToString() + letters[k].ToString() + letters[l].ToString()) == password)
                                {
                                    found += letters[i].ToString() + letters[j].ToString() + letters[k].ToString() + letters[l].ToString();
                                    goto lable;
                                }
                            }
                        }
                    }
                }

            }
        lable: Console.WriteLine("Password found: {0}", found);
            Console.ReadLine();
        }
    }
}
