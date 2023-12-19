using Hall.Core.Repository;
using Hall.Core.Services;
using Hall.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Service
{
    public class CameraService:ICameraService
    {
        private readonly ICameraRepository _cameraRepository;

        public CameraService(ICameraRepository cameraRepository)
        {
            _cameraRepository = cameraRepository;
        }
        public List<Cameraman> GetAllList()
        {
            return _cameraRepository.GetAllList();
        }
        public Cameraman GetById(int id)
        {
           return _cameraRepository.GetById(id);
           
        }
        public void PostCameraman(Cameraman value)
        {
            _cameraRepository.PostCameraman(value);
        }
        public bool PutCameraman(int id, Cameraman value)
        {
            bool flag = _cameraRepository.PutCameraman(id, value);
            if (flag)
                return true;
            return false;
        }
        public bool DeleatCameraman(int id)
        {
            bool flag = _cameraRepository.DeleatCameraman(id);
            if (flag)
                return true;
            return false;
        }
    }
}
