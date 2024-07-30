using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Tarea_1
{
    public partial class CHAT : Form
    {

        public IPAddress localIpAddress { get; set; }
        public int puertoEscucha { get; set; }

        public CHAT(int puertoEntrante)
        {
            puertoEscucha = puertoEntrante;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Variable del numero ingresado por el usuario en la entrada numerica
                var puertoObjetivo = (int)puertoDestino.Value;

                // Toma el texto del mensaje y limpia la caja de texto
                string mensaje = (@$"De: puerto {puertoEscucha}
{mensajeEnvio.Text}
");
                byte[] mensajeFinal = Encoding.ASCII.GetBytes(mensaje);  //Transforma el mensaje a bytes
                mensajeEnvio.Text = "";  //Limpia la caja de texto

                // Dirección objetivo del mensaje
                IPEndPoint ipEndPoint = new IPEndPoint(localIpAddress, puertoObjetivo);

                // Crear socket
                using Socket socket = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Se conecta al puerto destino
                await socket.ConnectAsync(ipEndPoint);

                // Envía el mensaje
                await socket.SendAsync(new ArraySegment<byte>(mensajeFinal), SocketFlags.None);
            }
            //Mensaje de error de puerto
            catch (SocketException ex)
            {
                MessageBox.Show($"Error al enviar el mensaje: {ex.Message}  Intente cambiar de puerto", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Mensaje de error desconocido
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void escucharMensajes()
        {
            
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mensajesRecibidos_TextChanged(object sender, EventArgs e)
        {

        }

        public void CHAT_Load(object sender, EventArgs e)
        {
            Listener();
        }

        public async void Listener()
        {
            var hostName = Dns.GetHostName();   //Busca el nombre del host local
            IPHostEntry localhost = await Dns.GetHostEntryAsync(hostName);  //Devuelve una matriz con direcciones y alias
            //Agarra el primer elemento de la matriz que sea IP, sino devuelve null
            localIpAddress = localhost.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

            //Verifico tener un IPV4 correcta
            if (localIpAddress == null)
            {
                MessageBox.Show("No se encontró una dirección IPv4 adecuada.");
                return;
            }

            IPEndPoint ipEndPoint = new(localIpAddress, puertoEscucha);  //Creo el endPoint para el listener
            using Socket listener = new(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);  //Le asigno el socket al listener

            listener.Bind(ipEndPoint);  //Le digo al listener donde escuchar
            listener.Listen(100);  //Lo pongo a escuchar


            while (true)
            {
                Socket handler = await listener.AcceptAsync(); //Espero una nueva conexion entrante y la asigna a handler

                _ = Task.Run(async () =>  //Esto ejecuta las tareas en un nuevo hilo de manera asincronica
                {
                    byte[] buffer = new byte[1024];  //buffer de bytes para almacenar los datos recibidos
                    int bytesRec;  //Futuro numero de bytes recibidos


                    //Este while almacena los datos recibidos en buffer y el numero total en bytesRec
                    while ((bytesRec = await handler.ReceiveAsync(buffer, SocketFlags.None)) > 0)
                    {
                        string mensaje = Encoding.ASCII.GetString(buffer, 0, bytesRec);  //Convierte los bytes en cadena de texto

                        //Hcameos invoke para modificar el cuadro de texto de la UI en el hilo principal
                        Invoke(new Action(() =>
                        {
                            mensajesRecibidos.Text += mensaje + Environment.NewLine;  //Sumo el mensaje al cuadro de texto
                        }));
                    }

                    //Cierre de conexiones
                    handler.Shutdown(SocketShutdown.Both);  
                    handler.Close();
                });
            }
        }
    }
}
