using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class User
    {
        CD_Datos CD_Datos = new CD_Datos();
        public bool LoginUser(string Usuario, string contraseña)
        {
            return CD_Datos.Login(Usuario, contraseña);
        }
    }
}
