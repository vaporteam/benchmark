using System;
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
            switch (N)
            {
                case 0:
                    return GotoLoopA(Num);
                case 1:
                    return GotoLoopB(Num);
                case 2:
                    return WhileLoopA(Num);
                case 3:
                    return WhileLoopB(Num);
                case 4:
                    return DoWhileLoopA(Num);
                case 5:
                    return DoWhileLoopB(Num);
                case 6:
                    return ForLoopA(Num);
                case 7:
                    return ForLoopB(Num);
            }
            return null;
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results GotoLoopA(uint num)
        {
            var count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("Sign Goto", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results GotoLoopB(uint num)
        {
            var count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("Goto Sign", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results WhileLoopA(uint num)
        {
            var count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("Sign While", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results WhileLoopB(uint num)
        {
            var count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("While Sign", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results DoWhileLoopA(uint num)
        {
            uint count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("Sign DoWhile", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results DoWhileLoopB(uint num)
        {
            var count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("DoWhile Sign", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results ForLoopA(uint num)
        {
            var count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (var i = count; i > 0; --i) { Write(); }
            for (var i = 0; i < num; ++i) { Write(); }
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("Sign For", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results ForLoopB(uint num)
        {
            var count = num;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (var i = count; i > 0; i--) { Write(); }
            for (var i = 0; i < num; i++) { Write(); }
            watch.Stop();
            return new OooohGuysThisIsSoSadCanWeHit10000LikesInThisVideo_Results("For Sign", Convert.ToInt32(watch.ElapsedMilliseconds));
        }
        static void Write()
        {
            // None
        }
    }


}
