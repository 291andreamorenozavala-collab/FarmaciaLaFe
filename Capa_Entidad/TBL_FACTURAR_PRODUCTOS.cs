using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class TBL_FACTURAR_PRODUCTOS
    {
        // Campos de la Clase
        private string xID = string.Empty;
        private string xFECHA = string.Empty;
        private string xID_CLIENTE = string.Empty;
        private string xNOMBRE_CLIENTE = string.Empty;
        private string xTIPO_CLIENTE = string.Empty;
        private string xSUBTOTAL_01 = string.Empty;
        private string xPORC_DESCUENTO = string.Empty;
        private string xVAL_DESCUENTO = string.Empty;
        private string xSUBTOTAL_02 = string.Empty;
        private string xIVA = string.Empty;
        private string xNETO = string.Empty;
        private string xANULADO = string.Empty;
        private string xUSER = string.Empty;
        private string xEDIT = string.Empty;

        // Constructor de la Clase
        public TBL_FACTURAR_PRODUCTOS() { }


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

        public string NOMBRE_CLIENTE
        {
            get { return xNOMBRE_CLIENTE; }
            set { xNOMBRE_CLIENTE = value; }
        }

        public string TIPO_CLIENTE
        {
            get { return xTIPO_CLIENTE; }
            set { xTIPO_CLIENTE = value; }
        }

        public string SUBTOTAL_01
        {
            get { return xSUBTOTAL_01; }
            set { xSUBTOTAL_01 = value; }
        }

        public string PORC_DESCUENTO
        {
            get { return xPORC_DESCUENTO; }
            set { xPORC_DESCUENTO = value; }
        }

        public string VAL_DESCUENTO
        {
            get { return xVAL_DESCUENTO; }
            set { xVAL_DESCUENTO = value; }
        }

        public string SUBTOTAL_02
        {
            get { return xSUBTOTAL_02; }
            set { xSUBTOTAL_02 = value; }
        }

        public string IVA
        {
            get { return xIVA; }
            set { xIVA = value; }
        }

        public string NETO
        {
            get { return xNETO; }
            set { xNETO = value; }
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
