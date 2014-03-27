using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nsClearConsole;

namespace My_First_CSharp_APP
{
    struct read
    {
        public int year ;
        public int mounth ;
        public int day ;
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            read input;
            read input2;
            int chooese = -1;
            ClearConsole ClearMyConsole = new ClearConsole();
            while (chooese != 0)
            {
                ClearMyConsole.Clear(); // Clear the screen
                Meanu();
                chooese = int.Parse(Console.ReadLine());
                switch (chooese)
                {
                    case 0:
                        Console.WriteLine("結束");
                        break;
                    case 1:
                        Console.WriteLine("(1.)所有三位數(100~999)之『阿姆斯壯數』");
                        fun1();
                        break;
                    case 2:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(2.)輸入一個西元年份，判斷其為閏年或平年。輸入-1結束此題");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            if (input.year == 0)
                            {
                                Console.WriteLine("請輸入合法數字 -1 結束 or 大於0 ");
                            }
                            else if (isYear(input.year) == 1)
                                Console.WriteLine("{0}為閏年", input.year);
                            else if (input.year < -1 )                            
                                Console.WriteLine("請輸入合法數字 -1 結束 or 大於0 ");                            
                            else
                                Console.WriteLine("{0}為平年", input.year);
                            Console.WriteLine("(2.)輸入一個西元年份，判斷其為閏年或平年。輸入-1結束此題");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 3:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(3.)輸入一個西元年份及月份，印出該月的天數。輸入-1結束此題");
                        Console.WriteLine("輸入一個西元年份");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {                            
                            Console.WriteLine("輸入一個月份");
                            input.mounth = int.Parse(Console.ReadLine());

                            if(!isTrueDay(input.year, input.mounth, 1))
                                Console.WriteLine("請輸入合法數字。年份>0，月份1~12");
                            else 
                                Console.WriteLine("該月有{0}天", isMounth(input.year, input.mounth));
                            Console.WriteLine("(3.)輸入一個西元年份及月份，印出該月的天數。輸入-1結束此題");
                            Console.WriteLine("輸入一個西元年份");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 4:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(4.)輸入年、月、日，印出該日是星期幾。輸入-1結束此題");
                        Console.WriteLine("輸入一個西元年份");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            Console.WriteLine("輸入一個月份");
                            input.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("輸入日期");
                            input.day = int.Parse(Console.ReadLine());

                            if (!isTrueDay(input.year, input.mounth, input.day))
                                Console.WriteLine("查無此日。請輸入合法數字。年份>0，月份1~12，有效日期");

                            else
                                Console.WriteLine("這天為星期{0}", isDay(input.year, input.mounth, input.day));

                            Console.WriteLine("(4.)輸入一個西元年份及月份，印出該月的天數。輸入-1結束此題");
                            Console.WriteLine("輸入一個西元年份");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 5:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(5.)輸入年、月、日，判斷該日是否合法。輸入-1結束此題");
                        Console.WriteLine("輸入一個西元年份");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            Console.WriteLine("輸入一個月份");
                            input.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("輸入日期");
                            input.day = int.Parse(Console.ReadLine());

                            if (isDay(input.year, input.mounth, input.day) != 0)
                                Console.WriteLine("該日是否合法:\n {0}", isTrueDay(input.year, input.mounth, input.day));
                            else
                                Console.WriteLine("請輸入合法數字");

                            Console.WriteLine("(5.)輸入年、月、日，判斷該日是否合法。輸入-1結束此題");
                            Console.WriteLine("輸入一個西元年份");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 6:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(6.)輸入兩個日期，起始年、月、日以及結束年、月、日，\n    印出這兩個日期之間(不包含起始日與結束日)有多少日\n    輸入-1結束此題");
                        Console.WriteLine("輸入起始西元年份");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            Console.WriteLine("輸入起始月份");
                            input.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("輸入起始日期");
                            input.day = int.Parse(Console.ReadLine());
                            if (!isTrueDay(input.year, input.mounth, input.day))
                            {
                                Console.WriteLine("查無此日。請輸入合法數字。年份>0，月份1~12，有效日期");
                                goto Finish;
                            }
                        found:
                            Console.WriteLine("輸入*結束*西元年份");
                            input2.year = int.Parse(Console.ReadLine());
                            Console.WriteLine("輸入*結束*月份");
                            input2.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("輸入*結束*日期");
                            input2.day = int.Parse(Console.ReadLine());
                            if (!isTrueDay(input2.year, input2.mounth, input2.day))
                            {
                                Console.WriteLine("查無此日。請輸入合法數字。年份>0，月份1~12，有效日期");
                                goto found;
                            }
                            Console.WriteLine("這兩個日期之間(不包含起始日與結束日)\n有\t{0}\t日", howmanyDay(input.year, input.mounth, input.day, input2.year, input2.mounth, input2.day));

                        Finish:
                            Console.WriteLine("(6.)輸入兩個日期，起始年、月、日以及結束年、月、日，\n    印出這兩個日期之間(不包含起始日與結束日)有多少日\n    輸入-1結束此題");
                            Console.WriteLine("輸入一個西元年份");
                            input.year = int.Parse(Console.ReadLine());
                        }                     
                        break;
                    default:
                        Console.WriteLine("請輸入0~6.......(0結束)");
                        break;

                }
                Console.WriteLine("任意輸入，開始下一步");
                Console.ReadLine();
            }
            Console.ReadLine();


        }
        static void Meanu()//選單
        {
            Console.WriteLine("--------------HW1-----------------------");
            Console.WriteLine("(1.)所有三位數(100~999)之『阿姆斯壯數』");
            Console.WriteLine("(2.)輸入一個西元年份，判斷其為閏年或平年");
            Console.WriteLine("(3.)輸入一個西元年份及月份，印出該月的天數");
            Console.WriteLine("(4.)輸入年、月、日，印出該日是星期幾");
            Console.WriteLine("(5.)輸入年、月、日，判斷該日是否合法");
            Console.WriteLine("(6.)輸入兩個日期，起始年、月、日以及結束年、月、日，\n    印出這兩個日期之間(不包含起始日與結束日)有多少日。\n    輸入-1結束此題");
            Console.WriteLine("----------------請輸入題號--------------");
            Console.WriteLine("輸入0結束");
        }
        static void fun1()//阿姆斯壯數
        {
            int armo = 0;
            int armo1 = 0;
            int armo2 = 0;
            int armo3 = 0;
            for (int i = 100; i <= 999; i++)
            {
                armo = i;
                armo1 = armo / 100;
                armo2 = armo / 10 - armo1 * 10;
                armo3 = armo % 10;
                if (armo == armo1 * armo1 * armo1 + armo2 * armo2 * armo2 + armo3 * armo3 * armo3)
                    Console.WriteLine("{0}", armo);
            }
        }
        static int isYear(int year)//判斷閏年1、平年0
        {
            if (year % 4 == 0 && year % 100 > 0)
                return 1;


            else if (year % 400 == 0)
                return 1;
            else
                return 0;
        }
        static int isMounth(int year, int mounth)//判斷指定月份有幾天
        {
            year = isYear(year);
            for (int i = 1; i < 8; i++)//判斷1~7月
            {
                if (i % 2 == 1 && mounth == i)
                    return 31;
                if (i % 2 == 0 && mounth == i && mounth != 2)
                    return 30;
                if (i % 2 == 0 && mounth == i && mounth == 2)
                {
                    if (year==1)
                        return 29;

                    else
                        return 28;
                }
            }
            for (int i = 8; i < 13; i++) //判斷8~12月
            {
                if (i % 2 == 0 && mounth == i)
                    return 31;
                if (i % 2 == 1 && mounth == i)
                    return 30; 
            }
            return 0;
        }
        static Boolean isTrueDay(int year, int mounth, int day)
        {
            if (year<-1 || year==0 || mounth > 12 || mounth < 1)
                return false;
            else if (day < 1 || day > isMounth(year, mounth))
                return false;
            else
                return true;
        }
        static int isDay(int year, int mounth, int day)//判斷指定月份有幾天
        {
            int nadd = 0;
            //2014元旦星期3    2014/2/26/3
            int inishoDay=3;

            //判斷+-幾年
            if (year == 2014)
            {
                nadd = 0;
            }
            else if (year > 2014)
            {
                for (int i = 2014; i < year; i++)
                {
                    if (isYear(i) != 0)
                    {
                        nadd += 2; //閏年+2
                    }
                    else
                    {
                        nadd += 1; //平年 +1
                    }
                }
            }
            else
            {
                for (int i = 2013; i >= year; i--)
                {
                    if (isYear(i) != 0)
                        nadd -= 2;
                    else
                        nadd -= 1;
                }
            }
            //if end

            //計算該年元旦是星期幾inishoDay:0~6
            inishoDay = (inishoDay + nadd) % 7;
            if (inishoDay < 0)
                inishoDay += 7;
            //計算該月的第一天是星期幾
            nadd = 0;
            for (int i = 1; i < mounth; i++)
            {
                if (i == mounth)
                    break;
                nadd+=isMounth(year,i);
            }
            //計算該月1日是星期幾
            inishoDay = (inishoDay + nadd) % 7;
            //計算該月__日是星期幾
            inishoDay = (inishoDay + day - 1) % 7;
            if (inishoDay == 0)
                return 7;
            else if (inishoDay >= 1 && inishoDay <= 7)
                return inishoDay;
            else
                return 0;
        }
        static int howmanyDay(int year, int mounth, int day, int year2, int mounth2, int day2)
        {
            int nadd = 0;
            int sumday = 0;
            int mounthday = 0;
            //年數換成天數
            for (int i = year; i < year2; i++)
            {
                if (isYear(i) != 0)
                    nadd++;
            }
            sumday = nadd+(year2-year)*365;
            //第一年的mounth以前
            for (int i = 1; i <= mounth; i++)
            {
                if (i == mounth)
                    break;
                mounthday += isMounth(year, i);
            }
            sumday = sumday - mounthday - day;
            mounthday = 0;
            for (int i = 1; i <= mounth2; i++)
            {
                if (i == mounth2)
                    break;
                mounthday += isMounth(year2, i);
            }
            sumday += mounthday + day2;
            return sumday-1;
             
        }
    }
}
