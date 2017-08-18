using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            Program th = new Program();
            th.BannerContent();
        }

        public void BannerContent() 
        {
            MWPEntities ctx = new MWPEntities();
            List<TEST_IMAGE_CONVERT> items = ctx.TEST_IMAGE_CONVERT.ToList();
            foreach (TEST_IMAGE_CONVERT item in items) {

                string path = @"../../images/" + item.TEMP_PATH;
                byte[] imageArray = System.IO.File.ReadAllBytes(path);

                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                TEST_IMAGE_CONVERT selected = ctx.TEST_IMAGE_CONVERT.Single(i => i.ID == item.ID);

                selected.DATA_IMAGE = Encoding.ASCII.GetBytes(base64ImageRepresentation);
                //d = db.PMIS_DEPARTMENT.Single(i => i.DEPT_CODE == this._deptCode);
                ctx.SaveChanges();
            }

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
