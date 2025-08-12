using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    // Constructor de la Clase
    public class TBL_ENTRADAS_PRODUCTOS
    {
        // Campos de la Clase
        private string xID = string.Empty;
        private string xFECHA = string.Empty;
        private string xID_PROVEEDOR = string.Empty;
        private string xNOMBRE_PROVEEDOR = string.Empty;
        private string xTOTAL = string.Empty;
        private string xANULADO = string.Empty;
        private string xUSER = string.Empty;
        private string xEDIT = string.Empty;

        // Constructor de la Clase
        public TBL_ENTRADAS_PRODUCTOS() { }


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

        public string NOMBRE_PROVEEDOR
        {
            get { return xNOMBRE_PROVEEDOR; }
            set { xNOMBRE_PROVEEDOR = value; }
        }

        public string TOTAL
        {
            get { return xTOTAL; }
            set { xTOTAL = value; }
        }

        public string ANULADO
        {
            get { return xANULADO; }
            set { xANULADO = value; }
        }

        public string USER
        {
            get { return xUSER; }
            set { xUSER = value; }
        }

        public string EDIT
        {
            get { return xEDIT; }
            set { xEDIT = value; }
        }
    }
}
