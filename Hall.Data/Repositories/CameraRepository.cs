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
    public class CameraRepository:ICameraRepository
    {
        private static int i = 0;
        private readonly DataContext _context;
        public CameraRepository(DataContext context)
        {
            _context = context;
        }
        public List<Cameraman> GetAllList()
        {
            return _context.CameramanList.ToList();
        }
        public Cameraman GetById(int id)
        {
            return _context.CameramanList.ToList().Find(c => c.Id == id);
        }
        public void PostCameraman(Cameraman value)
        {
            _context.CameramanList.Add(new Cameraman(i++, value.Name, value.NumOfExperience));
        }
        public bool PutCameraman(int id, Cameraman value)
        {
            var exist = _context.CameramanList.ToList().Find(c => c.Id == id);
            if (exist == null)
            {
                return false;
            }
            exist.Name = value.Name;
            exist.NumOfExperience = value.NumOfExperience;
            return true;
        }
        public bool DeleatCameraman(int id)
        {
            var delete = _context.CameramanList.ToList().Find(c => c.Id == id);
            if (delete == null)
            {
                return false;

            }
            _context.CameramanList.Remove(delete);
            return true;
        }
    }
}
