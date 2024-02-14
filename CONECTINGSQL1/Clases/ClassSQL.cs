using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CONECTINGSQL1.Clases
{
    class Cconexion

    {
        SqlConnection conex = new SqlConnection();
        static string servidor = "" ;
        static string bd = "";
        static string usuario ="";
        static string password = "";
        static string puerto = "";

        string CadenaConexion = "Data source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info = true";

    public SqlConnection establecerConexion(){
          try{
                conex.ConnectionString = CadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente a la base de datos");
            
         }
          catch (SqlException e) {
                MessageBox.Show("No se logro conectar a la base datos"+ e.ToString());
            
         }



            return conex;
        }



    }
}
