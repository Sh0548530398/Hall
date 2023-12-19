using Hall.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holl.UnitTest
{

    internal class DataContextFake : IDataContext
    {
        public List<Orders> OrdersList { get; set; }

        public List<Photographer> PhotographersList { get; set; }

        public List<Cameraman> CameramanList { get; set; }

        public DataContextFake()
        {
            OrdersList = new List<Orders> {
            new Orders (0,"cohen","wedding",  new DateTime(2023, 01, 01),  500 ),
            new Orders ( 1,"levi", "brith", new DateTime(2023, 01, 01),300 ),
            new Orders (2, "israel", "barmitzva",  new DateTime(2023, 01, 01),  400)};

            PhotographersList = new List<Photographer>
        {
            new Photographer(0,"markovizt", 5),
            new Photographer(1,"yiloz", 4),
            new Photographer(2,"cohen", 10)
        };

            CameramanList = new List<Cameraman>
        {
            new Cameraman(0,"markovizt", 5),
            new Cameraman(1,"yiloz", 4),
            new Cameraman(2,"cohen", 10)
        };
        }
    }    
}
