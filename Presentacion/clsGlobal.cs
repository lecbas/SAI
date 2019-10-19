using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Presentacion
{
    class clsGlobal
    {
        
        #region CONSTANTES MODULOS
        /*-------------------------------------------------
         CONSTANTES DE MODULOS
         --------------------------------------------------*/
        //TABLA MAESTROS-----------------------------------
        public const string mLOCALIDADES = "M101";
        public const string mPROVINCIAS = "M102";
        public const string mAREAS = "M103";
        public const string mSECTORES = "M104";
        public const string mCUENTAS = "M105";
        public const string mSUBCUENTAS = "M106";
        public const string mTIPOS_GASTOS = "M107";
        public const string mSUBTIPOS_GASTOS = "M108";
        public const string mTIPO_MONEDAS = "M109";
        public const string mCUENTASBANCARIAS = "M110";
        public const string mINTERES = "M111";
        public const string mBANCOS = "M112";
        public const string mTARJETAS = "M113";
        public const string mCOTIZACIONES = "M114";
        //PERSONAS------------------------------------------
        public const string mCLIENTES = "M201";
        public const string mCLIENTES_TRABAJOS = "M202";
        public const string mPROVEEDORES = "M203";
        //SEGURIDAD-----------------------------------------
        public const string mUSUARIOS = "M301";
        public const string mUSUARIOS_PERMISOS = "M302";
        public const string mUSUARIOS_SUBCUENTAS = "M303";
        public const string mREGISTRO_OPERACIONES = "M304";
        //INGRESOS------------------------------------------
        public const string mINGRESOS_FACTURAS = "M401";
        public const string mINGRESOS_RECIBOS = "M402";
        public const string mINGRESOS_NOTASCREDITO = "M403";
        public const string mINGRESOS_NOTASDEBITO = "M404";
        public const string mINGRESOS_COMPROBANTES = "M405";
        public const string mDEBITOS_MANUAL = "M406";
        //EGRESOS-------------------------------------------
        public const string mEGRESOS_FACTURAS = "M501";
        public const string mEGRESOS_ORDENPAGO = "M502";
        public const string mEGRESOS_NOTASDEBITO = "M503";
        public const string mEGRESOS_COMPROBANTES = "M504";
        public const string mEGRESOS_VALES = "M505";
        //LISTADOS------------------------------------------
        public const string mCAJA_DIARIA = "M601";
        public const string mCAJA_CHICA = "M602";
        public const string mESTADO_CUENTAS_ALU = "M603";
        public const string mESTADO_ASCSC = "M604";
        public const string mGASTOS_ASCSC = "M605";
        public const string mLISTA_PERSONAS = "M606";
        public const string mLISTA_SUBCUENTAS = "M607";
        public const string mLISTA_COMP_RETE_NCRE = "M608";
        public const string mESTADO_ASCSC_BID = "M609";
        public const string mESTADO_CUENTAS_CLI = "M610";
        public const string mESTADO_CUENTAS_PRO = "M611";
        //GESTION FINANCIERA--------------------------------
        public const string mMOVIMIENTOS = "M701";
        //PAGO FACIL----------------------------------------
        public const string mPF_COMPROBANTES = "M801";
        public const string mPF_FACTURAS = "M802";
        public const string mPF_ARCHIVO_PAGOS = "M803";
        public const string mPF_LISTADOS = "M804";
        //CONSTANTES PARA EL REGISTRO DE OPERACIONES
        public const string accALTA = "ALTA";
        public const string accBAJA = "BAJA";
        public const string accMODIFICAR = "MODIFICAR";
        public const string accLECTURA = "LECTURA";

        #endregion

        #region VARIABLES Y PROPIEDADES

        public static frmPrincipal Instancia;

        public static List<eUsuariosModulos> lstUserPermisos;

        public static List<eUsuariosInscripcion> lstUserInscripciones;

        public static List<eUsuariosCarreras> lstUserCarreras;

        public static eUsuariosVista User;

        #endregion
    }
}
