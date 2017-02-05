using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entities;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TesteDB();
            var t1 = new Table1() { Info = 1 }; db.Table1.Add(t1);
            var t2 = new Table1() { Info = 3 }; db.Table1.Add(t2);

            t1.Table2.Add(new Table2() { });

            //t2.Table4.Add(new Table4());

            Table3 t3;
            t1.Table3.Add(t3=new Table3() { Info = 3 });
            t3.Table1.Add(new Table1() { Info = 2 });

            Table6 t6 = new Table6() { Info = 6 };
            t1.Table1To6.Add(new Table1To6() { Info = 6, Table6=t6 });
            db.Table6.Add(t6);

            t1.Table5 = new Table5();

            var t5 = new Table5() { Info = 5 };
            t5.Table1 = new Table1() { Info = 5 };
            db.Table5.Add(t5);

            var t7 = new Table7() { Table7AID = 10, Table7BID = 11 };
            db.Table7.Add(t7);
            t7.Table8 = new Table8() { Info = 8 };
            t7.Table9 = new Table9() { Info = 9 };

            db.SaveChanges();
        }
    }
}
