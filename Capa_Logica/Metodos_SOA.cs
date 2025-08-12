using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Logica
{
    public class Metodos_SOA
    {        
        // Variables de Acceso a Datos
        private static DataSet ds = new DataSet();
        private Capa_Datos.AccesoDatos xMETODOS = new Capa_Datos.AccesoDatos();
        private static string sRetorno = string.Empty, sMensaje_Error = string.Empty;

        // Autenticacion de Usuarios
        public List<TBL_AUTENTICACION> Autenticar_Usuarios_Json(out string xMsg, string xUID, string xPWD)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_AUTENTICACION> oLista = new List<TBL_AUTENTICACION>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.AUTENTICAR_USUARIO", xUID, xPWD);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                                  select new TBL_AUTENTICACION
                                  {
                                      ID = Mis_REG["xID"].ToString(),
                                      NOMBRE = Mis_REG["xNOMBRE"].ToString(),
                                      TIPO = Mis_REG["xROL"].ToString()
                                  }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message; 
            }
            return oLista;
        }

        public List<TBL_USUARIOS> Listar_Usuarios(out string xMsg, string xFiltro)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_USUARIOS> oLista = new List<TBL_USUARIOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_Usuarios", xFiltro);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_USUARIOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  NOMBRE = Mis_REG["xDESC"].ToString(),
                                  UID = Mis_REG["xUID"].ToString(),
                                  PWD = Mis_REG["xPWD"].ToString(),
                                  DESC_ROL = Mis_REG["xROL"].ToString(),
                                  ESTADO = Mis_REG["xEST"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public string Insertar_Actualizar_Usuarios(DataTable xDatos)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {
                // Convirtiendola en un XML...
                string result;
                using (StringWriter sw = new StringWriter())
                {
                    xDatos.WriteXml(sw);
                    result = sw.ToString();
                }


                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.INS_ACT_USUARIOS", "", result, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }

        

        // Unidad de Medidas
        public List<TBL_UNIDAD_MEDIDA> Listar_Unidad_Medida(out string xMsg, string xFiltro)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_UNIDAD_MEDIDA> oLista = new List<TBL_UNIDAD_MEDIDA>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_UNIDAD_MEDIDA", xFiltro);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_UNIDAD_MEDIDA
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  DESCRIPCION = Mis_REG["xDESC"].ToString(),
                                  ESTADO = Mis_REG["xEST"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public string Insertar_Actualizar_Unidad_Medida(DataTable xDatos)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty; 
            
            try
            {                
                // Convirtiendola en un XML...
                string result;
                using (StringWriter sw = new StringWriter())
                {
                    xDatos.WriteXml(sw);
                    result = sw.ToString();
                }


                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.INS_ACT_UNIDAD_MEDIDA", "", result, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }



        // Productos
        public List<TBL_PRODUCTOS> Listar_Productos(out string xMsg, string xFiltro)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_PRODUCTOS> oLista = new List<TBL_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_PRODUCTOS", xFiltro);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  DESCRIPCION = Mis_REG["xDESC"].ToString(),
                                  ESTADO = Mis_REG["xEST"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public List<TBL_EXISTENCIAS_y_COSTOS> Listar_Existencias_y_Costos_Productos(out string xMsg, string xID_PROD, string xID_UM)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_EXISTENCIAS_y_COSTOS> oLista = new List<TBL_EXISTENCIAS_y_COSTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_Existencias_y_Costos_PRODUCTOS", xID_PROD, xID_UM);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_EXISTENCIAS_y_COSTOS
                              {
                                  CANT = Mis_REG["xCANT"].ToString(),
                                  COSTO = Mis_REG["xCOSTO"].ToString(),
                                  TOTAL = Mis_REG["xTOTAL"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public string Insertar_Actualizar_Productos(DataTable xDatos)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {
                // Convirtiendola en un XML...
                string result;
                using (StringWriter sw = new StringWriter())
                {
                    xDatos.WriteXml(sw);
                    result = sw.ToString();
                }


                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.INS_ACT_PRODUCTOS", "", result, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }



        // Clientes
        public List<TBL_CLIENTES> Listar_Clientes(out string xMsg, string xFiltro)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_CLIENTES> oLista = new List<TBL_CLIENTES>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_CLIENTES", xFiltro);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_CLIENTES
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  DESCRIPCION = Mis_REG["xDESC"].ToString(),
                                  NEGOCIO = Mis_REG["xNegocio"].ToString(),
                                  TELEFONOS = Mis_REG["xTEL"].ToString(),
                                  DIRECCION = Mis_REG["xDIR"].ToString(),
                                  TIPO = Mis_REG["xTIPO"].ToString(),
                                  ESTADO = Mis_REG["xEST"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public string Insertar_Actualizar_Clientes(DataTable xDatos)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {
                // Convirtiendola en un XML...
                string result;
                using (StringWriter sw = new StringWriter())
                {
                    xDatos.WriteXml(sw);
                    result = sw.ToString();
                }


                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.INS_ACT_CLIENTES", "", result, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }



        // Proveedores
        public List<TBL_PROVEEDORES> Listar_Proveedores(out string xMsg, string xFiltro)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_PROVEEDORES> oLista = new List<TBL_PROVEEDORES>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_PROVEEDORES", xFiltro);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_PROVEEDORES
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  DESCRIPCION = Mis_REG["xDESC"].ToString(),
                                  TELEFONOS = Mis_REG["xTEL"].ToString(),
                                  DIRECCION = Mis_REG["xDIR"].ToString(),
                                  ESTADO = Mis_REG["xEST"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public string Insertar_Actualizar_Proveedores(DataTable xDatos)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {
                // Convirtiendola en un XML...
                string result;
                using (StringWriter sw = new StringWriter())
                {
                    xDatos.WriteXml(sw);
                    result = sw.ToString();
                }


                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.INS_ACT_PROVEEDORES", "", result, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }




        // Entradas de Productos
        public List<TBL_ENTRADAS_PRODUCTOS> Listar_ENC_Entradas_Productos(out string xMsg, string xFiltro, string xDesde, string xHasta)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_ENTRADAS_PRODUCTOS> oLista = new List<TBL_ENTRADAS_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_ENC_ENTRADAS_PRODUCTOS", xFiltro, xDesde, xHasta);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_ENTRADAS_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  FECHA = Mis_REG["xFECHA"].ToString(),
                                  ID_PROVEEDOR = Mis_REG["xID_PROVEEDOR"].ToString(),
                                  NOMBRE_PROVEEDOR = Mis_REG["xNOMBRE_PROVEEDOR"].ToString(),
                                  TOTAL = Mis_REG["xTOTAL"].ToString(),
                                  ANULADO = Mis_REG["xANUL"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public List<TBL_DETALLE_ENTRADAS_PRODUCTOS> Listar_DET_Entradas_Productos(out string xMsg, string xID)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_DETALLE_ENTRADAS_PRODUCTOS> oLista = new List<TBL_DETALLE_ENTRADAS_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_DET_ENTRADAS_PRODUCTOS", xID);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_DETALLE_ENTRADAS_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  ID_PRODUCTO = Mis_REG["xID_PRODUCTO"].ToString(),
                                  DESC_PRODUCTO = Mis_REG["xDESC_PRODUCTO"].ToString(),
                                  ID_UM = Mis_REG["xID_UM"].ToString(),
                                  DESC_UM = Mis_REG["xDESC_UM"].ToString(),
                                  CANTIDAD = Mis_REG["xCANTIDAD"].ToString(),
                                  PRECIO = Mis_REG["xPRECIO"].ToString(),
                                  TOTAL = Mis_REG["xTOTAL"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public string Insertar_Entradas_Productos(DataTable xENC, DataTable xDET)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {
                // Convirtiendola en un XML...
                string result_01 = string.Empty, result_02 = string.Empty;
                using (StringWriter sw_01 = new StringWriter())
                {
                    xENC.WriteXml(sw_01);
                    result_01 = sw_01.ToString();
                }

                using (StringWriter sw_02 = new StringWriter())
                {
                    xDET.WriteXml(sw_02);
                    result_02 = sw_02.ToString();
                }


                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.INS_ENTRADAS_PRODUCTOS", "", result_01, result_02, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }

        public string Anular_Entradas_Productos(string xID)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {                
                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.ANULAR_ENTRADAS_PRODUCTOS", "", xID, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }

        public List<TBL_ENTRADAS_PRODUCTOS> rpt_Listar_ENC_Entradas_Productos(out string xMsg, string xID)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_ENTRADAS_PRODUCTOS> oLista = new List<TBL_ENTRADAS_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.rpt_Listar_ENC_ENTRADAS_PRODUCTOS", xID);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_ENTRADAS_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  FECHA = Mis_REG["xFECHA"].ToString(),
                                  ID_PROVEEDOR = Mis_REG["xID_PROVEEDOR"].ToString(),
                                  NOMBRE_PROVEEDOR = Mis_REG["xNOMBRE_PROVEEDOR"].ToString(),
                                  TOTAL = Mis_REG["xTOTAL"].ToString(),
                                  ANULADO = Mis_REG["xANUL"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public List<TBL_DETALLE_ENTRADAS_PRODUCTOS> rpt_Listar_DET_Entradas_Productos(out string xMsg, string xID)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_DETALLE_ENTRADAS_PRODUCTOS> oLista = new List<TBL_DETALLE_ENTRADAS_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.rpt_Listar_DET_ENTRADAS_PRODUCTOS", xID);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_DETALLE_ENTRADAS_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  ID_PRODUCTO = Mis_REG["xID_PRODUCTO"].ToString(),
                                  DESC_PRODUCTO = Mis_REG["xDESC_PRODUCTO"].ToString(),
                                  ID_UM = string.Empty,
                                  DESC_UM = Mis_REG["xDESC_UM"].ToString(),
                                  CANTIDAD = Mis_REG["xCANTIDAD"].ToString(),
                                  PRECIO = Mis_REG["xPRECIO"].ToString(),
                                  TOTAL = Mis_REG["xTOTAL"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }



        // Facturacion de Productos
        public List<TBL_FACTURAR_PRODUCTOS> Listar_ENC_Facturar_Productos(out string xMsg, string xFiltro, string xDesde, string xHasta)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_FACTURAR_PRODUCTOS> oLista = new List<TBL_FACTURAR_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_ENC_FACTURAR_PRODUCTOS", xFiltro, xDesde, xHasta);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_FACTURAR_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  FECHA = Mis_REG["xFECHA"].ToString(),
                                  ID_CLIENTE = Mis_REG["xID_CLIENTE"].ToString(),
                                  NOMBRE_CLIENTE = Mis_REG["xNOMBRE_CLIENTE"].ToString(),
                                  TIPO_CLIENTE = Mis_REG["xTIPO_CLIENTE"].ToString(),
                                  SUBTOTAL_01 = Mis_REG["xSubTotal_01"].ToString(),
                                  PORC_DESCUENTO = Mis_REG["xPORC_Descuento"].ToString(),
                                  VAL_DESCUENTO = Mis_REG["xVal_Descuento"].ToString(),
                                  SUBTOTAL_02 = Mis_REG["xSubTotal_02"].ToString(),
                                  IVA = Mis_REG["xIVA"].ToString(),
                                  NETO = Mis_REG["xNETO"].ToString(),
                                  ANULADO = Mis_REG["xANUL"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public List<TBL_DETALLE_FACTURAR_PRODUCTOS> Listar_DET_Facturar_Productos(out string xMsg, string xID)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_DETALLE_FACTURAR_PRODUCTOS> oLista = new List<TBL_DETALLE_FACTURAR_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.Listar_DET_FACTURAR_PRODUCTOS", xID);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_DETALLE_FACTURAR_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  ID_PRODUCTO = Mis_REG["xID_PRODUCTO"].ToString(),
                                  DESC_PRODUCTO = Mis_REG["xDESC_PRODUCTO"].ToString(),
                                  ID_UM = Mis_REG["xID_UM"].ToString(),
                                  DESC_UM = Mis_REG["xDESC_UM"].ToString(),
                                  CANTIDAD = Mis_REG["xCANTIDAD"].ToString(),
                                  PRECIO = Mis_REG["xPRECIO"].ToString(),
                                  TOTAL = Mis_REG["xTOTAL"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public string Insertar_Facturar_Productos(DataTable xENC, DataTable xDET)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {
                // Convirtiendola en un XML...
                string result_01 = string.Empty, result_02 = string.Empty;
                using (StringWriter sw_01 = new StringWriter())
                {
                    xENC.WriteXml(sw_01);
                    result_01 = sw_01.ToString();
                }

                using (StringWriter sw_02 = new StringWriter())
                {
                    xDET.WriteXml(sw_02);
                    result_02 = sw_02.ToString();
                }


                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.INS_FACTURAR_PRODUCTOS", "", result_01, result_02, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }

        public string Anular_Facturar_Productos(string xID)
        {
            // Verificando llamada del Procedimiento...
            sMensaje_Error = string.Empty;

            try
            {
                sRetorno = xMETODOS.Ejecutar(out sMensaje_Error, "dbo.ANULAR_FACTURAR_PRODUCTOS", "", xID, "@xMSG");

                if (sMensaje_Error.Length > 0)
                {
                    long number1 = 0;
                    bool canConvert = long.TryParse(sMensaje_Error, out number1);
                    if (canConvert == false)
                    { sMensaje_Error = " " + sMensaje_Error; }
                    else { sMensaje_Error = ""; }
                }
            }
            catch (Exception e)
            {
                sMensaje_Error = "0 - " + e.Message;
            }

            return sMensaje_Error;
        }

        public List<TBL_FACTURAR_PRODUCTOS> rpt_Listar_ENC_Facturar_Productos(out string xMsg, string xID)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_FACTURAR_PRODUCTOS> oLista = new List<TBL_FACTURAR_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.rpt_Listar_ENC_FACTURAR_PRODUCTOS", xID);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_FACTURAR_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  FECHA = Mis_REG["xFECHA"].ToString(),
                                  ID_CLIENTE = Mis_REG["xID_CLIENTE"].ToString(),
                                  NOMBRE_CLIENTE = Mis_REG["xNOMBRE_CLIENTE"].ToString(),
                                  TIPO_CLIENTE = Mis_REG["xTIPO_CLIENTE"].ToString(),
                                  SUBTOTAL_01 = Mis_REG["xSubTotal_01"].ToString(),
                                  PORC_DESCUENTO = Mis_REG["xPORC_Descuento"].ToString(),
                                  VAL_DESCUENTO = Mis_REG["xVal_Descuento"].ToString(),
                                  SUBTOTAL_02 = Mis_REG["xSubTotal_02"].ToString(),
                                  IVA = Mis_REG["xIVA"].ToString(),
                                  NETO = Mis_REG["xNETO"].ToString(),
                                  ANULADO = Mis_REG["xANUL"].ToString(),
                                  USER = Mis_REG["xUSER"].ToString(),
                                  EDIT = Mis_REG["xEDIT"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

        public List<TBL_DETALLE_FACTURAR_PRODUCTOS> rpt_Listar_DET_Facturar_Productos(out string xMsg, string xID)
        {
            // Verificando llamada del Procedimiento...
            xMsg = string.Empty; List<TBL_DETALLE_FACTURAR_PRODUCTOS> oLista = new List<TBL_DETALLE_FACTURAR_PRODUCTOS>();

            try
            {
                ds = xMETODOS.TraerDataSet(out xMsg, "dbo.rpt_Listar_DET_FACTURAR_PRODUCTOS", xID);

                if (xMsg.Length > 0)
                { return oLista; }

                if (ds == null)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables.Count == 0)
                { xMsg = "PETICION DE INFORMACION NULA..."; return oLista; }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    oLista = (from Mis_REG in ds.Tables[0].AsEnumerable()
                              select new TBL_DETALLE_FACTURAR_PRODUCTOS
                              {
                                  ID = Mis_REG["xID"].ToString(),
                                  ID_PRODUCTO = Mis_REG["xID_PRODUCTO"].ToString(),
                                  DESC_PRODUCTO = Mis_REG["xDESC_PRODUCTO"].ToString(),
                                  ID_UM = string.Empty,
                                  DESC_UM = Mis_REG["xDESC_UM"].ToString(),
                                  CANTIDAD = Mis_REG["xCANTIDAD"].ToString(),
                                  PRECIO = Mis_REG["xPRECIO"].ToString(),
                                  TOTAL = Mis_REG["xTOTAL"].ToString()
                              }).ToList();

                }
            }
            catch (Exception e)
            {
                xMsg = "0 - " + e.Message;
            }
            return oLista;
        }

    }
}
