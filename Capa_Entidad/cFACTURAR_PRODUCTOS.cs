using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class cFACTURAR_PRODUCTOS
    {
        // Campos de la Clase
        private string xID = string.Empty;
        private string xFECHA = string.Empty;
        private string xID_CLIENTE = string.Empty;
        private string xPORC_DESCUENTO = string.Empty;
        private string xUSER = string.Empty;

        // Constructor de la Clase
        public cFACTURAR_PRODUCTOS() { }


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

        public string ID_CLIENTE
        {
            get { return xID_CLIENTE; }
            set { xID_CLIENTE = value; }
        }

        public string PORC_DESCUENTO
        {
            get { return xPORC_DESCUENTO; }
            set { xPORC_DESCUENTO = value; }
        }

        public string USER
        {
            get { return xUSER; }
            set { xUSER = value; }
        }
    }
}
