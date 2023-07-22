using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using pPatronesDiseño.Patrones.Clases;
using pPatronesDiseño.Patrones.Creacionales.Abstract_Factory;

namespace pPatronesDiseño
{
    public partial class fBaseDatos : Form
    {
        Usuario usuario = new Usuario();
        public fBaseDatos()
        {
            InitializeComponent();
        }

        private void fBaseDatos_Load(object sender, EventArgs e)
        {
            LlenarComboBaseDatos();
        }
        private void LlenarComboBaseDatos()
        {
            cboBaseDatos.Items.Add("SQLServer");
            cboBaseDatos.Items.Add("Access");
            cboBaseDatos.Items.Add("SQLite");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos) cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            lblMensaje.Text = bUsuario.Insertar();
            LlenarGrid();
        }
        private void LlenarGrid()
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            string Rpta = bUsuario.ConsultarTodos();
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(Rpta);
            grdUsuarios.DataSource = usuarios;
        }
        private void LeerDatos()
        {
            usuario.Documento = txtDocumento.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Email = txtEmail.Text;
            usuario.Celular = txtCelular.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            string Rpta = bUsuario.Consultar();
            //Se convierte en un objeto usuario para leer la información
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>> (Rpta);
            txtNombre.Text = usuarios[0].Nombre;
            txtEmail.Text = usuarios[0].Email;
            txtCelular.Text = usuarios[0].Celular;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            lblMensaje.Text = bUsuario.Actualizar();
            LlenarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Configuracion.baseDatos = (eBaseDatos)cboBaseDatos.SelectedIndex + 1;
            LeerDatos();
            brokerUsuario bUsuario = new brokerUsuario();
            bUsuario.usuario = usuario;
            lblMensaje.Text = bUsuario.Eliminar();
            LlenarGrid();
        }
    }
}
