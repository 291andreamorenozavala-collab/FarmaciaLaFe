using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class TBL_EXISTENCIAS_y_COSTOS
    {
        // Campos de la Clase
        private string xCANT = string.Empty;
        private string xCOSTO = string.Empty;
        private string xTOTAL = string.Empty;
        
        // Constructor de la Clase
        public TBL_EXISTENCIAS_y_COSTOS() { }

        // Propiedades de la Clase
        public string CANT
        {
            get { return xCANT; }
            set { xCANT = value; }
        }

        public string COSTO
        {
            get { return xCOSTO; }
            set { xCOSTO = value; }
        }

        public string TOTAL
        {
            get { return xTOTAL; }
            set { xTOTAL = value; }
        }
        
    }
}
