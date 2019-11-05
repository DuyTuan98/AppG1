using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL
{
    public class Nhom
    {
        public int MaNhom { get; set; }
        public string TenNhom { get; set; }
        public static List<LienLac> ListLienLac { get; set; }

        public static List<Nhom> getListNhom(string pathDataGroup)
        {
            List<Nhom> listNhom = new List<Nhom>();
            string[] rows = File.ReadAllLines(pathDataGroup);
            foreach(string row in rows)
            {
                string[] values = row.Split('|');
                listNhom.Add(new Nhom { 
                    MaNhom = Convert.ToInt32(values[0]),
                    TenNhom = values[1]
                });
            }
            return listNhom;
        }
        

        }

     
        
    
}
