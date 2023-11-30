using System.Xml.Linq;

namespace hall.Entities
{
    public class DataList
    {
       
        public List<Orders> OrdersList { get; set; } = new List<Orders> {
            new Orders (0,"cohen","wedding",  new DateTime(2023, 01, 01),  500 ),
            new Orders ( 1,"levi", "brith", new DateTime(2023, 01, 01),300 ),
            new Orders (2, "israel", "barmitzva",  new DateTime(2023, 01, 01),  400)};

        public List<Photographer> PhotographersList { get; set; } = new List<Photographer>
        {
            new Photographer(0,"markovizt", 5),
            new Photographer(1,"yiloz", 4),
            new Photographer(2,"cohen", 10)
        };
   
        public List<Cameraman> CameramanList { get; set; } = new List<Cameraman>
        {
            new Cameraman(0,"markovizt", 5),
            new Cameraman(1,"yiloz", 4),
            new Cameraman(2,"cohen", 10)
        };
    }
}
