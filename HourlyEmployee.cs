namespace OOPConcepts.Logic
{
    public class HourlyEmployee : Employee
    {
        private decimal _hourValue;
        private decimal _workingHours;
        public decimal HourValue
        {
            get => _hourValue;
            set => _hourValue = ValidateHourValue(value);
        }

        public decimal WorkingHours
        {
            get => _workingHours;
            set => _workingHours = ValidateWorkingHours(value);
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Working hours......: {WorkingHours,15:n2}\n\t" +
                   $"Hour value.........: {HourValue,15:c2}\n\t" +
                   $"Value to pay.......: {GetValueToPay(),15:c2}";
        }
        public override decimal GetValueToPay()
        {
            return (decimal)WorkingHours * _hourValue * 0.88m;//se coloca la m para castear el numero a decimal, en texto se tiene q poner (decimal)
        }
        private decimal ValidateWorkingHours(decimal value)
        {
            if (value <= 0 || value > 240)
            {
                throw new ArgumentException("The working hour is not valide.");
            }
            return value;
        }

        private decimal ValidateHourValue(decimal value)
        {
            if (value < 30000)
            {
                throw new ArgumentException("The hour value is not valide.");
            }
            return value;
        }
    }
}
