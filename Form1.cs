using Microsoft.VisualBasic;
using System.Text;



///@mainpage Conversor de Audio a Texto con Criptografia

/// <summary>0
///@section intro Introduccion

///Este proyecto es una aplicacion educativa desarrollada en C# que combina diversas areas de la

///informatica: procesamiento de archivos, analisis de datos binarios, representacion en formato

///hexadecimal, simulacion de conversion de audio a texto y aplicacion de tecnicas basicas de

///criptografia mediante codificacion Base64. Su proposito principal es demostrar como un sistema

///puede integrar multiples procesos internos mientras mantiene una interfaz grafica intuitiva

///para el usuario.
///Aunque la conversion de audio es simulada, el proyecto refleja fielmente el flujo real que

///tendria un sistema de reconocimiento de voz: carga del archivo, lectura de bytes, análisis,

///interpretacion del contenido y generacion del texto resultante.

///< summary>
///@section justificacion Justificacion del Proyecto

///El proyecto fue desarrollado como parte de un trabajo final academico con el objetivo de poner

///en practica conocimientos sobre:

///Manipulacion de archivos en diferentes formatos.

///Interpretacion de datos binarios y su representacion visual.

///Manejo de cadenas, codificaciones y conversiones.

///Conceptos basicos de criptografia y ofuscacion de datos.

///Desarrollo de aplicaciones graficas utilizando Windows Forms.

///Su diseno refleja un proyecto completo, capaz de gestionar multiples etapas de procesamiento,

///desde la seleccion de un archivo hasta la presentacion del resultado final al usuario.

///<summary>
///@section objetivos Objetivos del Proyecto

///Implementar un sistema funcional que permita seleccionar y analizar archivos de audio.

///Mostrar informacion real del archivo, incluyendo metadatos y bytes en formato hexadecimal.

///Simular la conversion de audio a texto mediante una cadena representativa.

///Demostrar visualmente todo el flujo de procesamiento dentro de una aplicacion de escritorio.

///</summary>
///@section funciones Funcionalidades Principales

///Seleccion de archivos de audio: admite formatos comunes como .mp3, .wav, .m4a, .ogg.

///Lectura de metadatos: nombre, extension, tamano y fecha de creación.

///Lectura binaria: muestra los primeros 600 bytes del archivo en codigo maquina (HEX).

///Conversion simulada: genera texto representativo del contenido de audio.

///Encriptacion: aplica codificacion Base64 con un prefijo estilo Fernet.

///Desencriptacion: decodifica el texto previamente cifrado.

///Guardado de resultados: permite almacenar el texto extraido en un archivo .txt.
   /// </summary>
///<summary>
///@section tecnologias Tecnologias Utilizadas

///Lenguaje: C#

///Entorno: Windows Forms (.NET)

///Codificacion: UTF-8, Base64

///Lectura binaria: FileStream, FileInfo

///Documentacion: Doxygen

///@section estructura Estructura del Proyecto

///Form1  Ventana principal de la aplicacion.

///ProcesarArchivoBinario() Lectura de bytes y construccion del contenido HEX.

///btnConvertir_Click()  Conversion simulada de audio a texto.

///button3_Click()  Encriptacion Base64 con prefijo.

///btnDesencriptar_Click() Decodificacion del texto cifrado.

///btnGuardar_Click() Guardado de resultados.

 ///</summary>









// @file
/// @brief Proyecto final: Conversor de audio a texto y criptografia.
/// @version 1.0
/// @date 05/12/2025
/// @author
/// Maria Ureña - 2024-2260
///
/// Este proyecto simula la conversión de audio a texto, lectura de metadatos
/// en formato binario (HEX) y un sistema de encriptación/desencriptación
/// usando Base64 con prefijo tipo Fernet.

namespace Conversor
{            /// <summary>
             /// Formulario principal que gestiona la seleccion, procesamiento y conversion simulada de audio a texto.
             /// simulada de audio a texto, junto con funciones de encriptacion y lectura binaria.
             /// y lectura binaria de archivos.
             /// </summary>
    public partial class Form1 : Form
    {   /// <summary>
        /// Ruta del archivo seleccionado por el usuario.
        /// </summary>
        private string rutaArchivoActual = "";

        /// <summary>
        /// Texto extraido del archivo de audio.
        /// </summary>
        private string textoExtraido = "";

        /// <summary>
        /// Texto resultante de la encriptacion en Base64.
        /// </summary>
        private string textoEncriptado = "";

        /// <summary>
        ///Texto simulado que representa la conversion del audio.
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
        /// Encripta el texto extraido mediante codificacion Base64 con un prefijo simulando Fernet.
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
               
                byte[] textoBytes = Encoding.UTF8.GetBytes(textoExtraido);

                
                string base64 = Convert.ToBase64String(textoBytes);

                
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
        /// Simula la conversion del archivo de audio a texto.
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
        /// Guarda el texto extraido en un archivo .txt.
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

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

