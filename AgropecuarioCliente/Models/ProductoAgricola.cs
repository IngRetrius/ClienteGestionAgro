using System;
using Newtonsoft.Json;

namespace AgropecuarioCliente.Models
{
    public class ProductoAgricola
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("hectareasCultivadas")]
        public double HectareasCultivadas { get; set; }

        [JsonProperty("cantidadProducida")]
        public int CantidadProducida { get; set; }

        [JsonProperty("fechaProduccion")]
        public DateTime FechaProduccion { get; set; }

        [JsonProperty("tipoCultivo")]
        public string TipoCultivo { get; set; }

        [JsonProperty("precioVenta")]
        public double PrecioVenta { get; set; }

        [JsonProperty("costoProduccion")]
        public double CostoProduccion { get; set; }

        [JsonProperty("rendimientoPorHa")]
        public double? RendimientoPorHa { get; set; }

        [JsonProperty("temporada")]
        public string Temporada { get; set; }

        [JsonProperty("tipoSuelo")]
        public string TipoSuelo { get; set; }

        [JsonProperty("codigoFinca")]
        public string CodigoFinca { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nombre} ({TipoCultivo})";
        }
    }
}