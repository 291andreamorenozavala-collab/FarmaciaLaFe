using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class TBL_AUTENTICACION
    {
        // Campos de la Clase...
        private string xID = string.Empty;
        private string xNOMBRE = string.Empty;
        private string xTIPO = string.Empty;
        

        // Constructor de la Clase
        public TBL_AUTENTICACION() { }

        // Campos de la Clase...
        public string ID
        {
            get { return xID; }
            set { xID = value; }
        }

        public string NOMBRE
        {
            get { return xNOMBRE; }
            set { xNOMBRE = value; }
        }

        public string TIPO
        {
            get { return xTIPO; }
            set { xTIPO = value; }
        }
        

    }
}
