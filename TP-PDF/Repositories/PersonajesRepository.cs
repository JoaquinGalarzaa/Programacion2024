using Ejercicios_Prueba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Prueba.Repositories
{
    public class PersonajesRepository
    {
        string urlApi = "https://gameofthrones-b87d.restdb.io/rest/personajes";

        HttpClient client = new HttpClient();

        public PersonajesRepository()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "7ec98e3aa87bd9a3a27a3db8b88f77186a0ea");
        }

        public async Task<ObservableCollection<Personaje>?> ObtenerPersonajesAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Personaje>>(response);
        }
        public async Task<Personaje?> AgregarAsync(string nombre_completo, int edad, string alias, string foto_url, string emblema_url)
        {
            //creamos un objeto del tipo Nota con los parámetros que llegan
            Personaje personaje = new Personaje()
            {

                Nombre_completo = nombre_completo,
                Edad = edad,
                Alias = alias,
                Foto_url = foto_url,
                Emblema_url = emblema_url
               
            };


            
            

            var response = await client.PostAsync(urlApi,
                new StringContent(
                    JsonConvert.SerializeObject(personaje),
                    Encoding.UTF8, "application/json"));

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Personaje>(
                await response.Content.ReadAsStringAsync());
        }
        public async Task<Personaje?> ActualizarAsync(string nombre_completo, int edad, string alias, string foto_url, string emblema_url, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Personaje personaje = new Personaje()
            {

                Nombre_completo = nombre_completo,
                Edad = edad,
                Alias = alias,
                Foto_url = foto_url,
                Emblema_url=emblema_url,
                
            };

            //enviamos por POST el objeto que creamos a la URL de la API
            var personajejson = new StringContent(

                  JsonConvert.SerializeObject(personaje),
                  Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, personajejson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Personaje>(
                await response.Content.ReadAsStringAsync());
        }
        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
        public async Task<Personaje?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Personaje>(response);
        }
    }

}