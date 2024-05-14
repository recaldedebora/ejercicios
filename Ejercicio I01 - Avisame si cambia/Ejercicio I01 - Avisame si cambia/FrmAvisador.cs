using Logica;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ejercicio_I01___Avisame_si_cambia
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;
        bool flagPersona;
        public FrmAvisador()
        {
            InitializeComponent();
            persona = new Persona();
            persona.EventoString += NotificarCambio;
            flagPersona = true;
        }

        public void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txb_Nombre.Text) && !string.IsNullOrWhiteSpace(txb_Apellido.Text))
            {
                if (persona.Nombre != txt_Nombre.Text)
                {
                    persona.Nombre = txt_Nombre.Text;

                }

                if (persona.Apellido != txt_Apellido.Text)
                {
                    persona.Apellido = txt_Apellido.Text;

                }

                lbl_NombreCompleto.Text = persona.Mostrar();

                if (flagPersona)
                {
                    btn_Crear.Text = "Actualizar";
                    flagPersona = false;
                }
            }
            else
            {
                MessageBox.Show("Complete los campos");
            }

        }


    }
}