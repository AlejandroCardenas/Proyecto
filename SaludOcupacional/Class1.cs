using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional
{
    public class Class1
    {
        MotaDataContext BD = new MotaDataContext();
        private string generarcodigo()
        {

            string res;
            Char c;
            Random rdm = new Random();

            c = Convert.ToChar(rdm.Next(65, 75));//90 es la z
            //codigo de la forma letra+numer0+.+numero
            res = c + rdm.Next(00, 100).ToString() + "." + rdm.Next(00, 100).ToString();

            return res;
        }
        public void save_trabaj(string ftchk, string DNI, string ap1, string ap2, string nom1,
            string nom2, string area, string puesto, DateTime fechNac, int edad, int sex, int estCiv, int peso, double talla)
        {
            bool ok = true;
            string ide = "";
            while (ok)
            {
                ide = generarcodigo();
                var consulta = from a in BD.Trabajador where a.IdTrabajador == ide select a;
                foreach (Trabajador c in consulta)
                    ok = false;
            }
            Trabajador T = new Trabajador();
            T.ApellidoMaterno = ap2; T.ApellidoPaterno = ap1; T.Area = area; T.DNI = DNI; T.Edad = edad;
            T.EstadoCivil = estCiv; T.FechaNacimiento = fechNac; T.Fotocheck = ftchk; T.NombreP = nom1;
            T.NombreS = nom2; T.Peso = peso; T.PuestodeTrabajo = puesto; T.Sexo = sex; T.Talla = talla;
            T.IdTrabajador = ide;
            BD.Trabajador.InsertOnSubmit(T);
            BD.SubmitChanges();
        }

        public void save_examen(string trab, int tipo, DateTime fech, int estado, string odonto, string presArt, string ekg,
            int psico, string esfuerz, int psa, string orina, bool hiv, bool coca, bool marihuana, int sensom, int ergo,
            int ascensoaltitudes, int riesgo, int perfil, string restricc, string observa, int clinica)
        {
            var consulta = from a in BD.Examen select a;
            int id = 0;
            foreach (Examen e in consulta)
                id = e.IdExamen;
            Examen X = new Examen();
            X.IdTrabajador = trab; X.TipoExamen = tipo; X.Fecha = fech; X.Estado = estado; X.Odontologia = odonto; X.Presion_Arterial = presArt; X.EKG = ekg;
            X.Psicosensometrico = psico; X.Esfuerzo = esfuerz; X.PSA = psa; X.Orina = orina; X.HIV = hiv; X.Cocaina = coca; X.Marihuana = marihuana;
            X.Psicosensometrico = sensom; X.Ergonometria = ergo; X.Asceenso_a_grandes_altitudes = ascensoaltitudes; X.Trabajos_de_Riesgo = riesgo;
            X.PERFIL = perfil; X.RESTRICCIONES = restricc; X.OBSERVACIONES = observa; X.CLINICA = clinica;
            BD.Examen.InsertOnSubmit(X); X.IdExamen = id + 1;
            BD.SubmitChanges();
        }

        public void save_clinica(string nombre)
        {
            var consulta = from a in BD.CLINICA select a;
            int id = 0;
            foreach (CLINICA c in consulta)
                id = c.Id + 1;
            CLINICA x = new CLINICA();
            x.Id = id; x.CLINICA1 = nombre;
            BD.CLINICA.InsertOnSubmit(x);
            BD.SubmitChanges();
        }

        public void save_alerta(int exa, int exaref, string detalle, DateTime fecha)
        {
            int id = 0;
            var consulta = from a in BD.TAlertas select a;
            foreach (TAlertas a in consulta)
                id = a.IdAlerta + 1;
            TAlertas x = new TAlertas();
            x.IdAlerta = id; x.Examen = exa; x.ExamenReferencia = exaref;
            x.Detalle = detalle; x.Fecha = fecha;
            BD.TAlertas.InsertOnSubmit(x);
            BD.SubmitChanges();
        }

        /*
        public DataSet ReporteAlerta(DateTime inicio, DateTime fin)
        {
            var propiedades = typeof(reporteFechasentreResult).GetProperties();
            var dt = new DataTable();
            DataSet Tabla = new DataSet();

            IEnumerable<reporteFechasentreResult> res = BD.reporteFechasentre(inicio, fin);
            //foreach(reporteFechasentreResult a in res)


            dt.Columns.AddRange(propiedades.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());

            foreach (reporteFechasentreResult a in res)
                dt.Rows.Add(a);


            Tabla.Tables.Add(dt);

            return Tabla;
        }*/
    }
}
