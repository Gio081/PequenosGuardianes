using System;

namespace PequenosGuardianes
{
    public static class RegistroSesion
    {
        // --- DATOS PERSONALES ---
        public static string NombreCompleto { get; set; } = "";
        public static string Domicilio { get; set; } = "";
        public static string Edad { get; set; } = "";
        public static string FechaNacimiento { get; set; } = "";
        public static string Genero { get; set; } = "";



        // Contadores
        public static int AccionesBasura { get; set; } = 0;
        public static int AccionesReciclaje { get; set; } = 0;
        public static int AccionesAgua { get; set; } = 0;
    }
}