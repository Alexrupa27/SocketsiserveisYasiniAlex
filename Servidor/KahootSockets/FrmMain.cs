using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using FUMADADEBOLAS.CLASSES;

namespace KahootSockets
{
    public partial class FrmMain: Form
    {
        private ClEscoltar escoltar;

        List<string> colores = new List<string> {"LightBlue", "Red", "Green", "Yellow", "Orange", "Purple", "Pink", "Cyan", "Magenta", "Black", "White", "Gray", "Brown", "Lime", "Blue"};
        List<string> Usuarios = new List<string>();
        Random R = new Random();

        public FrmMain()
        {
            InitializeComponent();
            escoltar = new ClEscoltar(this);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CambiarColor();
            posicionar();
            MostrarIPs();
            
        }

        private void posicionar()
        {
            //boton salir
            btSortir.Location = new Point(this.Width - btSortir.Width - 30, btSortir.Height - 30);
            //Titulo
            lbTitol.Location = new Point(this.Width / 2 - lbTitol.Width / 2, lbTitol.Height - 30);
            //IP
            lbIpText.Location = new Point(this.Width / 4 + 100, lbIpText.Height + lbTitol.Height + 90);
            lbIp.Location = new Point(this.Width / 4 + 100, lbIpText.Height + lbTitol.Height + lbIpText.Height + 90);
            //Puerto
            lbTextPuerto.Location = new Point(this.Width / 4 * 2 + 100, lbIpText.Height + lbTitol.Height + 90);
            lbPort.Location = new Point(this.Width / 4 * 2 + 100, lbIpText.Height + lbTitol.Height + lbIpText.Height + 90);
            //botonIniciar
            btStart.Location = new Point(this.Width / 2 - btStart.Width / 2, btStart.Height + lbTitol.Height +lbPort.Height + lbPort.Height + 30);
        }

        private void MostrarIPs()
        {
            string resultado = "";

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 &&
                    networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties properties = networkInterface.GetIPProperties();

                    foreach (UnicastIPAddressInformation ipAddress in properties.UnicastAddresses)
                    {
                        if (ipAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            resultado += $"{ipAddress.Address}";
                        }
                    }
                }
            }

            lbIp.Text = string.IsNullOrEmpty(resultado) ? "No hay conexión Wi-Fi activa." : resultado;
        }

        private void btSortir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas continuar?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void CambiarColor()
        {
            int indice = R.Next(colores.Count);
            string colorSeleccionado = colores[indice];
            lbTitol.ForeColor = Color.FromName(colorSeleccionado); 
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (escoltar != null)
            {
                escoltar.tancarXafarder();
            }
        }
        public void ActualizarLabelPrueba(string mensaje)
        {
            lbPrueba.Text = mensaje;
            Usuarios.Add(mensaje);
        }
    }
}
