namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Add(int id, string firstname, string lastname)
        {
            Console.WriteLine("Method Started");
            Console.WriteLine(@$"{id } - {firstname} - {lastname}");
            Console.WriteLine("Method End");

        }

        // amacımız buradaki metot'a gelen parametreleri tek tek kontrol etmek yerine aspect ile yapmak.
        public virtual void Update(int id, string firstname, string lastname)
        {
           
            Console.WriteLine("Updated");
        }
    }
}
