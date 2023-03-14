
namespace OOPConcepts.Logic
{
    public class SalaryEmployee : Employee
    {
        private decimal _salary;
        public decimal Salary 
        {
            get => _salary;
            set => _salary = ValidateSalary(value); 
        }

        public override decimal GetValueToPay()
        {
            return Salary * (decimal)0.88;//(multiplica una una decimal x un double, por eso se le coloca la m al 0.88 o se castea (decimal) 
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Salary.............: {Salary,15:c2}\n\t" +
                   $"Value to pay.......: {GetValueToPay(),15:c2}";
        }
        private decimal ValidateSalary(decimal value)
        {
            if (value < 1160000)
            {
                throw new ArgumentException("The salary is less than minimun.");
            }
            return value;
        }
    }
}
