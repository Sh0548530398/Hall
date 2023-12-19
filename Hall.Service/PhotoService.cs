using Hall.Core.Entities;
using Hall.Core.Repository;
using Hall.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Service
{
    public class PhotoService:IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;

        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public List<Photographer> GetAllList()
        {
            return _photoRepository.GetAllList();
        }
        public Photographer GetById(int id)
        {
            return _photoRepository.GetById(id);

        }
        public void PostPhotographer(Photographer value)
        {
            _photoRepository.PostPhotographer(value);
        }
        public bool PutPhotographer(int id, Photographer value)
        {
            bool flag = _photoRepository.PutPhotographer(id, value);
            if (flag)
                return true;
            return false;
        }
        public bool DeleatPhotographer(int id)
        {
            bool flag = _photoRepository.DeleatPhotographer(id);
            if (flag)
                return true;
            return false;
        }
    }
}
