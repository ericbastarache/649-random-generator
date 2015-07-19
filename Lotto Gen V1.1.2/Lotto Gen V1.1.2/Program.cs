using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lotto_Gen_V1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genPlease = new Random();
            string filePath = "C:\\Users\\Owner\\Desktop\\lottonums.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();

                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    int[] lottoNums = new int[6];
                    for (int i = 0; i < 51; i++)
                    {
                        int one = genPlease.Next(1, 50);
                        int two = genPlease.Next(1, 50);
                        int three = genPlease.Next(1, 50);
                        int four = genPlease.Next(1, 50);
                        int five = genPlease.Next(1, 50);
                        int six = genPlease.Next(1, 50);


                        if (one == two || one == three || one == four || one == five || one == six)
                        {
                            one = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[0] = one;
                        }
                        if (two == one || two == three || two == four || one == five || one == six)
                        {
                            two = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[1] = two;
                        }
                        if (three == one || three == two || three == four || three == five || three == six)
                        {
                            three = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[2] = three;
                        }
                        if (four == one || four == two || four == three || four == five || four == six)
                        {
                            four = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[3] = four;
                        }
                        if (five == one || five == two || five == three || five == four || five == six)
                        {
                            five = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[4] = five;
                        }
                        if (six == one || six == two || six == three || six == four || six == five)
                        {
                            six = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[5] = six;
                        }

                       
                        lottoNums[0] = one;
                        lottoNums[1] = two;
                        lottoNums[2] = three;
                        lottoNums[3] = four;
                        lottoNums[4] = five;
                        lottoNums[5] = six;

                        Array.Sort(lottoNums);

                        foreach (int x in lottoNums)
                        {
                            string s = x.ToString();
                            string t = s + " - ";
                            t.Substring(0, t.Length - 3);
                            sw.Write(t); 
                        }
                        sw.WriteLine();
                        sw.Flush();
                    }

                }
            }
            else if (File.Exists(filePath))
            {
                File.Delete(filePath);
                File.Create(filePath).Dispose();

                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    int[] lottoNums = new int[6];
                    for (int i = 0; i < 51; i++)
                    {
                        int one = genPlease.Next(1, 11);
                        int two = genPlease.Next(11, 21);
                        int three = genPlease.Next(21, 31);
                        int four = genPlease.Next(31, 41);
                        int five = genPlease.Next(41, 50);
                        int six = genPlease.Next(1, 50);

                        if (one == two || one == three || one == four || one == five || one == six)
                        {
                            one = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[0] = one;
                        }
                        if (two == one || two == three || two == four || two == five || two == six)
                        {
                            two = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[1] = two;
                        }
                        if (three == one || three == two || three == four || three == five || three == six)
                        {
                            three = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[2] = three;
                        }
                        if (four == one || four == two || four == three || four == five || four == six)
                        {
                            four = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[3] = four;
                        }
                        if (five == one || five == two || five == three || five == four || five == six)
                        {
                            five = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[4] = five;
                        }
                        if (six == one || six == two || six == three || six == four || six == five)
                        {
                            six = genPlease.Next(1, 50);
                        }
                        else
                        {
                            lottoNums[5] = six;
                        }
                        


                        lottoNums[0] = one;
                        lottoNums[1] = two;
                        lottoNums[2] = three;
                        lottoNums[3] = four;
                        lottoNums[4] = five;
                        lottoNums[5] = six;

                        Array.Sort(lottoNums);

                        foreach (int x in lottoNums)
                        {
                            string s = x.ToString();
                            string t = s + " - ";
                            t.Substring(0, t.Length - 3);
                            sw.Write(t);
                        }
                        sw.WriteLine();
                        sw.Flush();
                    }
                }
            }
        }
    }
}
