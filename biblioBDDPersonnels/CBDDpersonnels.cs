using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using BddpersonnelContext;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Data.Common;
using System.Windows.Media.Imaging;


namespace bibioBDDPersonnels
{
    public class CBDDpersonnels
    {
        private BddpersonnelDataContext dc = null;
        private object BitmapCacheOption;

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Personnel> getAllPersonnels()
        {
            try
            {
                return dc.Personnels.ToList();
            }
            catch (Exception ex)
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

        public static BitmapImage LoadImage(byte[] imageData)
        {
                try
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    // bitmapImage.CacheOption = BitmapCacheOption;
                    bitmapImage.StreamSource = new MemoryStream(imageData);
                    bitmapImage.EndInit();
                    return bitmapImage;
                }
                catch(Exception ex)
                {
                    throw new Exception("erreur dans conversion image :" + ex.Message);
                }
           
        }
    }
}
