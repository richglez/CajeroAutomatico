using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {

        //variables
        public int Bandera = 0;
        public string NombreCliente;
        public string PasswdCliente;
        public double SaldoCliente;




        //VARIABLES GLOBALES
        string NoCta;




        public Form1()
        {
            InitializeComponent();

            
        }






























        public void FormatoMoneda()
        {
            if (txtRanuraDepositosMonto.Text == string.Empty) 
            {
                return; //para evitar errores
            }

            else
            {
                //contiene datos
                decimal monto;
                monto = Convert.ToDecimal(txtRanuraDepositosMonto.Text);
                txtRanuraDepositosMonto.Text = monto.ToString("N2"); //representa la cantidad de decimales que va a tomar la caja
            }
        }





        public void FormatoMoneda2()
        {
            if (txtRanuraRetiros.Text == string.Empty)
            {
                return; //para evitar errores
            }

            else
            {
                //contiene datos
                decimal monto;
                monto = Convert.ToDecimal(txtRanuraRetiros.Text);
                txtRanuraRetiros.Text = monto.ToString("N2"); //representa la cantidad de decimales que va a tomar la caja
            }
        }











        public void ConsultarSaldo()
        {
            double saldo = 0; //no se sabe cual es el saldo actual
            string numCuenta = Convert.ToString(txtNoCta.Text) ; //se sabe cual el numero de cuenta

            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.SaldoCliente(numCuenta, ref saldo) == true)
            {
                //LLENAR SALDO ACTUAL
                //txtNoCta.Text = numCuenta; //esto sirve para llenar textboxes
                txt_info_saldo2.Text = Convert.ToString(saldo); //copia de la base de datos () y pega al textbox
            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }






        public void Darcambios500()
        {
            //variables
            int cantCambios = 0; //refenciado a esto                                 //SaldoCliente puede modificar su valor. 
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text) ; //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);
            

            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Deposito500Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se han retiro $500.00 Con Exito!", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual) ;
                txtRanuraDepositosMonto.Clear();

            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }





        }










        public void Darcambios200()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Deposito200Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se han retiro $200.00 Con Exito!", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }









        }



        public void Darcambios100()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text); //parametro


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Deposito100Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se han retiro $100.00 Con Exito!", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }





        }





        public void Darcambios50()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Deposito50Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se han retiro $50.00 Con Exito!", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }





        }






        public void Darcambios20()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            int CantidadExistencias = 0;
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Deposito20Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se han retiro $20.00 Con Exito!", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }





        }









        public void DarRetiro1000()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            int CantidadExistencias = 0;                                    //SaldoCliente puede modificar su valor. 
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Retira1000Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se han retiro $1,000.00 Con Exito!", "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
                lblRetiros.Location = new Point(98, 55);
                lblRetiros.Text = "Transaccion Realizada con Exito!";
                txtRanuraRetiros.Text = "$ 1000";

                //botones
                btnRetira200.Visible = false;
                btnRetira1000.Visible = false;
                btnRetira20.Visible = false;
                btnRetira50.Visible = false;
                btnRetira100.Visible = false;
                btnRetira500.Visible = false;

            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }



        }












        public void DarRetiro500()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            int CantidadExistencias = 0;                                    //SaldoCliente puede modificar su valor. 
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Retira500Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se actualizaron los datos con exito!", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
                lblRetiros.Location = new Point(98, 55);
                lblRetiros.Text = "Transaccion Realizada con Exito!";
                txtRanuraRetiros.Text = "$ 500";

                //botones
                btnRetira200.Visible = false;
                btnRetira1000.Visible = false;
                btnRetira20.Visible = false;
                btnRetira50.Visible = false;
                btnRetira100.Visible = false;
                btnRetira500.Visible = false;

            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }





        }



















        public void DarRetiro20()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            int CantidadExistencias = 0;                                    //SaldoCliente puede modificar su valor. 
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Retira20Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se actualizaron los datos con exito!", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
                lblRetiros.Location = new Point(98, 55);
                lblRetiros.Text = "Transaccion Realizada con Exito!";
                txtRanuraRetiros.Text = "$ 20";

                //botones
                btnRetira200.Visible = false;
                btnRetira1000.Visible = false;
                btnRetira20.Visible = false;
                btnRetira50.Visible = false;
                btnRetira100.Visible = false;
                btnRetira500.Visible = false;

            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }



        }







        public void DarRetiro50()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            int CantidadExistencias = 0;                                    //SaldoCliente puede modificar su valor. 
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Retira50Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se actualizaron los datos con exito!", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
                lblRetiros.Location = new Point(98, 55);
                lblRetiros.Text = "Transaccion Realizada con Exito!";
                txtRanuraRetiros.Text = "$ 50";

                //botones
                btnRetira200.Visible = false;
                btnRetira1000.Visible = false;
                btnRetira20.Visible = false;
                btnRetira50.Visible = false;
                btnRetira100.Visible = false;
                btnRetira500.Visible = false;

            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }



        }








        public void DarRetiro200()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            int CantidadExistencias = 0;                                    //SaldoCliente puede modificar su valor. 
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Retira200Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se actualizaron los datos con exito!", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
                lblRetiros.Location = new Point(98, 55);
                lblRetiros.Text = "Transaccion Realizada con Exito!";
                txtRanuraRetiros.Text = "$ 200";

                //botones
                btnRetira200.Visible = false;
                btnRetira1000.Visible = false;
                btnRetira20.Visible = false;
                btnRetira50.Visible = false;
                btnRetira100.Visible = false;
                btnRetira500.Visible = false;

            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }



        }










        public void DarRetiro100()
        {
            //variables
            int cantCambios = 0; //refenciado a esto
            int CantidadExistencias = 0;                                    //SaldoCliente puede modificar su valor. 
            double SaldoActual = Convert.ToDouble(txt_info_saldo2.Text); //saldo actual referenciado porque vamos a copiar y pegar? o porque va a estar referenciado a un textbox
            string NumeroCuenta = (txtNoCta.Text);


            //objeto de forma local de la clase
            BaseDatos DB = new BaseDatos();

            if (DB.Retira100Pesos(ref cantCambios, ref SaldoActual, NumeroCuenta) >= 0)
            {
                MessageBox.Show("Se actualizaron los datos con exito!", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoxddd.Text = Convert.ToString(SaldoActual);
                txtRanuraDepositosMonto.Clear();
                lblRetiros.Location = new Point(98, 55);
                lblRetiros.Text = "Transaccion Realizada con Exito!";
                txtRanuraRetiros.Text = "$ 100";

                //botones
                btnRetira200.Visible = false;
                btnRetira1000.Visible = false;
                btnRetira20.Visible = false;
                btnRetira50.Visible = false;
                btnRetira100.Visible = false;
                btnRetira500.Visible = false;

            }

            else
            {
                MessageBox.Show("No se pudo actualizar de forma correcta los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }



        }














        public void VerificarDatosBtn1()
        {
            //variables
            string NumeroCuenta = Convert.ToString(txtNoCta.Text); //valor que nos da el usuario para el acceso y busqueda
            

            BaseDatos DB = new BaseDatos(); // nuevo objeto
            bool credencialesValidas = DB.VerificarNumeroCuenta(NumeroCuenta);

            if (credencialesValidas == true)
            {
                // Las credenciales son válidas
                // Continuar con la lógica de tu programa para el usuario autenticado


                //NoCta = txtNoCta.Text;




                txtNoCta.Location = new Point(0, 0);
                labelNoCta.Location = new Point(0, 0);

                labelNoCta.Visible = false;
                txtNoCta.Visible = false;

                //Boton para NIP
                lblNip.Visible = true;
                txtNIP.Visible = true;

                txtNIP.Location = new Point(200, 250);
                lblNip.Location = new Point(120, 200);


                btnEnter1.Visible = false;

                btnEnter2.Visible = true;
                btnEnter2.Location = new Point(173, 711);

                //saldoxddd.Text = Saldo;


            }
            else
            {
                // Las credenciales son inválidas
                MessageBox.Show("Numero de cuenta incorrecta. Verifique nuevamente los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNoCta.Focus();
            }
        }

        //----------------------------------







        public void VerificarDatosBtn2()
        {



            //variables
            string NumeroCuenta = Convert.ToString(txtNoCta.Text); //valor que nos da el usuario para el acceso
            string Nombre = "";
            string NIP = Convert.ToString(txtNIP.Text); //se buscara esta informacion
            double Saldo = 0; //saldo actual

            BaseDatos DB = new BaseDatos(); // nuevo objeto
            bool credencialesValidas = DB.VerificarNIP(txtNoCta.Text, NIP, ref Nombre, ref Saldo);



            if (credencialesValidas == true) //en caso de que no haya consultas 
            {
                lineaDivisora.Visible = true;

                lblNip.Visible = false;
                txtNIP.Visible = false;

                btnSaldo.Visible = true;
                btnSalir.Visible = true;
                btnRetirar.Visible = true;
                btnDepositos.Visible = true;
                logoAnimation1.Visible = true;
                lblNombre.Visible = true;

                lblNombre.Text = Nombre;

                txtInfo_NoCta.Text = NumeroCuenta;
                saldoxddd.Text = Convert.ToString(Saldo); //copia de la base de datos y pega al textbox
                txtInfo_Nombre.Text = Nombre;

                //llenar el textbox, una vez iniciada la cuenta
                txt_info_saldo2.Text = Convert.ToString(Saldo); //copia de la base de datos y pega al textbox
            }


            else
            {
                MessageBox.Show("NIP incorrecto. Verifique nuevamente los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNIP.Focus();
            }


        }

        //----------------------------------
















        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click_1(object sender, EventArgs e)
        {
            txtNoCta.Focus();

            txtInfo_NoCta.Clear();
            txtInfo_Nombre.Clear();
            txtNIP.Clear();
            //txtNoCta.Clear();
            txtRanuraDepositosMonto.Clear();
            txtRanuraRetiros.Clear();
            txt_info_saldo2.Clear();
            

            
            guna2Button1.Enabled = true;
            guna2Button2.Enabled = true;
            guna2Button3.Enabled = true;
            guna2Button4.Enabled = true;
            guna2Button5.Enabled = true;
            guna2Button6.Enabled = true;
            guna2Button7.Enabled = true;
            guna2Button8.Enabled = true;
            guna2Button9.Enabled = true;
            guna2Button10.Enabled = true;
            btnEnter1.Enabled = true;
            guna2Button12.Enabled = true;
            guna2Button13.Enabled = true;



            lblDespedida.Visible = false;
            lblBienvenida.Visible = true;

            label2.Visible = false;
            logoAnimation1.Visible = false;

            labelNoCta.Visible = true;
            labelNoCta.Location = new Point(98, 200);

            txtNoCta.Visible = true;
            txtNoCta.Location = new Point(150, 250);



            






        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "1"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "1"; // Agregar el carácter "1" al TextBox2
            }


            

            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "2"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "2"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "3"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "3"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "4"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "4"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "5"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "5"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "6"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "6"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "7"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "7"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "8"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "8"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "9"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "9"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Text.Length < 5) // Verificar que la longitud actual sea menor que 4
            {
                txtNoCta.Text += "0"; // Agregar el carácter "1" al TextBox2
            }


            if (txtNIP.Text.Length < 4) // Verificar que la longitud actual sea menor que 4
            {
                txtNIP.Text += "0"; // Agregar el carácter "1" al TextBox2
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            //txtNoCta.Clear();
            txtNIP.Clear();
        }

        private void guna2Button11_Click_1(object sender, EventArgs e)
        {

            //Boton para la NoCta
            txtNIP.Clear();



            if (txtNoCta.Text == "")
            {
                MessageBox.Show("Campos vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                VerificarDatosBtn1();
                

            }





        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            if (txtNoCta.Visible)
            {
                txtNoCta.Text = txtNoCta.Text.Remove(txtNoCta.Text.Length - 1); //Elimina el último carácter del cuadro de texto
            }

            else if (txtNIP.Visible)
            {
                txtNIP.Text = txtNIP.Text.Remove(txtNIP.Text.Length - 1); //Elimina el último carácter del cuadro de texto
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






        private void btnEnter2_Click(object sender, EventArgs e)
        {
            if (txtNIP.Text == "")
            {
                MessageBox.Show("Campos vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                VerificarDatosBtn2();
            }

        }






        private void btnSalir_Click(object sender, EventArgs e)
        {
            lineaDivisora.Visible = false;
            this.ActiveControl = null;


            //RESETEAR - limpiar los contenidos almacenados en los textboxses
            txtNoCta.Clear();
            txtNIP.Clear();
            txtInfo_NoCta.Clear();
            txtInfo_Nombre.Clear();
            txtRanuraDepositosMonto.Clear();
            txtRanuraRetiros.Clear();
            txt_info_saldo2.Clear();
            

            btnEnter2.Visible = false;
            btnEnter1.Visible = true;
            

            btnSaldo.Visible = false;
            btnSalir.Visible = false;
            btnRetirar.Visible = false;
            btnDepositos.Visible = false;
            logoAnimation1.Visible = false;
            btnRegresar.Visible = false;
            lblBienvenida.Visible = false;
            lblNombre.Visible = false;
            lblDespedida.Visible = true;
            lblDespedida.Location = new Point(180, 200);
            label2.Visible = true;
            

            

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            lineaDivisora.Visible = false;


            lblRetiros.Text = "Seleccione la cantidad a retirar";
            btnRetira50.Visible = true;
            btnRetira20.Visible = true;
            btnRetira100.Visible = true;
            btnRetira1000.Visible = true;
            btnRetira200.Visible = true;
            btnRetira500.Visible = true;
            lblNombre.Visible = true;

            btnRegresar.Visible = false;

            lblBienvenida.Visible = false;
            btnSaldo.Visible = false;
            btnSalir.Visible = false;
            btnRetirar.Visible = false;
            btnDepositos.Visible = false;
            logoAnimation1.Visible = false;



            labelDepositos.Visible = true;
            labelDepositos.Location = new Point(60, 200);

            gpbRetiros.Visible = true;
            gpbRetiros.Location = new Point(60, 145);
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            lineaDivisora.Visible = false;

            lblBienvenida.Visible=false;
            btnSaldo.Visible = false;
            btnSalir.Visible = false;
            btnRetirar.Visible = false;
            btnDepositos.Visible = false;
            logoAnimation1.Visible = false;
            btnRegresar.Visible = false;



            gpbDepositos.Visible = true;
            gpbDepositos.Location = new Point(60, 145);

            labelDepositos.Location = new Point(17, 52);







        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            lineaDivisora.Visible = true;

            lblNombre.Location = new Point(130, 17);
            lblBienvenida.Visible = false;
            btnRegresar.Visible = true;
            btnRegresar.Location = new Point(0, 230);
            logoAnimation1.Visible=false;
            btnSaldo.Visible=false;
            btnRetirar.Visible=false;
            btnDepositos.Visible=false;
            btnSalir.Visible=false;







            //nocta
            lblNumeroCuenta.Visible = true;
            lblNumeroCuenta.Location = new Point(140, 230);

            txtInfo_NoCta.Visible = true;
            txtInfo_NoCta.Location = new Point(320, 225);


            //nombre
            lblInfoNombre.Visible = true;
            lblInfoNombre.Location = new Point(140, 270);

            txtInfo_Nombre.Visible = true;
            txtInfo_Nombre.Location = new Point(240, 265);




            //saldo info
            slado2lbl.Visible = true;
            slado2lbl.Location = new Point(140, 310);


            txt_info_saldo2.Visible = true;
            txt_info_saldo2.Location = new Point(240, 305);


            ConsultarSaldo();




        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            lblNombre.Location = new Point(170, 17);

            lineaDivisora.Visible = true;
            btnRegresar.Location = new Point(0, 61);
            logoAnimation1.Visible = true;
            btnSaldo.Visible = true;
            btnDepositos.Visible = true;
            btnSalir.Visible = true;
            btnRetirar.Visible = true;
            lblNumeroCuenta.Visible = false;
            txtInfo_NoCta.Visible = false;
            lblInfoNombre .Visible = false;
            txtInfo_Nombre .Visible = false;
            gpbDepositos.Visible = false;
            slado2lbl.Visible = false;
            txt_info_saldo2.Visible = false;
            lblBienvenida.Visible = true;

        }



        private void btnRegresar2_Click_1(object sender, EventArgs e)
        {
            lineaDivisora.Visible = true;


            txtRanuraDepositosMonto.Clear();
            logoAnimation1.Visible = true;
            btnSaldo.Visible = true;
            btnDepositos.Visible = true;
            btnSalir.Visible = true;
            btnRetirar.Visible = true;
            lblNumeroCuenta.Visible = false;
            txtInfo_NoCta.Visible = false;
            lblInfoNombre.Visible = false;
            txtInfo_Nombre.Visible = false;
            gpbDepositos.Visible = false;
            lblBienvenida.Visible = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            btnRegresar3.Visible = true;
            labelDepositos.Text = "Selecciona el monto el cual deseas depositar a tu cuenta";
            btnContinuar.Visible = false;
            btnRegresar2.Visible = false;
            btn500.Visible = true;
            btn200.Visible = true;
            btn100.Visible = true;
            btn50.Visible = true;
            btn20.Visible = true;
            txtRanuraDepositosMonto.ReadOnly = false;
            txtRanuraDepositosMonto.Focus();
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            btnRegresar3.Visible = false;
            btnRegresar2.Visible = true;
            btnContinuar.Visible = true;
            labelDepositos.Text = "Usted cuenta con billetes de ($500, $200, $100, $50, $20)";
            btn500.Visible = false;
            btn200.Visible = false;
            btn100.Visible = false;
            btn50.Visible = false;
            btn20.Visible = false;

            lblBienvenida.Visible = true;





        }

        private void btn500_Click(object sender, EventArgs e)
        {
            txtRanuraDepositosMonto.Focus();
            btnRegresar3.Visible = false;
            labelDepositos.Location = new Point(90, 55);
            labelDepositos.Text = "Deseas depositar $500 a esta cuenta? ";



            btn500.Visible = false;
            btn200.Visible = false;
            btn100.Visible = false;
            btn50.Visible = false;
            btn20.Visible = false;

            btnSi.Visible = true;
            btnSi.Location = new Point(265, 100);

            btnNo.Visible = true;
            btnNo.Location = new Point(100, 100);





        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnNo.Visible = false;
            btnSi.Visible = false;
            labelDepositos.Text = "Usted cuenta con billetes de ($500, $200, $100, $50, $20)";
            labelDepositos.Location = new Point(17, 55);
            btn500.Visible = true;
            btn200.Visible = true;
            btn100.Visible = true;
            btn50.Visible = true;
            btn20.Visible = true;
            btnRegresar3 .Visible = true;
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            txtRanuraDepositosMonto.Focus();
            btnRegresar3.Visible = false;
            labelDepositos.Location = new Point(90, 55);
            labelDepositos.Text = "Deseas depositar $200 a esta cuenta? ";
            btn500.Visible = false;
            btn200.Visible = false;
            btn100.Visible = false;
            btn50.Visible = false;
            btn20.Visible = false;

            btnSi.Visible = true;
            btnSi.Location = new Point(265, 100);

            btnNo.Visible = true;
            btnNo.Location = new Point(100, 100);
        }

        private void btnSi_Click(object sender, EventArgs e)
        {

            // -----------------------------------------------------------------------------------------------------------
            if (labelDepositos.Text == "Deseas depositar $500 a esta cuenta? " && txtRanuraDepositosMonto.Text == "500.00")
            {
                Darcambios500();
                labelDepositos.Location = new Point(98, 55);
                labelDepositos.Text = "Transaccion Realizada con Exito!";
                btnSi.Visible = false;
                btnNo.Visible = false;
                btnVolver.Visible = true;
                btnVolver.Location = new Point(160, 100);
                
            }

            else if (labelDepositos.Text == "Deseas depositar $500 a esta cuenta? " && txtRanuraDepositosMonto.Text != "500.00")
            {
                MessageBox.Show("Este billete no es el adecuado, intente con otro billete de $500,","No se ha podido hacer la transaccion");
                txtRanuraDepositosMonto.Focus();
            }


            // -----------------------------------------------------------------------------------------------------------





            // -----------------------------------------------------------------------------------------------------------



            else if (labelDepositos.Text == "Deseas depositar $200 a esta cuenta? " && txtRanuraDepositosMonto.Text == "200.00")
            {
                Darcambios200();
                labelDepositos.Location = new Point(98, 55);
                labelDepositos.Text = "Transaccion Realizada con Exito!";
                btnSi.Visible = false;
                btnNo.Visible = false;
                btnVolver.Visible = true;
                btnVolver.Location = new Point(160, 100);
            }


            else if (labelDepositos.Text == "Deseas depositar $200 a esta cuenta? " && txtRanuraDepositosMonto.Text != "200.00")
            {
                MessageBox.Show("Este billete no es el adecuado, intente con otro billete de $200,", "No se ha podido hacer la transaccion");
            }


            // -----------------------------------------------------------------------------------------------------------










            // -----------------------------------------------------------------------------------------------------------

            else if (labelDepositos.Text == "Deseas depositar $100 a esta cuenta? " && txtRanuraDepositosMonto.Text == "100.00")
            {
                Darcambios100();
                labelDepositos.Location = new Point(98, 55);
                labelDepositos.Text = "Transaccion Realizada con Exito!";
                btnSi.Visible = false;
                btnNo.Visible = false;
                btnVolver.Visible = true;
                btnVolver.Location = new Point(160, 100);
            }


            else if (labelDepositos.Text == "Deseas depositar $100 a esta cuenta? " && txtRanuraDepositosMonto.Text != "100.00")
            {
                MessageBox.Show("Este billete no es el adecuado, intente con otro billete de $100,", "No se ha podido hacer la transaccion");
            }


            // -----------------------------------------------------------------------------------------------------------












            // -----------------------------------------------------------------------------------------------------------
            else if (labelDepositos.Text == "Deseas depositar $50 a esta cuenta? " && txtRanuraDepositosMonto.Text == "50.00")
            {
                Darcambios50();
                labelDepositos.Location = new Point(98, 55);
                labelDepositos.Text = "Transaccion Realizada con Exito!";
                btnSi.Visible = false;
                btnNo.Visible = false;
                btnVolver.Visible = true;
                btnVolver.Location = new Point(160, 100);
            }

            else if (labelDepositos.Text == "Deseas depositar $50 a esta cuenta? " && txtRanuraDepositosMonto.Text != "50.00")
            {
                MessageBox.Show("Este billete no es el adecuado, intente con otro billete de $50,", "No se ha podido hacer la transaccion");
            }

            // -----------------------------------------------------------------------------------------------------------












            // -----------------------------------------------------------------------------------------------------------
            else if (labelDepositos.Text == "Deseas depositar $20 a esta cuenta? " && txtRanuraDepositosMonto.Text == "20.00")
            {
                Darcambios20();
                labelDepositos.Location = new Point(98, 55);
                labelDepositos.Text = "Transaccion Realizada con Exito!";
                btnSi.Visible = false;
                btnNo.Visible = false;
                btnVolver.Visible = true;
                btnVolver.Location = new Point(160, 100);
            }


            else if (labelDepositos.Text == "Deseas depositar $20 a esta cuenta? " && txtRanuraDepositosMonto.Text != "20.00")
            {
                MessageBox.Show("Este billete no es el adecuado, intente con otro billete de $20,", "No se ha podido hacer la transaccion");
            }
            // -----------------------------------------------------------------------------------------------------------


        }





        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnVolver.Visible = false;
            btnNo.Visible = false;
            btnSi.Visible = false;
            labelDepositos.Text = "Usted cuenta con billetes de ($500, $200, $100, $50, $20)";
            labelDepositos.Location = new Point(17, 55);
            btn500.Visible = true;
            btn200.Visible = true;
            btn100.Visible = true;
            btn50.Visible = true;
            btn20.Visible = true;
            btnRegresar3.Visible = true;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            txtRanuraDepositosMonto.Focus();
            btnRegresar3.Visible = false;
            labelDepositos.Location = new Point(90, 55);
            labelDepositos.Text = "Deseas depositar $100 a esta cuenta? ";
            btn500.Visible = false;
            btn200.Visible = false;
            btn100.Visible = false;
            btn50.Visible = false;
            btn20.Visible = false;

            btnSi.Visible = true;
            btnSi.Location = new Point(265, 100);

            btnNo.Visible = true;
            btnNo.Location = new Point(100, 100);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            txtRanuraDepositosMonto.Focus();
            btnRegresar3.Visible = false;
            labelDepositos.Location = new Point(90, 55);
            labelDepositos.Text = "Deseas depositar $50 a esta cuenta? ";
            btn500.Visible = false;
            btn200.Visible = false;
            btn100.Visible = false;
            btn50.Visible = false;
            btn20.Visible = false;

            btnSi.Visible = true;
            btnSi.Location = new Point(265, 100);

            btnNo.Visible = true;
            btnNo.Location = new Point(100, 100);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtRanuraDepositosMonto.Focus();
            btnRegresar3.Visible = false;
            labelDepositos.Location = new Point(90, 55);
            labelDepositos.Text = "Deseas depositar $20 a esta cuenta? ";
            btn500.Visible = false;
            btn200.Visible = false;
            btn100.Visible = false;
            btn50.Visible = false;
            btn20.Visible = false;

            btnSi.Visible = true;
            btnSi.Location = new Point(265, 100);

            btnNo.Visible = true;
            btnNo.Location = new Point(100, 100);
        }

        private void txtInfo_Saldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRanuraDepositosMonto_Leave(object sender, EventArgs e)
        {
            //cuanndo salga 

            FormatoMoneda();
        }

        private void btnRegresa4_Click(object sender, EventArgs e)
        {
            lineaDivisora.Visible = true;


            gpbRetiros.Visible = false;
            lblBienvenida.Visible = true;
            lblInfoNombre.Visible = true;
            btnSaldo.Visible = true;
            btnSalir.Visible = true;
            btnRetirar.Visible = true;
            btnDepositos.Visible = true;
            logoAnimation1.Visible = true;
            saldoxddd.Visible = false;
            lblInfoNombre.Visible=false;
            lblNombre.Visible=false;
            lblNombre.Visible = true;

            txtRanuraRetiros.Clear();
        }





        private void btnRetira20_Click(object sender, EventArgs e)
        {
            DarRetiro20();
        }

        private void btnRetira50_Click(object sender, EventArgs e)
        {
            DarRetiro50();
        }

        private void btnRetira100_Click(object sender, EventArgs e)
        {
            DarRetiro100();
        }

        private void btnRetira200_Click(object sender, EventArgs e)
        {
            DarRetiro200();
        }

        private void btnRetira500_Click(object sender, EventArgs e)
        {
            DarRetiro500();


        }

        private void btnRetira1000_Click(object sender, EventArgs e)
        {
            DarRetiro1000();
        }
    }
}
