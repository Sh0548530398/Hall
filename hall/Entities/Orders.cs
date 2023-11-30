using System.Collections;

namespace hall.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }

        public Orders(int id, string name, string descreption, DateTime date, int price)
        {
            Id = id;
            Name = name;
            Descreption = descreption;
            Date = date;
            Price = price;
        }
    }
}
