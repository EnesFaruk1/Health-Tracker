using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnesFaruk_180201073.Database
{
   public class Person
    {
       [PrimaryKey, AutoIncrement]
       public int Person_ID { get; set; }
       public string Person_Fname { get; set; }
       public string Person_Lname { get; set; }
       public int Person_Age { get; set; }
    }
}
