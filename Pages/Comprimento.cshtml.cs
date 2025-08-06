using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConversorUnidadesApp.Pages
{
    public class ComprimentoModel : PageModel
    {
        [BindProperty]
        public double? Valor { get; set; }

        [BindProperty]
        public string DeUnidade { get; set; } = "metro";

        [BindProperty]
        public string ParaUnidade { get; set; } = "centimetro";

        public string? Resultado { get; private set; }

        public List<SelectListItem> Unidades { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "milimetro", Text = "Milímetro" },
            new SelectListItem { Value = "centimetro", Text = "Centímetro" },
            new SelectListItem { Value = "metro", Text = "Metro" },
            new SelectListItem { Value = "quilometro", Text = "Quilômetro" },
            new SelectListItem { Value = "polegada", Text = "Polegada" },
            new SelectListItem { Value = "pe", Text = "Pé" },
            new SelectListItem { Value = "jarda", Text = "Jarda" },
            new SelectListItem { Value = "milha", Text = "Milha" }
        };

        public void OnGet()
        {
            // Método executado quando a página é carregada pela primeira vez.
        }

        public void OnPost()
        {
            if (Valor == null)
            {
                Resultado = "Por favor, insira um valor para converter.";
                return;
            }

            // Fatores de conversão para a unidade base (metro)
            var fatores = new Dictionary<string, double>
            {
                {"milimetro", 0.001}, {"centimetro", 0.01}, {"metro", 1},
                {"quilometro", 1000}, {"polegada", 0.0254}, {"pe", 0.3048},
                {"jarda", 0.9144}, {"milha", 1609.34}
            };

            // 1. Converte o valor de entrada para a unidade base (metros)
            double valorEmMetros = Valor.Value * fatores[DeUnidade];

            // 2. Converte da unidade base (metros) para a unidade de destino
            double valorConvertido = valorEmMetros / fatores[ParaUnidade];

            Resultado = $"{Valor:N4} {DeUnidade}(s) é igual a {valorConvertido:N4} {ParaUnidade}(s).";
        }
    }
}
