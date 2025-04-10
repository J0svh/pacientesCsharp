using pacientesCsharp.modelo;
using pacientesCsharp.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacientesCsharp.bbdd
{
    class Conexion
    {
        private static readonly string url = "Data Source=CentroSalud.db";

        public static bool Acceder (string user, string pass)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario = @user AND pass = @pass";
            SQLiteConnection conn = new SQLiteConnection (url);
            
            conn.Open ();

            SQLiteCommand command = new SQLiteCommand(consulta, conn);

            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);

            SQLiteDataReader resultados = command.ExecuteReader();
            try
            {
                return resultados.Read();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                resultados.Close();
                conn.Close();
            }
        }

        public static void CargarCOmboCIudades(System.Windows.Forms.ComboBox cb)
        {
            string consulta = "SELECT ciudad FROM ciudades";
            SQLiteConnection conn = new SQLiteConnection(url);

            conn.Open();
            
              // DataTable dt = new DataTable();//

            SQLiteCommand command = new SQLiteCommand(consulta, conn);
            SQLiteDataReader resultados = command.ExecuteReader();

            while (resultados.Read())
            {
                cb.Items.Add(resultados["ciudad"].ToString());
            }
            resultados.Close();
            conn.Close();
        }

        public static bool RegistrarPaciente (Paciente p)
        {
            string consulta = $"INSERT INTO pacientes (nombre, apellidos, direccion, ciudad)"+ "VALUES (@nom, @ape, @dir, @ciu)";

            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();
            try
            {
                SQLiteCommand command = new SQLiteCommand(consulta, conn);
                command.Parameters.AddWithValue("@nom", p.Nombre);
                command.Parameters.AddWithValue("@ape", p.Apellidos);
                command.Parameters.AddWithValue("@dir", p.Direccion);
                command.Parameters.AddWithValue("@ciu", p.Ciudad);

                command.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool RegistrarUsuario(Usuario u)
        {
            string consulta = $"INSERT INTO usuarios (nombrecompleto, usuario, pass) VALUES (?, ?, ?)";

            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();
            try
            {
                SQLiteCommand command = new SQLiteCommand(consulta, conn);
                command.Parameters.AddWithValue("@nom", u.Nombrecompleto);
                command.Parameters.AddWithValue("@ape", u.User);
                command.Parameters.AddWithValue("@dir", u.Pass);
                

                command.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable CargarPacientes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("APELLIDOS");
            dt.Columns.Add("DIRECCION");
            dt.Columns.Add("CIUDAD");
            DataRow dr = dt.NewRow();

            string consulta = "SELECT id, nombre, apellidos, direccion, ciudad FROM pacientes";
            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();
            SQLiteCommand command = new SQLiteCommand(consulta, conn);
            SQLiteDataReader resultados = command.ExecuteReader();

            while (resultados.Read()) {
                dr = dt.NewRow();
                dr["ID"] = resultados.GetInt32(0);
                dr["NOMBRE"] = Encriptado.Desencriptar(resultados.GetString((1)));
                dr["APELLIDOS"] = Encriptado.Desencriptar(resultados.GetString((2)));
                dr["DIRECCION"] = Encriptado.Desencriptar(resultados.GetString((3)));
                dr["CIUDAD"] = Encriptado.Desencriptar(resultados.GetString((4)));
                dt.Rows.Add(dr);

            } resultados.Close();
            conn.Close();

            return dt;
        }

        public static bool CompruebaUsuario (string usuario)
        {
            string consultausuario="SELECT usuario FROM usuarios WHERE usuario=@usu";
            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();

            using (SQLiteCommand command = new SQLiteCommand(consultausuario, conn))
            {
                command.Parameters.AddWithValue("@usu", usuario);
                SQLiteDataReader resultados = command.ExecuteReader();
                if (resultados.HasRows)
                {
                    conn.Close();
                    resultados.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    resultados.Close();
                    return false;

                }
            }
        }

           
    }
}
