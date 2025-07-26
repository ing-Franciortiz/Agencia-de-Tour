using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_de_tour // <--- ¡ASEGÚRATE QUE ESTE NAMESPACE SEA EL MISMO QUE TUS FORMULARIOS!
{
    public class Tour
    {
        // Propiedades de la clase Tour, según tus requerimientos
        public string Id { get; set; } // Único
        public string Nombre { get; set; }
        public string PaisDestino { get; set; }
        public string Destino { get; set; } // (Generado) Depende el país elegido
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Precio { get; set; }
        public decimal ITBIS { get; set; } // (Calculado) 18%
        public TimeSpan Duracion { get; set; } // (Calculado) Sumando a la fecha y hora del tour la duración del tour según destino elegido.
        public string Estado { get; set; } // (Calculado) basado en fecha y hora. Vigente o Vencida

        // Constructor de la clase Tour
        // Recibe los datos obligatorios para crear un tour
        public Tour(string id, string nombre, string paisDestino, DateTime fecha, TimeSpan hora, decimal precio)
        {
            // Asigna los valores pasados al constructor a las propiedades del objeto
            Id = id;
            Nombre = nombre;
            PaisDestino = paisDestino;
            Fecha = fecha;
            Hora = hora;
            Precio = precio;

            // Llama a los métodos para calcular los campos derivados
            // Necesitas implementar la lógica real para estos métodos
            Destino = CalcularDestino(paisDestino);
            ITBIS = Precio * 0.18m; // Cálculo simple del 18%
            Duracion = CalcularDuracion(fecha, hora, Destino); // Necesita lógica real
            Estado = CalcularEstado(fecha, hora, Duracion); // Necesita lógica real
        }

        // Métodos privados para calcular los campos derivados
        // Implementa tu lógica específica aquí para cada cálculo
        private string CalcularDestino(string paisDestino)
        {
            // Ejemplo de lógica: podrías tener un diccionario que mapee país a destino
            // Por ahora, un ejemplo simple:
            switch (paisDestino.ToLower())
            {
                case "república dominicana":
                    return "Santo Domingo";
                case "méxico":
                    return "Cancún";
                default:
                    return "Destino Genérico";
            }
        }

        private TimeSpan CalcularDuracion(DateTime fecha, TimeSpan hora, string destino)
        {
            // Lógica para la duración, por ejemplo:
            // Si es un tour de un día, 8 horas
            // Si es un tour internacional, 3 días, etc.
            // Para este ejemplo, solo un valor fijo o basado en el destino si lo necesitas
            if (destino.Contains("Internacional"))
            {
                return TimeSpan.FromDays(3);
            }
            else
            {
                return TimeSpan.FromHours(8); // Duración por defecto de 8 horas
            }
        }

        private string CalcularEstado(DateTime fecha, TimeSpan hora, TimeSpan duracion)
        {
            // Calcula la fecha y hora de finalización del tour
            DateTime fechaHoraInicio = fecha.Date.Add(hora);
            DateTime fechaHoraFin = fechaHoraInicio.Add(duracion);

            // Compara con la fecha y hora actual
            if (fechaHoraFin < DateTime.Now)
            {
                return "Vencida";
            }
            else
            {
                return "Vigente";
            }
        }
    }
}
