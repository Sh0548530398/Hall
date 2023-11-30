namespace hall.Entities
{
    public class Photographer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfExperience { get; set; }
       

        public Photographer(int id,string name, int numOfExperience)
        {
            Id = id; 
            Name = name;
            NumOfExperience = numOfExperience;

        }
    }
}
