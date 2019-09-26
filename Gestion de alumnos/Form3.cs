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
        //DECLARO TABLAALUMNO PARA QUE LO USE TODO EL FORMULARIO
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
                        fila11[1] = "12/05/2005";
                        fila11[2] = "14 años";
                        fila11[3] = "45.138.113";
                        fila11[4] = "Avenida Olivos 4109";
                        fila11[5] = "Rio Cuarto";
                        fila11[6] = "3548856915";
                        fila11[7] = "aaroncr123@gmail.com";
                        fila11[8] = "424124";
                        fila11[9] = "Masculino";
                        tablaalumno.Rows.Add(fila11);

                        DataRow fila21 = tablaalumno.NewRow();
                        fila21[0] = "Lucas Romero";
                        fila21[1] = "11/01/2005";
                        fila21[2] = "14 años";
                        fila21[3] = "45.224.568";
                        fila21[4] = "Pte. Roca 4145";
                        fila21[5] = "Villa Carlos Paz";
                        fila21[6] = "351185134";
                        fila21[7] = "---------";
                        fila21[8] = "424124";
                        fila21[9] = "Masculino";
                        tablaalumno.Rows.Add(fila21);

                        DataRow fila31 = tablaalumno.NewRow();
                        fila31[0] = "Laura Guerrero Rodriguez";
                        fila31[1] = "17/11/2005";
                        fila31[2] = "14 años";
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


                    case "3":
                        DataRow fila12 = tablaalumno.NewRow();
                        fila12[0] = "Paulo Ezequiel Reyes";
                        fila12[1] = "11/05/2004";
                        fila12[2] = "15 años";
                        fila12[3] = "47.168.123";
                        fila12[4] = "Avenida Olivos 4109";
                        fila12[5] = "Rio Cuarto";
                        fila12[6] = "3548856915";
                        fila12[7] = "aaroncr123@gmail.com";
                        fila12[8] = "424124";
                        fila12[9] = "Masculino";
                        tablaalumno.Rows.Add(fila12);

                        DataRow fila22 = tablaalumno.NewRow();
                        fila22[0] = "Gonzales Romero";
                        fila22[1] = "11/01/2004";
                        fila22[2] = "13 años";
                        fila22[3] = "46.224.998";
                        fila22[4] = "Pte. Roca 4145";
                        fila22[5] = "Villa Carlos Paz";
                        fila22[6] = "351185134";
                        fila22[7] = "---------";
                        fila22[8] = "424124";
                        fila22[9] = "Masculino";
                        tablaalumno.Rows.Add(fila22);

                        DataRow fila32 = tablaalumno.NewRow();
                        fila32[0] = "Paula Rodriguez";
                        fila32[1] = "17/11/2007";
                        fila32[2] = "15 años";
                        fila32[3] = "45.853.783";
                        fila32[4] = "Ruta Sur Km 37";
                        fila32[5] = "Rio Cuarto";
                        fila32[6] = "3541657625";
                        fila32[7] = "farra@outlook.com";
                        fila32[8] = "422329";
                        fila32[9] = "Femenino";
                        tablaalumno.Rows.Add(fila32);

                        cmboxalumno.DataSource = tablaalumno;
                        cmboxalumno.DisplayMember = "Nombre y apellido";
                        cmboxalumno.ValueMember = "DNI";
                        break;


                    case "4":
                        DataRow fila13 = tablaalumno.NewRow();
                        fila13[0] = "Aaron Lorenzo Guzman";
                        fila13[1] = "12/05/2007";
                        fila13[2] = "12 años";
                        fila13[3] = "47.168.123";
                        fila13[4] = "Avenida Sarmiento 4109";
                        fila13[5] = "Rio Cuarto";
                        fila13[6] = "3548856915";
                        fila13[7] = "aaroncr123@gmail.com";
                        fila13[8] = "424124";
                        fila13[9] = "Masculino";
                        tablaalumno.Rows.Add(fila13);

                        DataRow fila23 = tablaalumno.NewRow();
                        fila23[0] = "Alan Lorenzo";
                        fila23[1] = "11/01/2007";
                        fila23[2] = "16 años";
                        fila23[3] = "46.224.998";
                        fila23[4] = "Pte. Augusto 45";
                        fila23[5] = "Villa Carlos Paz";
                        fila23[6] = "351185134";
                        fila23[7] = "---------";
                        fila23[8] = "424124";
                        fila23[9] = "Masculino";
                        tablaalumno.Rows.Add(fila23);

                        DataRow fila33 = tablaalumno.NewRow();
                        fila33[0] = "Lorena Lopez";
                        fila33[1] = "17/11/2007";
                        fila33[2] = "16 años";
                        fila33[3] = "44.812.783";
                        fila33[4] = "Ruta norte Km 37";
                        fila33[5] = "Rio Tercero";
                        fila33[6] = "3541657625";
                        fila33[7] = "lorenaxd@outlook.com";
                        fila33[8] = "422329";
                        fila33[9] = "Femenino";
                        tablaalumno.Rows.Add(fila33);

                        cmboxalumno.DataSource = tablaalumno;
                        cmboxalumno.DisplayMember = "Nombre y apellido";
                        cmboxalumno.ValueMember = "DNI";
                        break;


                    case "5":
                        DataRow fila14 = tablaalumno.NewRow();
                        fila14[0] = "Alberto del valle";
                        fila14[1] = "12/05/2003";
                        fila14[2] = "17 años";
                        fila14[3] = "47.168.123";
                        fila14[4] = "Avenida Olivos 4109";
                        fila14[5] = "Rio Cuarto";
                        fila14[6] = "3548856915";
                        fila14[7] = "aaroncr123@gmail.com";
                        fila14[8] = "424124";
                        fila14[9] = "Masculino";
                        tablaalumno.Rows.Add(fila14);

                        DataRow fila24 = tablaalumno.NewRow();
                        fila24[0] = "Lucas Alejandro Rodriguez";
                        fila24[1] = "11/01/2003";
                        fila24[2] = "17 años";
                        fila24[3] = "42.224.998";
                        fila24[4] = "Pte. Roca 4145";
                        fila24[5] = "Villa Carlos Paz";
                        fila24[6] = "351185134";
                        fila24[7] = "---------";
                        fila24[8] = "424124";
                        fila24[9] = "Masculino";
                        tablaalumno.Rows.Add(fila24);

                        DataRow fila34 = tablaalumno.NewRow();
                        fila34[0] = "Laura Lucierna Kornivos";
                        fila34[1] = "17/11/2003";
                        fila34[2] = "17 años";
                        fila34[3] = "47.812.783";
                        fila34[4] = "Ruta Sur Km 37";
                        fila34[5] = "Rio Cuarto";
                        fila34[6] = "3541657625";
                        fila34[7] = "fatimaguerra@outlook.com";
                        fila34[8] = "422349";
                        fila34[9] = "Femenino";
                        tablaalumno.Rows.Add(fila34);

                        cmboxalumno.DataSource = tablaalumno;
                        cmboxalumno.DisplayMember = "Nombre y apellido";
                        cmboxalumno.ValueMember = "DNI";
                        break;


                    case "6":
                        DataRow fila15 = tablaalumno.NewRow();
                        fila15[0] = "Luciano Guillermo ";
                        fila15[1] = "12/05/2001";
                        fila15[2] = "12 años";
                        fila15[3] = "47.168.123";
                        fila15[4] = "Avenida Olivos 4109";
                        fila15[5] = "Rio Cuarto";
                        fila15[6] = "3548856915";
                        fila15[7] = "aaroncr123@gmail.com";
                        fila15[8] = "424124";
                        fila15[9] = "Masculino";
                        tablaalumno.Rows.Add(fila15);

                        DataRow fila25 = tablaalumno.NewRow();
                        fila25[0] = "Carlos Roberto Lujan";
                        fila25[1] = "11/01/2001";
                        fila25[2] = "13 años";
                        fila25[3] = "46.224.998";
                        fila25[4] = "Pte. Roca 4145";
                        fila25[5] = "San Paz";
                        fila25[6] = "351185134";
                        fila25[7] = "---------";
                        fila25[8] = "424124";
                        fila25[9] = "Masculino";
                        tablaalumno.Rows.Add(fila25);

                        DataRow fila35 = tablaalumno.NewRow();
                        fila35[0] = "Ana Lopez Guillera";
                        fila35[1] = "17/11/2001";
                        fila35[2] = "12 años";
                        fila35[3] = "47.812.783";
                        fila35[4] = "Ruta Sur Km 37";
                        fila35[5] = "Rio Cuarto";
                        fila35[6] = "3541657625";
                        fila35[7] = "guerra@outlook.com";
                        fila35[8] = "422329";
                        fila35[9] = "Femenino";
                        tablaalumno.Rows.Add(fila35);

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

        private void Btnseleccionar_Click(object sender, EventArgs e)
        {
            //ACA VALIDO QUE EL COMBO AÑO HAYA SIDO SELECCIONADO
            if (cmboxalumno.SelectedIndex > -1)
            {
                string dni = cmboxalumno.SelectedValue.ToString();
                for (int i = 0; i < tablaalumno.Rows.Count; i++)
                {
                    txtnombreapellido.Text= tablaalumno.Rows[i][0].ToString();
                    txtfechanacimiento.Text = tablaalumno.Rows[i][1].ToString();
                    txtedad.Text = tablaalumno.Rows[i][2].ToString();
                    txtdni.Text = tablaalumno.Rows[i][3].ToString();
                    txtdomicilio.Text = tablaalumno.Rows[i][4].ToString();
                    txtlocalidad.Text = tablaalumno.Rows[i][5].ToString();
                    txttelefono.Text = tablaalumno.Rows[i][6].ToString();
                    txtemail.Text = tablaalumno.Rows[i][7].ToString();
                    txttelfijo.Text = tablaalumno.Rows[i][8].ToString();
                    txtsexo.Text = tablaalumno.Rows[i][9].ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, elija un año");
            }
        }
    }
}
