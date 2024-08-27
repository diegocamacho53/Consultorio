using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Consultorio.Formularios
{
    /// <summary>
    /// Formulario principal de la aplicación Consultorio, que gestiona la interfaz y funcionalidades principales del sistema.
    /// </summary>
    public partial class PanelPrincipal : Form
    {
        #region Variables

        /// <summary>
        /// Variable que almacena el consecutivo del empleado.
        /// </summary>
        private int _cnsctvoEmpldo;

        /// <summary>
        /// Cadena de conexión a la base de datos.
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Nombre de usuario que ha iniciado sesión en el formulario.
        /// </summary>
        private string nombreUsuario;

        /// <summary>
        /// Temporizador utilizado para gestionar eventos temporales en el formulario.
        /// </summary>
        private Timer timer;

        /// <summary>
        /// Fecha y hora en que se inició la sesión del usuario en el formulario.
        /// </summary>
        private DateTime horaInicioSesion;

        /// <summary>
        /// Contador de segundos transcurridos desde el inicio de la sesión.
        /// </summary>
        private int segundosTranscurridos;

        private int idUsuario;

        #endregion


        #region Controlador

        /// <summary>
        /// Constructor de la clase PanelPrincipal que inicializa el formulario con la cadena de conexión y el nombre de usuario.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <param name="nombreUsuario">Nombre de usuario que ha iniciado sesión.</param>
        /// <param name="idUsuario">Nombre de usuario que ha iniciado sesión.</param>
        public PanelPrincipal(string connectionString, string nombreUsuario, int idUsuario)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.nombreUsuario = nombreUsuario;
            this.idUsuario = idUsuario;
            MostrarSubMenu();
            this.horaInicioSesion = DateTime.Now;

            ValidarUsuario();
        }

        #endregion

        #region Metodos


        /// <summary>
        /// Oculta todos los paneles de submenú en el formulario actual.
        /// </summary>
        private void MostrarSubMenu()
        {
            panelSubMenuCitas.Visible = false;
            panelSubMenuFinanzas.Visible = false;
            panelSubMenuPacientes.Visible = false;
            panelSubMenuConfiguracion.Visible = false;
        }


        /// <summary>
        /// Oculta los paneles de submenú si están visibles.
        /// </summary>
        private void OcutarPanelSub()
        {
            if (panelSubMenuCitas.Visible == true)
                panelSubMenuCitas.Visible = false;
            if (panelSubMenuConfiguracion.Visible == true)
                panelSubMenuConfiguracion.Visible = false;
            if (panelSubMenuPacientes.Visible == true)
                panelSubMenuPacientes.Visible = false;
            if (panelSubMenuFinanzas.Visible == true)
                panelSubMenuFinanzas.Visible = false;
        }

        private void ValidarUsuario()
        {
            if (idUsuario != 1)
            {
                buttonRegistrarRol.Visible = false;
                buttonRegistrarUsuario.Visible = false;
            }
        }

        /// <summary>
        /// Muestra o oculta el submenú del panel lateral pasado como parámetro.
        /// </summary>
        /// <param name="panelMenuLateral">Panel lateral que contiene el submenú a mostrar u ocultar.</param>
        private void MostrasSubMenu(Panel panelMenuLateral)
        {
            if (panelMenuLateral.Visible)
            {
                OcutarPanelSub();
                MostrarSubMenu();
            }
            else
            {
                panelMenuLateral.Visible = true;
            }
        }


        /// <summary>
        /// Carga un formulario hijo dentro del panel hijo del formulario actual.
        /// </summary>
        /// <param name="FormularioHijo">Formulario hijo que se va a cargar dentro del panel hijo.</param>
        private Form activoForm = null;
        private void PanelHijo(Form FormularioHijo)
        {
            if (activoForm != null)
                activoForm.Close();

            activoForm = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(FormularioHijo);
            panelHijo.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        /// <summary>
        /// Inicia un cronómetro para contar el tiempo transcurrido.
        /// </summary>
        public void IniciarCronometro()
        {
            timerCronormetroSesion = new Timer();
            timerCronormetroSesion.Interval = 1000; // Intervalo de 1 segundo
            timerCronormetroSesion.Tick += timerCronormetroSesion_Tick;
            segundosTranscurridos = 0; // Inicializar el contador de segundos
            timerCronormetroSesion.Start();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Cierra la sesión actual y muestra el formulario de inicio de sesión.
        /// </summary>
        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            Login formInicial = new Login();
            formInicial.Show();
            this.Close();
        }


        /// <summary>
        /// Muestra u oculta el submenú de pacientes.
        /// </summary>
        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            MostrasSubMenu(panelSubMenuPacientes);
        }


        /// <summary>
        /// Muestra u oculta el submenú de citas.
        /// </summary>
        private void buttonCitas_Click(object sender, EventArgs e)
        {
            MostrasSubMenu(panelSubMenuCitas);
        }


        /// <summary>
        /// Muestra u oculta el submenú de finanzas.
        /// </summary>
        private void buttonFinanzas_Click(object sender, EventArgs e)
        {
            MostrasSubMenu(panelSubMenuFinanzas);
        }


        /// <summary>
        /// Muestra u oculta el submenú de configuración.
        /// </summary>
        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            MostrasSubMenu(panelSubMenuConfiguracion);
        }


        /// <summary>
        /// Oculta el submenú y carga el formulario Form1 en el panel hijo.
        /// </summary>
        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            OcutarPanelSub();
            PanelHijo(new Form1());
            //Form1 formularioTabs = new Form1();
            //formularioTabs.Show();
            //this.Hide();
        }

        /// <summary>
        /// Oculta el submenú y carga el formulario FrmBuscarPaciente en el panel hijo.
        /// </summary>
        private void buttonBuscarPacientes_Click(object sender, EventArgs e)
        {
            OcutarPanelSub();
            PanelHijo(new FrmBuscarPaciente());
            //FrmBuscarPaciente formularioTabs = new FrmBuscarPaciente(); 
            //formularioTabs.Show();
            //this.Hide();
        }

        /// <summary>
        /// Oculta el submenú y carga el formulario FrmCitas en el panel hijo.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            OcutarPanelSub();
            PanelHijo(new FrmCitas(connectionString));
        }

        /// <summary>
        /// Oculta el submenú y carga el formulario ConsultarCitas en el panel hijo.
        /// </summary>
        private void buttonBuscarCita_Click(object sender, EventArgs e)
        {
            OcutarPanelSub();
            PanelHijo(new ConsultarCitas());
        }

        /// <summary>
        /// Oculta el submenú y carga el formulario FrmRegistrarRoles en el panel hijo.
        /// </summary>
        private void buttonRegistrarRol_Click(object sender, EventArgs e)
        {
            OcutarPanelSub();
            PanelHijo(new FrmRegistrarRoles());
        }

        /// <summary>
        /// Oculta el submenú y carga el formulario FrmRegistrarUsuarios en el panel hijo.
        /// </summary>
        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            OcutarPanelSub();
            PanelHijo(new FrmRegistrarUsuarios());
        }

        /// <summary>
        /// Carga el nombre de usuario en el label al cargar el formulario PanelPrincipal.
        /// </summary>
        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = "Usuario: " + nombreUsuario;
        }

        /// <summary>
        /// Evento que se ejecuta cada segundo para actualizar el tiempo transcurrido desde el inicio de sesión.
        /// </summary>
        private void timerCronormetroSesion_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;
            // Aquí puedes actualizar algún control en tu formulario con el tiempo transcurrido
            // Por ejemplo, actualizar un Label con el tiempo transcurrido en formato hh:mm:ss
            labelTiempoTranscurrido.Text = TimeSpan.FromSeconds(segundosTranscurridos).ToString(@"hh\:mm\:ss");
        }

        private void buttonPreguntasSecretas_Click(object sender, EventArgs e)
        {

        }

        #endregion



    }
}
