using Hall.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core
{
    public interface IDataContext
    {
        List<Orders> OrdersList { get; set; }

        List<Photographer> PhotographersList { get; set; }

        List<Cameraman> CameramanList { get; set; }
    }
}
