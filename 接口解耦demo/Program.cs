using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口解耦demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var xm = new Xm();
            var user = new UserPhone(xm);
            user.Phone();
        }
    }

    interface IPhone
    {
        void a();
        void b();
        void c();
        void d();
    }

    class UserPhone
    {
        public IPhone _phone;

        public UserPhone(IPhone phone)
        {
            _phone = phone;
        }

        public void Phone()
        {
            _phone.a();
            _phone.b();
            _phone.c();
            _phone.d();

        }
    }

    class LjyPhone:IPhone
    {
        public void a()
        {
            Console.WriteLine("a");
        }

        public void b()
        {
            Console.WriteLine("b");
        }
        public void c()
        {
            Console.WriteLine("c");
        }
        public void d()
        {
            Console.WriteLine("d");
        }
    }

    class Xm : IPhone
    {
        public void a()
        {
            Console.WriteLine("A");
        }

        public void b()
        {
            Console.WriteLine("B");
        }
        public void c()
        {
            Console.WriteLine("C");
        }
        public void d()
        {
            Console.WriteLine("D");
        }
    }
}
