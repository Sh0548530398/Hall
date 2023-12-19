using Hall.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Services
{
    public interface IPhotoService
    {
        List<Photographer> GetAllList();
        public Photographer GetById(int id);
        public void PostPhotographer(Photographer value);
        public bool PutPhotographer(int id, Photographer value);
        public bool DeleatPhotographer(int id);
    }
}
