using Hall.Core;
using Hall.Core.Entities;
using Hall.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Data.Repositories
{
    public class PhotoRepository:IPhotoRepository
    {
        private static int i = 0;

        private readonly DataContext _context;
        public PhotoRepository(DataContext context)
        {
            _context = context;
        }
        public List<Photographer> GetAllList()
        {
            return _context.PhotographersList.ToList();
        }
        public Photographer GetById(int id)
        {
            return _context.PhotographersList.ToList().Find(c => c.Id == id);
        }
        public void PostPhotographer(Photographer value)
        {
            _context.PhotographersList.Add(new Photographer(i++, value.Name, value.NumOfExperience));
        }
        public bool PutPhotographer(int id, Photographer value)
        {
            var exist = _context.PhotographersList.ToList().Find(c => c.Id == id);
            if (exist == null)
            {
                return false;
            }
            exist.Name = value.Name;
            exist.NumOfExperience = value.NumOfExperience;
            return true;
        }
        public bool DeleatPhotographer(int id)
        {
            var delete = _context.PhotographersList.ToList().Find(c => c.Id == id);
            if (delete == null)
            {
                return false;
            }
            _context.PhotographersList.Remove(delete);
            return true;
        }
    }
}
