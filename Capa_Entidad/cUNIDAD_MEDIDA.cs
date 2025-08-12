using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class cUNIDAD_MEDIDA
    {
        // Campos de la Clase
        private string xID = string.Empty;
        private string xDESC = string.Empty;
        private string xEST = string.Empty;
        private string xUSER = string.Empty;
        
        // Constructor de la Clase
        public cUNIDAD_MEDIDA() { }

        // Propiedades de la Clase
        public string ID
        {
            get { return xID; }
            set { xID = value; }
        }

        public string DESCRIPCION
        {
            get { return xDESC; }
            set { xDESC = value; }
        }

        public string ESTADO
        {
            get { return xEST; }
            set { xEST = value; }
        }

        public string USER
        {
            get { return xUSER; }
            set { xUSER = value; }
        }
        
    }
}
