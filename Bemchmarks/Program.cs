﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotohellt
{
    class OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results
    {
        public int Time { get; set; }
        public string Name { get; set; }
        public OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results(string Name, int Time)
        {
            this.Name = Name;
            this.Time = Time;
        }
        public override string ToString()
        {
            return string.Format("{0, 15} took: {1} miliseconds", Name, Time);
        }
        public void WriteToConsole()
        {
            Console.WriteLine(ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            meme("Hola Mundo");

            Console.WriteLine("Waiting to init");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Starting!");

            uint Num = int.MaxValue;
            int Repeats = 4;
            for (int i = 0; i < Repeats; i++)
            {
                List<int> all = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
                List<OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results> results = new List<OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results>();
                Random Rnd = new Random();
                while (all.Count > 0)
                {
                    int index = Rnd.Next(0, all.Count);
                    OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results Obj2;
                    if ((Obj2 = Run(all[index], Num)) != null)
                    {
                        results.Add(Obj2);
                    }
                    all.RemoveAt(index);

                }
                foreach (OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results O in results)
                {
                    O.WriteToConsole();
                }
            }
            Console.ReadKey(false);
        }

        static void meme(string str)
        {
            Func<string, bool> w = (c) => {
                Func<string, bool> b = (c) => {
                    Func<string, bool> a = (c) => {
                        Func<string, bool> f = (c) => {
                            Func<char, bool> ch = (c) => {
                                Console.Write(c);
                                return true;
                            };
                            foreach (char cha in c)
                            {
                                ch.Invoke(cha);
                            }
                            Console.WriteLine();
                            return true;
                        };
                        return f.Invoke(c);
                    };
                    return a.Invoke(c);
                };
                return b.Invoke(c);
            };
            w.Invoke(str);
        }

        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results Run(int N, uint Num)
        {
            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string wich = "";
            switch (N)
            {
                case 0:
                    wich = GotoLoopA(Num);
                    break;
                case 1:
                    wich = GotoLoopB(Num);
                    break;
                case 2:
                    wich = WhileLoopA(Num);
                    break;
                case 3:
                    wich = WhileLoopB(Num);
                    break;
                case 4:
                    wich = DoWhileLoopA(Num);
                    break;
                case 5:
                    wich = DoWhileLoopB(Num);
                    break;
                case 6:
                    wich = ForLoopA(Num);
                    break;
                case 7:
                    wich = ForLoopB(Num);
                    break;
            }
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results(wich, Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static string GotoLoopA(uint num)
        {
            var count = num;
            start:
            --count;
            if (count > 0)
            {
                Write();
                goto start;
            }
            start2:
            ++count;
            if (count < num)
            {
                Write();
                goto start2;
            }
            return "Sign Goto";
        }
        static string GotoLoopB(uint num)
        {
            var count = num;
            start:
            count--;
            if (count > 0)
            {
                Write();
                goto start;
            }
            start2:
            count++;
            if (count < num)
            {
                Write();
                goto start2;
            }
            return "Goto Sign";
        }
        static string WhileLoopA(uint num)
        {
            var count = num;
            while (count > 0)
            {
                Write();
                --count;
            }
            while (count < num)
            {
                Write();
                ++count;
            }
            return "Sign While";
        }
        static string WhileLoopB(uint num)
        {
            var count = num;
            while (count > 0)
            {
                Write();
                count--;
            }
            while (count < num)
            {
                Write();
                count++;
            }
            return "While Sign";
        }
        static string DoWhileLoopA(uint num)
        {
            uint count = num;
            do
            {
                Write();
                --count;
            } while (count > 0);
            do
            {
                Write();
                ++count;
            } while (count < num);
            return "Sign DoWhile";
        }
        static string DoWhileLoopB(uint num)
        {
            var count = num;
            do
            {
                Write();
                count--;
            } while (count > 0);
            do
            {
                Write();
                count++;
            } while (count < num);
            return "DoWhile Sign";
        }
        static string ForLoopA(uint num)
        {
            var count = num;
            for (var i = count; i > 0; --i) { Write(); }
            for (var i = 0; i < num; ++i) { Write(); }
            return "Sign For";
        }
        static string ForLoopB(uint num)
        {
            var count = num;
            for (var i = count; i > 0; i--) { Write(); }
            for (var i = 0; i < num; i++) { Write(); }
            return "For Sign";
        }
        static void Write()
        {
            // None
        }
    }


}
