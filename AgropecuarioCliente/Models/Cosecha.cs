using System;
using Newtonsoft.Json;

namespace AgropecuarioCliente.Models
{
    public class Cosecha
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("productoId")]
        public string ProductoId { get; set; }

        [JsonProperty("fechaCosecha")]
        public DateTime FechaCosecha { get; set; }

        [JsonProperty("cantidadRecolectada")]
        public int CantidadRecolectada { get; set; }

        [JsonProperty("calidadProducto")]
        public string CalidadProducto { get; set; }

        [JsonProperty("numeroTrabajadores")]
        public int? NumeroTrabajadores { get; set; }

        [JsonProperty("costoManoObra")]
        public double? CostoManoObra { get; set; }

        [JsonProperty("condicionesClimaticas")]
        public string CondicionesClimaticas { get; set; }

        [JsonProperty("estadoCosecha")]
        public string EstadoCosecha { get; set; }

        [JsonProperty("observaciones")]
        public string Observaciones { get; set; }

        public Cosecha()
        {
            FechaCosecha = DateTime.Now;
            EstadoCosecha = "Pendiente";
            CondicionesClimaticas = "Normal";
            CalidadProducto = "Estándar";
        }

        // Métodos de cálculo
        public double CalcularCostoPorKg()
        {
            if (CantidadRecolectada == 0 || CostoManoObra == null) return 0;
            return CostoManoObra.Value / CantidadRecolectada;
        }

        public double CalcularCostoPorTrabajador()
        {
            if (NumeroTrabajadores == null || NumeroTrabajadores == 0 || CostoManoObra == null) return 0;
            return CostoManoObra.Value / NumeroTrabajadores.Value;
        }

        public double CalcularRendimiento()
        {
            if (NumeroTrabajadores == null || NumeroTrabajadores == 0) return 0;
            return (double)CantidadRecolectada / NumeroTrabajadores.Value;
        }

        public override string ToString()
        {
            return $"{Id} - {FechaCosecha:dd/MM/yyyy} - {CantidadRecolectada} kg - {CalidadProducto}";
        }
    }
}