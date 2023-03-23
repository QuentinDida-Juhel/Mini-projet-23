using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;

namespace bibioBDDPersonnels
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
        public bool ajouterPersonnel(Personnel p)
        {
            try
            {
                dc.Personnels.InsertOnSubmit(p);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
