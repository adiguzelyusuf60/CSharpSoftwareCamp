using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer realCostumer = new RealCustomer();
            realCostumer.ID = 1;
            realCostumer.CustomerID = "12345";
            realCostumer.FirstName = "Yusuf";
            realCostumer.LastName = "Aıgüzel";
            realCostumer.NationallyID = "12345678910";

            CompanyCustomer companyCustomer = new CompanyCustomer();
            companyCustomer.ID = 2;
            companyCustomer.ComapnyName = "GOKTURK GAMES";
            companyCustomer.CustomerID = "54321";
            companyCustomer.TaxID = "123456780";

            Customer customer = new RealCustomer();
            Customer customer1 = new CompanyCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(realCostumer);
            customerManager.Add(companyCustomer);

        }
    }
}
