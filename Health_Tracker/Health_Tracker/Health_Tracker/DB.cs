using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnesFaruk_180201073
{
    public interface DB
    {
        SQLiteConnection GetConnection();
    }
}
