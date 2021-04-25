using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2im
{
    static class Line
    {
        private static Random rnd = new Random();
        const double lyambda = 2.5;
        public static double Nobsl,Neobsl,Tpr,TIME;


        public static void Modeling(double time)
        {
            int N = 0; //пришедшие заявки
            int No = 0; //обслуженные заявки
            int Nno = 0; //необслуженные заявки
            double Tp = 0; //время простоя
            double To = 0; //время обслуживания
            double Tb = 0; //время начала обслуживания
            double a = 0.5;
            double b = 1.25;
            double tocb = 0; //время освобождения канала
            double Tw = 0; //время ожидания
            int C = 0; //статус системы
            
            double arrTime = 0;

            while (true)
            {
                arrTime += GetExp();
                if (arrTime > time)
                {
                    Nobsl = No;
                    Neobsl = Nno;
                    Tpr = Tp;
                    TIME = To;
                    return;
                }

                if (arrTime < tocb)
                {
                    if (C > 1)
                    {
                        if (arrTime < Tb)
                        {
                            N++;
                            Nno++;
                        }
                        else
                        {
                            C = 2;
                            Tb = tocb;
                            Tw += tocb - arrTime;
                            tocb = Tb + a + (b - a) * rnd.NextDouble();
                        }
                    }
                    else if (C == 1)
                    {
                        C = 2;
                        Tb = tocb;
                        Tw += tocb - arrTime;
                        tocb = Tb + a + (b - a) * rnd.NextDouble();
                    }

                }
                else
                {
                    C = 1;
                    Tb = arrTime;
                    Tp += (arrTime - tocb);
                    tocb = Tb + a + (b - a) * rnd.NextDouble();
                }

                if (tocb < time)
                {
                    To += a + (b - a) * rnd.NextDouble();
                    No++;
                    N++;
                }
                else
                {
                    Nobsl = No;
                    Neobsl = Nno;
                    Tpr = Tp;
                    TIME = To;
                    return;
                }

            }

           
        }



        private static double GetExp()
        {
            return -Math.Log(1 - rnd.NextDouble())/lyambda;
        }
    }
}
