using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 12; i++) {
                Console.WriteLine("== RUNNING TASK " + (i + 1) + " ==");
                task(i);
            }

            Console.ReadKey();

        }

        static void task(int task) {
            switch (task) {
                case 0: {
                        for (int i = 0; i < 4; i++) {
                            Console.WriteLine("******");
                        }
                        break;
                    }
                case 1: {
                        for (int i = 1; i < 11; i++) {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        break;
                    }
                case 2: {
                        for (int i = 1; i < 6; i++) {
                            Console.WriteLine(i);
                        }
                        break;
                    }
                case 3: {
                        for (int i = 2; i < 13; i += 2) {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;
                    }
                case 4: {
                        for (int i = 9; i > 0; i--) {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;
                    }
                case 5: {
                        for (int i = 1; i < 6; i++) {
                            Console.WriteLine(new string('*', i));
                        }
                        break;
                    }
                case 6: {
                        for (int i = 5; i > 0; i--) {
                            Console.WriteLine(new string('#', i));
                        }
                        break;
                    }
                case 7: {
                        for (int i = 1; i < 6; i++) {
                            for (int x = 1; x <= i; x++) {
                                Console.Write(x);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case 8: {
                        Console.Write("Please enter a number: ");
                        int i = 0;

                        while (!int.TryParse(Console.ReadLine(), out i)) ;

                        for (int x = 0; x < i; x++) {
                            Console.WriteLine("Lunch time");
                        }
                        break;
                    }
                case 9: {
                        for (int i = 1; i < 8; i++) {
                            for (int x = 1; x <= i; x++) {
                                Console.Write(x);
                            }
                            Console.WriteLine(new string('*', 7 - i));
                        }
                        break;
                    }
                case 10: {
                        Console.Write("Please enter a number: ");
                        int x = 0;

                        while (!int.TryParse(Console.ReadLine(), out x)) ;
                        for (int i = 0; i <= x; i++) {
                            Console.WriteLine(i);
                        }
                        break;
                    }
                case 11: {
                        Console.Write("Please enter a width: ");
                        int w = 0;

                        while (!int.TryParse(Console.ReadLine(), out w)) ;

                        Console.Write("Please enter a height: ");
                        int h = 0;

                        while (!int.TryParse(Console.ReadLine(), out h)) ;

                        for (int y = 0; y < h; y++) {
                            for (int x = 0; x < w; x++) {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
            }
        }
    }
}
