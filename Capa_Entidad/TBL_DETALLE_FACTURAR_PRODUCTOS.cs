using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class TBL_DETALLE_FACTURAR_PRODUCTOS
    {
        // Campos de la Clase
        private string xID = string.Empty;
        private string xID_PRODUCTO = string.Empty;
        private string xDESC_PRODUCTO = string.Empty;
        private string xID_UM = string.Empty;
        private string xDESC_UM = string.Empty;
        private string xCANTIDAD = string.Empty;
        private string xPRECIO = string.Empty;
        private string xTOTAL = string.Empty;

        // Constructor de la Clase
        public TBL_DETALLE_FACTURAR_PRODUCTOS() { }


        // Propiedades de la Clase
        public string ID
        {
            get { return xID; }
            set { xID = value; }
        }

        public string ID_PRODUCTO
        {
            get { return xID_PRODUCTO; }
            set { xID_PRODUCTO = value; }
        }

        public string DESC_PRODUCTO
        {
            get { return xDESC_PRODUCTO; }
            set { xDESC_PRODUCTO = value; }
        }

        public string ID_UM
        {
            get { return xID_UM; }
            set { xID_UM = value; }
        }

        public string DESC_UM
        {
            get { return xDESC_UM; }
            set { xDESC_UM = value; }
        }

        public string CANTIDAD
        {
            get { return xCANTIDAD; }
            set { xCANTIDAD = value; }
        }

        public string PRECIO
        {
            get { return xPRECIO; }
            set { xPRECIO = value; }
        }

        public string TOTAL
        {
            get { return xTOTAL; }
            set { xTOTAL = value; }
        }
    }
}
