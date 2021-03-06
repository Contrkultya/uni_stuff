﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeHWOOPFFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Time24 hammerTime = new Time24(13, 37);
            Console.WriteLine("hammer Time info: " + hammerTime.info());
            hammerTime.show();
            Time24 nowItsTimeToDiiiiie = Time24.Create(12);
            Console.WriteLine("nowItsTimeToDie info: " + nowItsTimeToDiiiiie.info());
            nowItsTimeToDiiiiie.assign(Console.ReadLine());
            Console.WriteLine("Приравняли nowItsTimeToDie к инпуту: " + nowItsTimeToDiiiiie.info());
            Console.WriteLine("Сравним эти два времени: " + hammerTime.compare(nowItsTimeToDiiiiie));
            hammerTime.nextMin();
            Console.WriteLine("Добавили минуту к hammerTime: " + hammerTime.info());
            hammerTime.prevMin();
            Console.WriteLine("Убрали миунту от hammerTime: " + hammerTime.info());
            Console.WriteLine("Время до конца дня: " +hammerTime.timeRemain().hourR);
            hammerTime.nearHour();
            Console.WriteLine("Округленное до часа: " + hammerTime.hourR);
            hammerTime.setHours(13);
            hammerTime.setMinutes(37);
            hammerTime.show();
            Console.WriteLine("Надо ли спац: " + hammerTime.checkIfAsleep());
            hammerTime.stupidAmericano();
            Console.WriteLine("Разбуди меня через: " + hammerTime.timeTill420am().hourR);
            Console.ReadLine();
        }
    }
}
