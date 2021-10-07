using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace programmering2_övning
{
    class Program
    {
        //Alla möjliga integers fungerar (iallafall de jag testat),
        //testa gärna att få programmet att inte fungera så kan jag försöka fixa det.
        static void Main(string[] args)
        {

            int[] nums = { -2, 1, -3, 5, -1, 2, 1, -5, 4 };
            //int[] nums = { 1,;

            List<int> numlist = nums.ToList();
            List<int> delarray = new();
            List<int> templist = new();

            int listlängd = numlist.Count;
            int svar = -100000;
            int maxtal;


            for (int i = 0; i < numlist.Count; i++)
            {

                numlist.RemoveRange(0, i);
                listlängd -= i;

                for (int j = 0; j < listlängd; j++)
                {
                    maxtal = 0;

                    foreach (int item in numlist)
                    {
                        maxtal += item;
                        templist.Add(item);
                    }

                    if (maxtal > svar)
                    {
                        svar = maxtal;
                        delarray.Clear();

                        foreach (int part in templist)
                        {
                            delarray.Add(part);
                        }
                        templist.Clear();
                    }

                    templist.Clear();
                    numlist.RemoveAt(numlist.Count - 1);
                }

                numlist = nums.ToList();
                listlängd = numlist.Count;
            }

            numlist.Reverse();

            for (int i = 0; i < numlist.Count; i++)
            {

                numlist.RemoveRange(0, i);

                maxtal = 0;

                foreach (int item in numlist)
                {
                    maxtal += item;
                    templist.Add(item);
                }

                if (maxtal > svar)
                {
                    svar = maxtal;
                    delarray.Clear();

                    foreach (int part in templist)
                    {
                        delarray.Add(part);
                    }
                    templist.Clear();
                }

                templist.Clear();

                numlist = nums.ToList();
                numlist.Reverse();
            }

            Console.Write("Delarna av arrayen är: ");
            foreach (int del in delarray)
            {
                Console.Write(del + ", ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Summan är: " + svar);

        }
    }
}