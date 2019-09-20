using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_alumnos
{
    public partial class Form3 : Form
    {
        DataTable tablaalumno;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Declaro los años de la secundaria
            DataTable Tablaaño = new DataTable();
            Tablaaño.Columns.Add("Id");
            Tablaaño.Columns.Add("Año");

            DataRow fila0 = Tablaaño.NewRow();
            fila0[0] = "0";
            fila0[1] = "Seleccionar";
            Tablaaño.Rows.Add(fila0);

            DataRow fila1 = Tablaaño.NewRow();
            fila1[0] = "1";
            fila1[1] = "1º año";
            Tablaaño.Rows.Add(fila1);

            DataRow fila2 = Tablaaño.NewRow();
            fila2[0] = "2";
            fila2[1] = "2º año";
            Tablaaño.Rows.Add(fila2);

            DataRow fila3 = Tablaaño.NewRow();
            fila3[0] = "3";
            fila3[1] = "3º año";
            Tablaaño.Rows.Add(fila3);

            DataRow fila4 = Tablaaño.NewRow();
            fila4[0] = "4";
            fila4[1] = "4º año";
            Tablaaño.Rows.Add(fila4);

            DataRow fila5 = Tablaaño.NewRow();
            fila5[0] = "5";
            fila5[1] = "5º año";
            Tablaaño.Rows.Add(fila5);

            DataRow fila6 = Tablaaño.NewRow();
            fila6[0] = "5";
            fila6[1] = "6º año";
            Tablaaño.Rows.Add(fila6);

            //Valuo que el año aparezca en el combobox y el ID es para ver el nº del año.
            cmboxaño.DataSource = Tablaaño;
            cmboxaño.ValueMember = "Id";
            cmboxaño.DisplayMember = "Año";

            //Adjunto a una columna los datos del alumno
            tablaalumno = new DataTable();
            tablaalumno.Columns.Add("Nombre y apellido");
            tablaalumno.Columns.Add("Fecha de nacimiento");
            tablaalumno.Columns.Add("Edad");
            tablaalumno.Columns.Add("DNI");
            tablaalumno.Columns.Add("Domicilio");
            tablaalumno.Columns.Add("Localidad");
            tablaalumno.Columns.Add("Telefono");
            tablaalumno.Columns.Add("E-mail");
            tablaalumno.Columns.Add("Tel. fijo");
            tablaalumno.Columns.Add("Sexo");

        }

        private void Cmboxaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxaño.SelectedIndex > 0)
            {
                tablaalumno.Clear();
                string Id = cmboxaño.SelectedValue.ToString();

                switch (Id)
                {
                    case "1":
                        //ESTE SERA PARA PRIMER AÑO Y ASI SUCESIVAMENTE CON LOS SIGUIENTES CASE
                        //CARGAS DATOS DEL ALUMNO
                        //CADA CASE REPRESENTA UN AÑO Y CON SUS RESPECTIVOS DATOS.
                        //CASE 1:1AÑO, CASE2:2AÑO, ETC..
                        DataRow fila10 = tablaalumno.NewRow();
                        fila10[0] = "Aaron Castro Reyes";
                        fila10[1] = "12/05/2007";
                        fila10[2] = "12 años";
                        fila10[3] = "47.168.123";
                        fila10[4] = "Avenida Olivos 4109";
                        fila10[5] = "Rio Cuarto";
                        fila10[6] = "3548856915";
                        fila10[7] = "aaroncr123@gmail.com";
                        fila10[8] = "424124";
                        fila10[9] = "Masculino";
                        tablaalumno.Rows.Add(fila10);

                        DataRow fila20 = tablaalumno.NewRow();
                        fila20[0] = "Darío Puig Delgado";
                        fila20[1] = "15/03/2006";
                        fila20[2] = "13 años";
                        fila20[3] = "46.224.998";
                        fila20[4] = "Pte. Roca 4145";
                        fila20[5] = "Villa Carlos Paz";
                        fila20[6] = "351185134";
                        fila20[7] = "---------";
                        fila20[8] = "424124";
                        fila20[9] = "Masculino";
                        tablaalumno.Rows.Add(fila20);

                        DataRow fila30 = tablaalumno.NewRow();
                        fila30[0] = "Fátima Guerrero Parra";
                        fila30[1] = "15/12/2007";
                        fila30[2] = "12 años";
                        fila30[3] = "47.888.123";
                        fila30[4] = "Ruta Panamericana Km 36";
                        fila30[5] = "Rio Cuarto";
                        fila30[6] = "3548677625";
                        fila30[7] = "fatimaguerra@outlook.com";
                        fila30[8] = "421129";
                        fila30[9] = "Femenino";
                        tablaalumno.Rows.Add(fila30);

                        cmboxalumno.DataSource = tablaalumno;
                        cmboxalumno.DisplayMember = "Nombre y apellido";
                        cmboxalumno.ValueMember = "DNI";
                        break;

                    case "2":
                        DataRow fila11 = tablaalumno.NewRow();
                        fila11[0] = "Aaron Castro Reyes";
                        fila11[1] = "12/05/2007";
                        fila11[2] = "12 años";
                        fila11[3] = "47.168.123";
                        fila11[4] = "Avenida Olivos 4109";
                        fila11[5] = "Rio Cuarto";
                        fila11[6] = "3548856915";
                        fila11[7] = "aaroncr123@gmail.com";
                        fila11[8] = "424124";
                        fila11[9] = "Masculino";
                        tablaalumno.Rows.Add(fila11);

                        DataRow fila21 = tablaalumno.NewRow();
                        fila21[0] = "Lucas Romero";
                        fila21[1] = "11/01/2007";
                        fila21[2] = "13 años";
                        fila21[3] = "46.224.998";
                        fila21[4] = "Pte. Roca 4145";
                        fila21[5] = "Villa Carlos Paz";
                        fila21[6] = "351185134";
                        fila21[7] = "---------";
                        fila21[8] = "424124";
                        fila21[9] = "Masculino";
                        tablaalumno.Rows.Add(fila21);

                        DataRow fila31 = tablaalumno.NewRow();
                        fila31[0] = "Laura Guerrero Rodriguez";
                        fila31[1] = "17/11/2007";
                        fila31[2] = "12 años";
                        fila31[3] = "47.812.783";
                        fila31[4] = "Ruta Sur Km 37";
                        fila31[5] = "Rio Cuarto";
                        fila31[6] = "3541657625";
                        fila31[7] = "fatimaguerra@outlook.com";
                        fila31[8] = "422329";
                        fila31[9] = "Femenino";
                        tablaalumno.Rows.Add(fila31);

                        cmboxalumno.DataSource = tablaalumno;
                        cmboxalumno.DisplayMember = "Nombre y apellido";
                        cmboxalumno.ValueMember = "DNI";
                        break;




                }
            }
        }

        private void Cmboxalumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
