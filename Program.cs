using System;
namespace Test
{
    public interface IService
    {
        void Print();
    }

    public class Service1 : IService
    {
        public void Print()
        {
            Console.WriteLine("Print Method 1");
        }
    }

    public class Service2 : IService
    {
        public void Print()
        {
            Console.WriteLine("Print Method 2");
        }
    }
    class Class
    {
        private IService _service;
        public IService Service
        {
            set
            {
                this._service = value;
            }
        }
        public void PrintMethod()
        {
            this._service.Print();
        }
    }

    class ClassA
    {
        private IService _service;
        public ClassA(IService service)
        {
            this._service = service;
        }
        public void PrintMethod()
        {
            this._service.Print();
        }
    }

    public interface IAccount
    {
        void PrintDetails();
    }

    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Current Account..");
        }
    }
    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Saving Account..");
        }
    }

    class Account
    {
        public void PrintAccounts(IAccount account)
        {
            account.PrintDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.PrintAccounts(new SavingAccount());

            Account ca = new Account();
            ca.PrintAccounts(new CurrentAccount());
            Service1 s1 = new Service1();
            //passing dependency
            ClassA c1 = new ClassA(s1);
            c1.PrintMethod();
            Service2 s2 = new Service2();
            //passing dependency
            c1 = new ClassA(s2);
            c1.PrintMethod();
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}


