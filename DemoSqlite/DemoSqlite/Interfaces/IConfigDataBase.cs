using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSqlite.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }

}
