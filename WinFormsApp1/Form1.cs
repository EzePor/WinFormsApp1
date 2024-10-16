using System.IO.Ports;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort puertoArduino;
        SerialPort puertoBt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargamos el combobox con los puertos seriales disponibles
            foreach (string nombrePuerto in SerialPort.GetPortNames())
            {
                puertos.Items.Add(nombrePuerto);
                puertosBt.Items.Add(nombrePuerto);
            }
            if (puertos.Items.Count > 0)
            {
                this.puertos.SelectedIndex = 0;
                this.puertosBt.SelectedIndex = 0;
            }

        }

        private void btnPuertos_Click(object sender, EventArgs e)
        {
            string puerto = puertos.Text;
            this.puertoArduino = new SerialPort(puerto);

            //Config puerto Arduino
            puertoArduino.BaudRate = 9600;
            puertoArduino.Parity = Parity.None;
            puertoArduino.StopBits = StopBits.One;
            puertoArduino.DataBits = 8;
            puertoArduino.Handshake = Handshake.None;
            puertoArduino.RtsEnable = false;
            puertoArduino.ReadTimeout = 10000;

            try
            {
                this.puertoArduino.Open();
            }
            catch
            {
                this.estadoPuerto.Text = "Error al abrir el puerto" + puerto;
                return;
            }

            this.estadoPuerto.Text = $"Puerto {puerto} abierto correctamente";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.puertoArduino.Close();
        }

        private void activarSemaforo_Click(object sender, EventArgs e)
        {
            this.puertoArduino.WriteLine("ON");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.puertoArduino.WriteLine("OFF");
            return;
        }

        void mostrarMensaje(string mensaje)
        {
            testdatos.Text = (mensaje);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            String comando;
            comando = puertoBt.ReadLine();
            this.Invoke(this.mostrarMensaje, comando);
            puertoArduino.WriteLine(comando);
        }
        private void AbrirPuertoBlueTooth()
        {
            string puerto = this.puertosBt.Text; //COM
            this.puertoBt = new SerialPort(puerto);

            //Config puerto Arduino
            puertoBt.BaudRate = 9600;
            puertoBt.Parity = Parity.None;
            puertoBt.StopBits = StopBits.One;
            puertoBt.DataBits = 8;
            puertoBt.Handshake = Handshake.None;
            puertoBt.RtsEnable = false;
            puertoBt.ReadTimeout = 10000; //ms

            puertoBt.DataReceived += DataReceivedHandler; //vinculamos el evento de llegada de datos al puerto BT


            try
            {
                this.puertoBt.Open();
            }
            catch
            {
                this.estadoPuertoBt.Text = "Error al abrir el puerto " + puerto;
                return;
            }
            this.estadoPuertoBt.Text = $"Puerto {puerto} abierto correctamente.";

        }

        private void buttonBt_Click(object sender, EventArgs e)
        {
            this.AbrirPuertoBlueTooth();
        }
    }

}
