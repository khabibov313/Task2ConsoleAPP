namespace Task2ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //int y = number4();
            //int son, sum = 0;

            //while (y > 0)
            //{
            //	son = y % 10;
            //	sum += son;
            //	y /= 10;
            //}
            //Console.WriteLine($"reqemlerinin cemi={sum}");
            #endregion
            #region task2
            //int y = number6();
            //int ilk3, son, sum = 0;
            //ilk3 = y / 1000;
            //while (ilk3 > 0)
            //{
            //	son = ilk3 % 10;
            //	sum += son;
            //	ilk3 /= 10;
            //}
            //Console.WriteLine($"ilk 3 reqeminin cemi={sum}");




            #endregion
            #region task3
            //int x = number9();
            //int orta, sum = 0, son;
            //orta = (x / 1000) % 1000;
            //Console.WriteLine(orta);
            //while (orta > 0)
            //{
            //	son = orta % 10;
            //	sum += son;
            //	orta /= 10;
            //}
            //Console.WriteLine($"ortadaki 3 reqemin cemi={sum}");
            #endregion
            #region task4
            //int x = number5();
            //int first, end;
            //first = x / 10000;
            //end = x % 10;


            //Console.WriteLine($"ilk reqem={first}");
            //Console.WriteLine($"son reqem={end}");
            //Console.WriteLine($"ilk ve son reqemin ceminin kvadrati={(first + end) * (first + end)}");

            #endregion
            #region task5
            //int x = number6();
            //int first;
            //first = x / 100000;
            //x = x * 10 + first;



            //Console.WriteLine($"ilk reqem={first}");

            //Console.WriteLine($"ilk reqemin sona atilmis varianti={x}");

            #endregion
            #region task6
            //int x = number8();
            //x = x / 10;
            //x = x % 1000000;



            //Console.WriteLine($"ilk ve son reqemi silinmis varianti={x}");

            #endregion
            #region task7
            //int x = number4();
            //int ters = 0, son;

            //while (x > 0)
            //{
            //	son = x % 10;
            //	ters = ters * 10 + son;
            //	x /= 10;
            //}
            //Console.WriteLine($"ededin tersi={ters}");
            //ters = 8 * 100000 + ters * 10 + 8;
            //Console.WriteLine($"tersin evveline ve sonuna 8 artirilmis varianti={ters}");
            #endregion
            #region task8
            //Console.Write("eded:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int son, sondan3;
            //son = n % 10;
            //sondan3 = (n % 1000) / 100;
            //Console.WriteLine($"ededin son reqemi={son}\nededin sondan 3-cu reqemi={sondan3}");
            //n = son + sondan3;
            //Console.WriteLine($"onlarin cemi={n}");
            #endregion
            #region task9			

            //int a = number9();
            //int son = 0, tersA = 0;
            //while (a > 0)
            //{
            //	son = a % 10;
            //	tersA = tersA * 10 + son;
            //	a /= 10;

            //}
            //int part1 = 0 ;
            //int i = 1;
            //while (tersA > 0)
            //{
            //	son = tersA % 10;
            //	tersA /= 10;
            //	if (i % 2 == 1)
            //	{
            //		part1 = part1 * 10 + son;
            //	}

            //	i++;


            //}
            //Console.WriteLine(part1);


            #endregion
            #region task10
            //int a = number9();
            //int son = 0, tersA = 0;
            //while (a > 0)
            //{
            //	son = a % 10;
            //	tersA = tersA * 10 + son;
            //	a /= 10;

            //}
            //int part1 = 0, part2 = 0;
            //int i = 1;
            //while (tersA > 0)
            //{
            //	son = tersA % 10;
            //	tersA /= 10;
            //	if (i % 2 == 0)
            //	{
            //		part2 = part2 * 10 + son;
            //	}
            //	if (i % 2 != 0)
            //	{
            //		part1 = part1 * 10 + son;
            //	}
            //	i++;


            //}
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
            //Console.WriteLine($"onlarin cemi={part1}+{part2}={part1 + part2}");
            #endregion
            #region task11
            //int x = number8();
            //int sum = 0, son2;

            //while (x > 0)
            //{
            //	son2 = x % 100;
            //	sum += son2;
            //	x /= 100;
            //}
            //Console.WriteLine($"cem={sum}");
            //sum = sum * 100 + 99;
            //Console.WriteLine($"sonuna 99 artirilmis varianti={sum}");
            //sum = sum - (sum / 100) * 18;
            //Console.WriteLine($"son netice={sum}");
            #endregion
            #region task12
            //int y = number5();
            //int x = number5();

            //int son, sum = 0, total = 1;
            //int temp = y;
            //while (y > 0)
            //{
            //	son = y % 10;
            //	sum += son;
            //	y /= 10;
            //}
            //while (x > 0)
            //{
            //	son = x % 10;
            //	total *= son;
            //	x /= 10;
            //}
            //Console.WriteLine($"1-ci ededin reqemlerinin cemi={sum}");
            //Console.WriteLine($"2-ci ededin reqemlerinin hasili={total}");
            //sum = sum + total;
            //Console.WriteLine($"hasilin ve cemin toplami={sum}");
            //sum = sum * 10 + (temp % 10);
            //Console.WriteLine($"son netice={sum}");

            #endregion
            #region task13
            //int y = number5();
            //int x = number5();
            //int z = number5();

            //int ilk, son, eded1, eded2;
            //double eded3;
            //ilk = y / 10000;
            //son = y % 10;
            //eded1 = ilk * 10 + son;
            //ilk = x / 10000;
            //son = x % 10;
            //eded2 = ilk * 10 + son;
            //ilk = z / 10000;
            //son = z % 10;
            //eded3 = ilk * 10 + son;
            //eded3 = eded1 + eded2 + eded3;
            //Console.WriteLine($"sonradan duzeldilmis ededlerin cemi={eded3}");
            //eded3 = eded3 + eded3 / 2;
            //Console.WriteLine($"sondaki netice={eded3}");




            #endregion
            #region task14
            //int y = number6();
            //int x = number6();
            //int z = number6();
            //int t = number7();

            //int ilk1, ilk2, ilk3, son, total = 1;
            //ilk1 = y / 1000;
            //ilk2 = x / 1000;
            //ilk3 = z / 1000;
            //ilk3 = ilk1 + ilk2 + ilk3;
            //ilk3 = ilk3 + (t % 10000);
            //ilk1 = t / 10000;
            //while (ilk1 > 0)
            //{
            //	son = ilk1 % 10;
            //	total *= son;
            //	ilk1 /= 10;
            //}
            //ilk3 = ilk3 - total;
            //ilk3 = (ilk3 / 10) * 6;
            //ilk3 = ilk3 * 100 + 60;
            //ilk3 = ilk3 - (ilk3 / 100) * 18;
            //Console.WriteLine($"son netice={ilk3}");






            #endregion,
            #region task15
            int y = number3();
            int x = number3();
            int z = number6();
            int t = number6();
            int s = number7();



            int sum, son, son1, ters = 0, end;
            sum = y + x;
            son = sum % 100;
            son = son * son;
            son = son + y * 1000 + x;
            son = son - s % 100000;
            son = son + (z + t) % 1000;
            while (s > 0)
            {
                son1 = s % 10;
                sum += son1;
                s /= 10;


            }
            while (sum > 0)
            {
                son1 = sum % 10;
                ters = ters * 10 + son1;
                sum /= 10;

            }
            son = son + ters;
            son = son * 100 + 11;

            while (s > 0)
            {
                end = s % 10;
                ters = ters * 10 + end;
                s /= 10;
            }
            int i = 1, parttek = 0;
            while (ters > 0)
            {
                end = ters % 10;
                ters /= 10;
                if (i % 2 != 0)
                {
                    parttek = parttek * 10 + end;
                }
                i++;
            }
            son = son - parttek;
            sum = son % 10;
            son1 = son / 10;
            son = son1 * 1000 + 88 * 10 + sum;
            Console.WriteLine($"son netice={son}");













            #endregion






            static int readint()
            {

                int a;
            label1:
                Console.Write("a:");
                string b = Console.ReadLine();

                if (int.TryParse(b, out a) == false)
                {
                    Console.WriteLine("eded daxil etmelisiniz!");
                    goto label1;

                }
                else
                {
                    return a;
                }
            }


            static int number3()
            {
            Label:
                int y = readint();


                if (y > 100 && y < 1000)
                {

                    return y;
                }
                else
                {
                    Console.WriteLine("eded [100,999] araliginda olmalidir!");
                    goto Label;
                }
            }

            static int number4()
            {
            Label:
                int y = readint();


                if (y > 1000 && y < 10000)
                {

                    return y;
                }
                else
                {
                    Console.WriteLine("eded [1000,9999] araliginda olmalidir!");
                    goto Label;
                }
            }



            static int number5()
            {
            Label:
                int y = readint();


                if (y > 10000 && y < 100000)
                {

                    return y;
                }
                else
                {
                    Console.WriteLine("eded [10000,99999] araliginda olmalidir!");
                    goto Label;
                }
            }

            static int number6()
            {
            Label:
                int y = readint();


                if (y > 100000 && y < 1000000)
                {

                    return y;
                }
                else
                {
                    Console.WriteLine("eded [100000,999999] araliginda olmalidir!");
                    goto Label;
                }
            }


            static int number7()
            {
            Label:
                int y = readint();


                if (y > 1000000 && y < 10000000)
                {

                    return y;
                }
                else
                {
                    Console.WriteLine("eded [1000000,9999999] araliginda olmalidir!");
                    goto Label;
                }
            }


            static int number8()
            {
            Label:
                int y = readint();


                if (y > 10000000 && y < 100000000)
                {

                    return y;
                }
                else
                {
                    Console.WriteLine("eded [10000000,99999999] araliginda olmalidir!");
                    goto Label;
                }
            }


            static int number9()
            {
            Label:
                int y = readint();


                if (y > 100000000 && y < 1000000000)
                {

                    return y;
                }
                else
                {
                    Console.WriteLine("eded [100000000,999999999] araliginda olmalidir!");
                    goto Label;
                }
            }
    }
}