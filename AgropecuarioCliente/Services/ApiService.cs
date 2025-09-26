using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AgropecuarioCliente.Models;
using Newtonsoft.Json;

namespace AgropecuarioCliente.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:8081/api/productos";

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<List<ProductoAgricola>> ObtenerTodosAsync()
        {
            try
            {
                string response = await _httpClient.GetStringAsync(BaseUrl);
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoAgricola>>>(response);
                return apiResponse.Data ?? new List<ProductoAgricola>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener productos: {ex.Message}");
            }
        }

        public async Task<ProductoAgricola> ObtenerPorIdAsync(string id)
        {
            try
            {
                string response = await _httpClient.GetStringAsync($"{BaseUrl}/{id}");
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ProductoAgricola>>(response);
                return apiResponse.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener producto: {ex.Message}");
            }
        }

        public async Task<ProductoAgricola> CrearAsync(ProductoAgricola producto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(producto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(BaseUrl, content);
                string responseBody = await response.Content.ReadAsStringAsync();

                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ProductoAgricola>>(responseBody);
                return apiResponse.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear producto: {ex.Message}");
            }
        }

        public async Task<ProductoAgricola> ActualizarAsync(string id, ProductoAgricola producto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(producto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PutAsync($"{BaseUrl}/{id}", content);
                string responseBody = await response.Content.ReadAsStringAsync();

                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ProductoAgricola>>(responseBody);
                return apiResponse.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar producto: {ex.Message}");
            }
        }

        public async Task<bool> EliminarAsync(string id)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar producto: {ex.Message}");
            }
        }

        public async Task<List<ProductoAgricola>> BuscarPorTipoAsync(string tipo)
        {
            try
            {
                string response = await _httpClient.GetStringAsync($"{BaseUrl}?tipo={tipo}");
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoAgricola>>>(response);
                return apiResponse.Data ?? new List<ProductoAgricola>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar por tipo: {ex.Message}");
            }
        }
    }
}