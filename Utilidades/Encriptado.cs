using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pacientesCsharp.Utilidades
{
    internal class Encriptado
    {
        static readonly string clavePrivada = "2025tareadam2025";

        public static string Encriptar(string textocifrar)
        {
            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream();

            //Creamos el flujo de datos con todos los elementos para el encriptado.

            CryptoStream cifradodedatos = new CryptoStream(flujodatosmemoria, encriptador, CryptoStreamMode.Write);

            //Convertimos el texto a cifrar en un array de byte para poder operar
            //en el proceso de cifrado.
            //Cciframos los datos recorriendo el aray de bytes del texto a cifrar
            //desde el primer elemento (0) al último (bytesdeltextoPlano.Length)
            //has culminar el proceso: flushfinalblock()

            byte[] bytesdeltextoPlano = UTF8Encoding.UTF8.GetBytes(textocifrar);
            cifradodedatos.Write(bytesdeltextoPlano, 0, bytesdeltextoPlano.Length);
            cifradodedatos.FlushFinalBlock(); //Fin del proceso de cifrado.

            //Obtenemos los resultados del encriptado almacenándolos en un array byte 
            //y cerramos los flujos : memorystream y crypto stream
            byte[] bytescifrados = flujodatosmemoria.ToArray();

            flujodatosmemoria.Close();
            cifradodedatos.Close();
            //Se devuelve la cadena cifrada convertida a caracteres
            return Convert.ToBase64String(bytescifrados);
        }

        public static string Desencriptar(string textoCifrado)
        {
            //Almacenamos los bytes cifrados apartir de la cadena encriptada y 
            //creamos un array de tipo byte para almacenar los resultados del desencriptado
            byte[] textoCifradoBytes = Convert.FromBase64String(textoCifrado);

            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);
            MemoryStream flujodatosmemoria = new MemoryStream(textoCifradoBytes);
            CryptoStream descifradodedatos = new CryptoStream(flujodatosmemoria, desencriptador, CryptoStreamMode.Read);
            
            StreamReader sr = new StreamReader(descifradodedatos);
            return sr.ReadToEnd();
        }
    }
}
