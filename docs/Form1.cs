using Microsoft.VisualBasic;
using System.Text;

namespace Conversor
{            /// <summary>
             /// Formulario principal que gestiona la selección, procesamiento y conversión simulada de audio a texto.
             /// </summary>
    public partial class Form1 : Form
    {   /// <summary>
        /// Ruta del archivo seleccionado por el usuario.
        /// </summary>
        private string rutaArchivoActual = "";

        /// <summary>
        /// Texto extraído del archivo de audio.
        /// </summary>
        private string textoExtraido = "";

        /// <summary>
        /// Texto resultante de la encriptación en Base64.
        /// </summary>
        private string textoEncriptado = "";

        /// <summary>
        ///Texto simulado que representa la conversión del audio.
        /// </summary>
        private const string TEXTO_SIMULADO = " Que sin tu amor, baby, me desaparezco\r\nSin tu amor, baby, soy igual al resto\r\nSoy de amor, soy de amor, soy de amor";
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public Form1()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Encripta el texto extraído mediante codificación Base64 con un prefijo simulando Fernet.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textoExtraido))
            {
                MessageBox.Show("Primero debe convertir el audio a texto.", "Acción Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Convertimos el texto a bytes UTF8
                byte[] textoBytes = Encoding.UTF8.GetBytes(textoExtraido);

                // Convertimos los bytes a Base64 (Estándar de codificación)
                string base64 = Convert.ToBase64String(textoBytes);

                // Añadimos un prefijo "gAAAAAB" para simular visualmente el cifrado Fernet de la tarea anterior
                textoEncriptado = "gAAAAAB" + base64;

                txtTextoEncriptado.Text = textoEncriptado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encriptar: " + ex.Message, "Error Criptográfico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Abre un archivo de audio y muestra sus metadatos y bytes en formato hexadecimal.
        /// </summary>
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Audio|*.mp3;*.wav;*.m4a;*.ogg|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar archivo de audio";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoActual = openFileDialog.FileName;
                lblArchivoSeleccionado.Text = Path.GetFileName(rutaArchivoActual);

                // Procesar la información del archivo y mostrar bytes (Código Máquina)
                ProcesarArchivoBinario(rutaArchivoActual);
            }
        }
        /// <summary>
        /// Lee metadatos y primeros 600 bytes del archivo y los muestra en formato HEX.
        /// </summary>
        /// <param name="ruta">Ruta del archivo a procesar.</param>
        private void ProcesarArchivoBinario(string ruta)
        {
            try
            {
                FileInfo info = new FileInfo(ruta);

                
                string metaInfo = $"Nombre: {info.Name}\r\n" +
                                  $"Formato: {info.Extension}\r\n" +
                                  $"Tamaño (KB): {(info.Length / 1024.0):F2}\r\n" +
                                  $"Creación: {info.CreationTime}";

             
                byte[] bytes = new byte[600];
                using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                   
                    fs.Read(bytes, 0, bytes.Length);
                }

            
                StringBuilder hexBuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    
                    hexBuilder.AppendFormat("{0:X2} ", bytes[i]);

                    if ((i + 1) % 16 == 0)
                    {
                        hexBuilder.AppendLine();
                    }
                }

                string contenidoComoTexto = hexBuilder.ToString().Trim();

            
                txtInfoArchivo.Text = metaInfo + "\r\n\r\n=== Formato de Almacenamiento (Código Máquina - HEX) ===\r\n\r\n" + contenidoComoTexto;
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Simula la conversión del archivo de audio a texto.
        /// </summary>
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoActual))
            {
                MessageBox.Show("Por favor, seleccione un archivo de audio primero.", "Archivo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtTextoExtraido.Text = "Procesando audio, simulando IA...";
            Application.DoEvents(); 

            
            System.Threading.Thread.Sleep(1000);

            textoExtraido = TEXTO_SIMULADO;
            txtTextoExtraido.Text = textoExtraido;
        }


        /// <summary>
        /// Desencripta el texto previamente encriptado mediante Base64.
        /// </summary>
        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTextoEncriptado.Text))
            {
                MessageBox.Show("No hay texto encriptado para desencriptar.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cifradoInput = txtTextoEncriptado.Text;

                if (cifradoInput.StartsWith("gAAAAAB"))
                {
                    cifradoInput = cifradoInput.Substring(7);
                }

                byte[] decodedBytes = Convert.FromBase64String(cifradoInput);
                string textoOriginal = Encoding.UTF8.GetString(decodedBytes);

                MessageBox.Show("Texto Desencriptado Exitosamente:\n\n" + textoOriginal, "Resultado de Desencriptación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("El texto no tiene un formato Base64 válido para desencriptar.", "Error de Desencriptación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Guarda el texto extraído en un archivo .txt.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textoExtraido))
            {
                MessageBox.Show("No hay texto extraído para guardar.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Texto|*.txt";
            saveFileDialog.FileName = "conversion_audio.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textoExtraido);
                MessageBox.Show("Archivo guardado correctamente en:\n" + saveFileDialog.FileName, "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTextoExtraido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

