using Newtonsoft.Json;
using Servicios.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PerfilNegocio
    {
        public async static Task<IEnumerable<Perfil>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7187/api/Perfil/");
            var data = JsonConvert.DeserializeObject<List<Perfil>>(response);
            return data;
        }

        public async static Task<Perfil> GetByIdPerfil(int IdPerfil)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7187/api/Perfil/" + IdPerfil);
            var data = JsonConvert.DeserializeObject<Perfil>(response);
            return data;
        }

        public async static Task<Perfil> GetByLegajo(int Legajo)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7187/api/Perfil/legajo/" + Legajo);
            var data = JsonConvert.DeserializeObject<Perfil>(response);
            return data;
        }

        public async static Task<IEnumerable<Perfil>> GetByDNIUsuario(int DNI)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7187/api/Perfil/dni/" + DNI);
            var data = JsonConvert.DeserializeObject<List<Perfil>>(response);
            return data;
        }

        public async static Task<IEnumerable<object>> GetDataGridViewFormattedByDNIUsuario(int DNI)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7187/api/Perfil/dataGridFormat/" + DNI);
            var data = JsonConvert.DeserializeObject<List<object>>(response);
            return data;
        }

        public async static Task<Boolean> Add(Perfil perfil)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7187/api/Perfil/", perfil);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Delete(Perfil perfil)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7187/api/Perfil/" + perfil.IdPerfil);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Update(Perfil perfil)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7187/api/Perfil/" + perfil.IdPerfil, perfil);
            return response.IsSuccessStatusCode;
        }
    }
}
