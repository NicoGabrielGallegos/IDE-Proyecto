using Newtonsoft.Json;
using Servicios.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public async static Task<IEnumerable<Usuario>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7187/api/Usuario/");
            var data = JsonConvert.DeserializeObject<List<Usuario>>(response);
            return data;
        }

        public async static Task<Usuario> GetByDNI(int DNI)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7187/api/Usuario/" + DNI);
            var data = JsonConvert.DeserializeObject<Usuario>(response);
            return data;
        }

        public async static Task<Boolean> Delete(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7187/api/Usuario/" + usuario.DNI);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Add(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7187/api/Usuario", usuario);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Update(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7187/api/Usuario" + usuario.DNI, usuario);
            return response.IsSuccessStatusCode;
        }
    }
}
