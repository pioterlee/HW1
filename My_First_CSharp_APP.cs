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
                        Console.WriteLine("����");
                        break;
                    case 1:
                        Console.WriteLine("(1.)�Ҧ��T���(100~999)���y���i�����ơz");
                        fun1();
                        break;
                    case 2:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(2.)��J�@�Ӧ褸�~���A�P�_�䬰�|�~�Υ��~�C��J-1�������D");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            if (input.year == 0)
                            {
                                Console.WriteLine("�п�J�X�k�Ʀr -1 ���� or �j��0 ");
                            }
                            else if (isYear(input.year) == 1)
                                Console.WriteLine("{0}���|�~", input.year);
                            else if (input.year < -1 )                            
                                Console.WriteLine("�п�J�X�k�Ʀr -1 ���� or �j��0 ");                            
                            else
                                Console.WriteLine("{0}�����~", input.year);
                            Console.WriteLine("(2.)��J�@�Ӧ褸�~���A�P�_�䬰�|�~�Υ��~�C��J-1�������D");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 3:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(3.)��J�@�Ӧ褸�~���Τ���A�L�X�Ӥ몺�ѼơC��J-1�������D");
                        Console.WriteLine("��J�@�Ӧ褸�~��");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {                            
                            Console.WriteLine("��J�@�Ӥ��");
                            input.mounth = int.Parse(Console.ReadLine());

                            if(!isTrueDay(input.year, input.mounth, 1))
                                Console.WriteLine("�п�J�X�k�Ʀr�C�~��>0�A���1~12");
                            else 
                                Console.WriteLine("�Ӥ릳{0}��", isMounth(input.year, input.mounth));
                            Console.WriteLine("(3.)��J�@�Ӧ褸�~���Τ���A�L�X�Ӥ몺�ѼơC��J-1�������D");
                            Console.WriteLine("��J�@�Ӧ褸�~��");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 4:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(4.)��J�~�B��B��A�L�X�Ӥ�O�P���X�C��J-1�������D");
                        Console.WriteLine("��J�@�Ӧ褸�~��");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            Console.WriteLine("��J�@�Ӥ��");
                            input.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("��J���");
                            input.day = int.Parse(Console.ReadLine());

                            if (!isTrueDay(input.year, input.mounth, input.day))
                                Console.WriteLine("�d�L����C�п�J�X�k�Ʀr�C�~��>0�A���1~12�A���Ĥ��");

                            else
                                Console.WriteLine("�o�Ѭ��P��{0}", isDay(input.year, input.mounth, input.day));

                            Console.WriteLine("(4.)��J�@�Ӧ褸�~���Τ���A�L�X�Ӥ몺�ѼơC��J-1�������D");
                            Console.WriteLine("��J�@�Ӧ褸�~��");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 5:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(5.)��J�~�B��B��A�P�_�Ӥ�O�_�X�k�C��J-1�������D");
                        Console.WriteLine("��J�@�Ӧ褸�~��");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            Console.WriteLine("��J�@�Ӥ��");
                            input.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("��J���");
                            input.day = int.Parse(Console.ReadLine());

                            if (isDay(input.year, input.mounth, input.day) != 0)
                                Console.WriteLine("�Ӥ�O�_�X�k:\n {0}", isTrueDay(input.year, input.mounth, input.day));
                            else
                                Console.WriteLine("�п�J�X�k�Ʀr");

                            Console.WriteLine("(5.)��J�~�B��B��A�P�_�Ӥ�O�_�X�k�C��J-1�������D");
                            Console.WriteLine("��J�@�Ӧ褸�~��");
                            input.year = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 6:
                        ClearMyConsole.Clear(); // Clear the screen
                        Console.WriteLine("(6.)��J��Ӥ���A�_�l�~�B��B��H�ε����~�B��B��A\n    �L�X�o��Ӥ������(���]�t�_�l��P������)���h�֤�\n    ��J-1�������D");
                        Console.WriteLine("��J�_�l�褸�~��");
                        input.year = int.Parse(Console.ReadLine());
                        while (input.year != -1)
                        {
                            Console.WriteLine("��J�_�l���");
                            input.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("��J�_�l���");
                            input.day = int.Parse(Console.ReadLine());
                            if (!isTrueDay(input.year, input.mounth, input.day))
                            {
                                Console.WriteLine("�d�L����C�п�J�X�k�Ʀr�C�~��>0�A���1~12�A���Ĥ��");
                                goto Finish;
                            }
                        found:
                            Console.WriteLine("��J*����*�褸�~��");
                            input2.year = int.Parse(Console.ReadLine());
                            Console.WriteLine("��J*����*���");
                            input2.mounth = int.Parse(Console.ReadLine());
                            Console.WriteLine("��J*����*���");
                            input2.day = int.Parse(Console.ReadLine());
                            if (!isTrueDay(input2.year, input2.mounth, input2.day))
                            {
                                Console.WriteLine("�d�L����C�п�J�X�k�Ʀr�C�~��>0�A���1~12�A���Ĥ��");
                                goto found;
                            }
                            Console.WriteLine("�o��Ӥ������(���]�t�_�l��P������)\n��\t{0}\t��", howmanyDay(input.year, input.mounth, input.day, input2.year, input2.mounth, input2.day));

                        Finish:
                            Console.WriteLine("(6.)��J��Ӥ���A�_�l�~�B��B��H�ε����~�B��B��A\n    �L�X�o��Ӥ������(���]�t�_�l��P������)���h�֤�\n    ��J-1�������D");
                            Console.WriteLine("��J�@�Ӧ褸�~��");
                            input.year = int.Parse(Console.ReadLine());
                        }                     
                        break;
                    default:
                        Console.WriteLine("�п�J0~6.......(0����)");
                        break;

                }
                Console.WriteLine("���N��J�A�}�l�U�@�B");
                Console.ReadLine();
            }
            Console.ReadLine();


        }
        static void Meanu()//���
        {
            Console.WriteLine("--------------HW1-----------------------");
            Console.WriteLine("(1.)�Ҧ��T���(100~999)���y���i�����ơz");
            Console.WriteLine("(2.)��J�@�Ӧ褸�~���A�P�_�䬰�|�~�Υ��~");
            Console.WriteLine("(3.)��J�@�Ӧ褸�~���Τ���A�L�X�Ӥ몺�Ѽ�");
            Console.WriteLine("(4.)��J�~�B��B��A�L�X�Ӥ�O�P���X");
            Console.WriteLine("(5.)��J�~�B��B��A�P�_�Ӥ�O�_�X�k");
            Console.WriteLine("(6.)��J��Ӥ���A�_�l�~�B��B��H�ε����~�B��B��A\n    �L�X�o��Ӥ������(���]�t�_�l��P������)���h�֤�C\n    ��J-1�������D");
            Console.WriteLine("----------------�п�J�D��--------------");
            Console.WriteLine("��J0����");
        }
        static void fun1()//���i������
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
        static int isYear(int year)//�P�_�|�~1�B���~0
        {
            if (year % 4 == 0 && year % 100 > 0)
                return 1;


            else if (year % 400 == 0)
                return 1;
            else
                return 0;
        }
        static int isMounth(int year, int mounth)//�P�_���w������X��
        {
            year = isYear(year);
            for (int i = 1; i < 8; i++)//�P�_1~7��
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
            for (int i = 8; i < 13; i++) //�P�_8~12��
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
        static int isDay(int year, int mounth, int day)//�P�_���w������X��
        {
            int nadd = 0;
            //2014�����P��3    2014/2/26/3
            int inishoDay=3;

            //�P�_+-�X�~
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
                        nadd += 2; //�|�~+2
                    }
                    else
                    {
                        nadd += 1; //���~ +1
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

            //�p��Ӧ~�����O�P���XinishoDay:0~6
            inishoDay = (inishoDay + nadd) % 7;
            if (inishoDay < 0)
                inishoDay += 7;
            //�p��Ӥ몺�Ĥ@�ѬO�P���X
            nadd = 0;
            for (int i = 1; i < mounth; i++)
            {
                if (i == mounth)
                    break;
                nadd+=isMounth(year,i);
            }
            //�p��Ӥ�1��O�P���X
            inishoDay = (inishoDay + nadd) % 7;
            //�p��Ӥ�__��O�P���X
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
            //�~�ƴ����Ѽ�
            for (int i = year; i < year2; i++)
            {
                if (isYear(i) != 0)
                    nadd++;
            }
            sumday = nadd+(year2-year)*365;
            //�Ĥ@�~��mounth�H�e
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
