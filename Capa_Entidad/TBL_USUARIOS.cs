using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class TBL_USUARIOS
    {
        // Campos de la Clase
        private string xID = string.Empty;
        private string xNOMBRE = string.Empty;
        private string xUID = string.Empty;
        private string xPWD = string.Empty;
        private string xEST = string.Empty;
        private string xDESC_ROL = string.Empty;
        
        // Constructor de la Clase
        public TBL_USUARIOS() { }

        // Propiedades de la Clase
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

        public string UID
        {
            get { return xUID; }
            set { xUID = value; }
        }

        public string PWD
        {
            get { return xPWD; }
            set { xPWD = value; }
        }

        public string ESTADO
        {
            get { return xEST; }
            set { xEST = value; }
        }
        
        public string DESC_ROL
        {
            get { return xDESC_ROL; }
            set { xDESC_ROL = value; }
        }
        
    }
}
