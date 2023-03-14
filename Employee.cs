namespace OOPConcepts.Logic
{
    public abstract class Employee
    {
        public Date? BornDate { get; set; }
        public Date? HireDate { get; set; }
        public int Id { get; set; } 
        public string? FirstName { get; set; } 
        public string? LastName { get; set;}
        public bool IsActive { get; set; }
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t" +
                   $"Hire in............:   {HireDate}";
        }
    }
}
