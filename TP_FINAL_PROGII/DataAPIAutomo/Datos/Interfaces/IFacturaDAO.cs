﻿using DataAPIAutomo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIAutomo.Datos.Interfaces
{
    public interface IFacturaDAO
    {
       public List<Producto> GetAutos();
    }
}
