using System;
using System.Collections.Generic;
using System.Text;

namespace MyProtocolsApp_Allan.Services
{
    public static class APIConnection
    {
        //acá definimos la dirección URL (ya sea una IP o un nombre de dominio) a la que el app
        //debe apuntar. 
        //Por comodidad la ruta URL completa para consumir los recursos del API se hará 
        //en formato "prefijo"+"sufijo"
        //donde el prefijo sera la parte del URL que nunca cambiará y el sufijo será la parte variable
        //(nombre del controlador y sus parámetros) 

        public static string ProductionPrefixURL = "http://192.168.0.169:45457/api/";
        public static string TestingPrefixURL = "http://192.168.0.169:45457/api/";

        public static string ApiKeyName = "Progra6ApiKey";
        public static string ApiKeyValue = "AllanProgra6AsdZxc12345";



    }
}
