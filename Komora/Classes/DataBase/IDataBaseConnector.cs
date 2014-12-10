﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase

{
    public interface IDataBaseConnector
    {
        bool connect();
        bool disconnect();
    }
}
