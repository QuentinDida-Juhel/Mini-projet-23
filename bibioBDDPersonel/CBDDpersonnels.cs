using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;

namespace bibioBDDPersonel
{
    public class CBDDpersonnels
    {
        private BddpersonnelDataContext dc = null;

        public CBDDpersonnels()
        {
            dc = new BddpersonnelDataContext();
        }

        public List<Service> getAllServices()
        {
            try
            {
               return dc.Services.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
