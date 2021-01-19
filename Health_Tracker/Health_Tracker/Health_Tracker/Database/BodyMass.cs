using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnesFaruk_180201073.Database
{
   public class BodyMass
    {
        [PrimaryKey, AutoIncrement]
        public int Person_ID { get; set; }
        public int Person_Weight { get; set; }
        public int Person_Height { get; set; }
        public double Body_Mass { get; set; }
        public string Person_Gender { get; set; }
        public string Person_Gender1 { get; set; }
    }
}
