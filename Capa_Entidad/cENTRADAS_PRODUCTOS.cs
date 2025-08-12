using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class cENTRADAS_PRODUCTOS
    {
        // Campos de la Clase
        private string xID = string.Empty;
        private string xFECHA = string.Empty;
        private string xID_PROVEEDOR = string.Empty;
        private string xUSER = string.Empty;
        
        // Constructor de la Clase
        public cENTRADAS_PRODUCTOS() { }


        // Propiedades de la Clase
        public string ID
        {
            get { return xID; }
            set { xID = value; }
        }

        public string FECHA
        {
            get { return xFECHA; }
            set { xFECHA = value; }
        }

        public string ID_PROVEEDOR
        {
            get { return xID_PROVEEDOR; }
            set { xID_PROVEEDOR = value; }
        }
        
        public string USER
        {
            get { return xUSER; }
            set { xUSER = value; }
        }
        
    }
}
