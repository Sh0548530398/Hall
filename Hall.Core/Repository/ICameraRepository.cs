using Hall.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Repository
{
    public interface ICameraRepository
    {
        List<Cameraman> GetAllList();
        public Cameraman GetById(int id);
        public void PostCameraman(Cameraman value);
        public bool PutCameraman(int id, Cameraman value);
        public bool DeleatCameraman(int id);


    }
}
