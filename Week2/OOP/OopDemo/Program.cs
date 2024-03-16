// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

CreditManager creditManager = new CreditManager();
creditManager.Calculate();





class CreditManager
{
    public void Calculate()
    {
        Console.WriteLine("Calculated");
    }

    public void Save()
    {
        Console.WriteLine("Credit given.");
    }

}
interface ICreditManager
{
    void Calculate();

    void Save();
}

abstract class BaseCreditManager : ICreditManager
{
    public abstract void Calculate();
    public virtual void Save()
    {
        Console.WriteLine("Kaydedildi");
    }
}

class TeacherCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Calculated teacher credit.");
    }

    public override void Save()
    {
        //
        base.Save();
        //
    }



}

class MilitaryCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Calculated military credit.");
    }






    class CustomerManager
    {
        private Customer _customer;
        ICreditManager _creditManager;
        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }
        public void Save()
        {
            Console.WriteLine("Customer Saved.");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted.");
        }

        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Given credit");

        }
    }

    class Customer

    {
        public Customer()
        {
            Console.WriteLine("Customer object initalized");
        }
        public int Id { get; set; }

        public string City { get; set; }

    }

    class Person : Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalIdentity { get; set; }

    }

    class Company : Customer
    {
        public string TaxNumber { get; set; }

    }

