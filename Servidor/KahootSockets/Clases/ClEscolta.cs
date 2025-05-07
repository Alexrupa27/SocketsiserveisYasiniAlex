using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static KahootSockets.FrmMain;
using System.Drawing;
using System.Text.Json;
using KahootSockets;

namespace FUMADADEBOLAS.CLASSES
{
    public class ClEscoltar
    {
        const Int32 MAX_BUFFER = 4096;
        TcpListener xafarder; // Es el encargado de escuchar en el puerto
        TcpClient client_xafarder; // Cliente TCP que recibirá los mensajes
        Thread xafarderThread;
        private bool isListening = true; // thread problemas correccion

        delegate void delegatMissatge(String xmsg);

        private FrmMain fmain;
        private int port = 6969;

        public ClEscoltar(FrmMain xfmain)
        {
            fmain = xfmain;

            if (port.ToString().Trim() == "")
            {
                MessageBox.Show("ERROR PUERTO", "TENEMOS UN PROBLEMA...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connectar_el_servidor_que_escolta())
                {
                }
                else
                {
                    MessageBox.Show("No se ha podido conectar al servidor", "TENEMOS UN PROBLEMA...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Boolean connectar_el_servidor_que_escolta()
        {
            Boolean xb = false;
            try
            {
                xafarder = new TcpListener(IPAddress.Any, Int32.Parse(port.ToString().Trim()));
                xafarder.Start();

                xafarderThread = new Thread(Escoltar);
                xafarderThread.IsBackground = true;
                xafarderThread.Start();
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ AL CREAR EL TcpListener", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        private void Escoltar()
        {
            Int32 nBytes = 0;
            string xmsg = string.Empty;
            Byte[] xbuffer = new Byte[MAX_BUFFER];

            try
            {
                while (isListening)  //evitar errores con el thread
                {
                    if (xafarder.Pending()) 
                    {
                        client_xafarder = xafarder.AcceptTcpClient();

                        using (NetworkStream stream = client_xafarder.GetStream())
                        {
                            nBytes = stream.Read(xbuffer, 0, xbuffer.Length);
                            xmsg = Encoding.ASCII.GetString(xbuffer, 0, nBytes);

                            if (!string.IsNullOrEmpty(xmsg))
                            {
                                fmain.Invoke(new delegatMissatge(updText), xmsg);
                            }
                        }

                        Array.Clear(xbuffer, 0, xbuffer.Length);
                    }
                    Thread.Sleep(100); 
                }
            }
            catch (Exception ex)
            {
                if (isListening)  // mas errores del thread
                    MessageBox.Show(ex.Message, "Error en la escucha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updText(String xmsg)
        {
            try
            {
                if (fmain.IsHandleCreated)
                {
                    fmain.Invoke(new delegatMissatge(delegate (string msg)
                    {
                        fmain.ActualizarLabelPrueba(msg);
                    }), xmsg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el Label: {ex.Message}", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void tancarXafarder()
        {
            try
            {
                // ARREGLA BUG DEL ABORT
                isListening = false; 
                if (xafarderThread != null && xafarderThread.IsAlive)
                {
                    xafarderThread.Join(); 
                }

                if (client_xafarder != null && client_xafarder.Connected)
                {
                    client_xafarder.Close();
                }

                if (xafarder != null)
                {
                    xafarder.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
