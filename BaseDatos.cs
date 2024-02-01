using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    internal class BaseDatos
    {
        public OleDbConnection Conexion;
        public OleDbCommand Comando; //para poder ejecutar comandos
        public OleDbDataReader Lectura; //da alta la informacion que se manda





        //-----------------------------------------------

        public int Conecta()
        {
            string ruta = Directory.GetCurrentDirectory();
            int error = 0;
            string SQL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + "\\DB_Cajero.mdb";
            try
            {
                error = 0;
                Conexion = new OleDbConnection(SQL);
                Conexion.Open();
            }
            catch
            {
                //MessageBox.Show("error al conectar base de datos");
                error = -1;
            }
            return error;
        }


        //-----------------------------------------------











        //ref para que me ponga los datos automaticamente de la base de datos
        // ref = referencia regresara un valor conforme a una variable nueva creada




        // -----------------------------------CREDENCIALES-------------------------------


        public bool VerificarNumeroCuenta(string NumeroCuenta)
        {
            string SQL = "Select Nombre, Saldo from Cliente where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0)
            {
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.Parameters.AddWithValue("@NumeroCuenta", NumeroCuenta);
                Lectura = Comando.ExecuteReader();

                if (Lectura.Read())
                {
                    // Las credenciales son válidas
                    return true;
                }

                Lectura.Close();
            }
            else
            {
                MessageBox.Show("No se pudo conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return false;
        }


        //-----------------------------------------------






        // -----------------------------------CREDENCIALES-------------------------------




        public bool VerificarNIP(string NumeroCuenta, string NIP, ref string Nombre, ref double Saldo)
        {
            string SQL = "select Nombre, Saldo from Cliente where NumeroCuenta = '" + NumeroCuenta + "' and NIP = '" + NIP + "'";

            if (Conecta() == 0)
            {
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.Parameters.AddWithValue("@NIP", NIP);
                Comando.Parameters.AddWithValue("@NumeroCuenta", NumeroCuenta);
                Lectura = Comando.ExecuteReader();

                if (Lectura.Read())
                {
                    // Las credenciales son válidas

                    //REGRESA POR PARAMETRO LOS VALORES DE NOMBRE Y SALDO
                    Nombre = Lectura.GetValue(0).ToString(); //REF - Valor referenciado = Para recoger la informacion de la base datos
                    Saldo = Convert.ToDouble(Lectura.GetValue(1).ToString());  //REF - valor referenciado = Para recoger la informacion de la base datos 

                    return true;
                }

                Lectura.Close();
            }
            else
            {
                MessageBox.Show("No se pudo conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return false;
        }


        //-----------------------------------------------

        // -----------------------------------SALDO-------------------------------





        public bool SaldoCliente(string NumeroCuenta, ref double Saldo)
        {
            string SQL = "Select Saldo from Cliente where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0)
            {
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.Parameters.AddWithValue("@NumeroCuenta", NumeroCuenta);
                Lectura = Comando.ExecuteReader();

                if (Lectura.Read())
                {
                    // Las credenciales son válidas

                    //REGRESA POR PARAMETRO LOS VALORES DE SALDO
                    Saldo = Convert.ToDouble(Lectura.GetValue(0).ToString());  //REF - valor referenciado = Para recoger la informacion de la base datos 

                    return true;
                }

                Lectura.Close();
            }
            else
            {
                MessageBox.Show("No se pudo conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return false;
        }



        //-----------------------------------------------










        public int Deposito500Pesos(ref int Contador, ref double SaldoActual, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + SaldoActual + "' + 500 where NumeroCuenta = '"+ NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }









        public int Deposito200Pesos(ref int Contador, ref double Saldo, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + Saldo + "' + 200 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }







        public int Deposito100Pesos(ref int Contador, ref double Saldo, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + Saldo + "' + 100 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }






        public int Deposito50Pesos(ref int Contador, ref double Saldo, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + Saldo + "' + 50 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }








        public int Deposito20Pesos(ref int Contador, ref double Saldo, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + Saldo + "' + 20 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }







        //--------------------------------------------------------------------------------



        public int Baja(ref int Contador, string Nombre)
        {
            int contador = 0;
            string SQL = " delete from ContactosTelefonicos where Nombre = '" + Nombre + "'";
            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }




        //---------------------------------------------------------------------------
 

        public int Retira500Pesos(ref int Contador, ref double SaldoActual, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + SaldoActual + "' - 500 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }







        public int Retira1000Pesos(ref int Contador, ref double SaldoActual, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + SaldoActual + "' - 1000 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }



        public int Retira50Pesos(ref int Contador, ref double SaldoActual, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + SaldoActual + "' - 50 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }





        public int Retira20Pesos(ref int Contador, ref double SaldoActual, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + SaldoActual + "' - 20 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }




        public int Retira200Pesos(ref int Contador, ref double SaldoActual, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + SaldoActual + "' - 200 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }



        public int Retira100Pesos(ref int Contador, ref double SaldoActual, string NumeroCuenta)
        {
            int contador = 0;
            string SQL = " update Cliente set Saldo = '" + SaldoActual + "' - 100 where NumeroCuenta = '" + NumeroCuenta + "'";

            if (Conecta() == 0) //si no hubo ningun problema en la conexion entonces... hay cero errores
            {
                contador++; // contador = 1
                Comando = new OleDbCommand(SQL, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }

            else
            {
                contador--; //contador = 0

            }

            return contador; // regresa el contador de altas?
        }










    }










}
