using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnesFaruk_180201073.Database
{
   public class Dynamic
    {
        [PrimaryKey, AutoIncrement]
        public int Person_ID { get; set; }
        public int Index_Water_Db { get; set; }
        public int Index_Sleep_Db { get; set; }
        public int Index_Blood_Db { get; set; }
        public int Index_Blood2_Db { get; set; }
    }
}
