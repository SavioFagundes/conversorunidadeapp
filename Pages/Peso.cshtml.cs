using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ConversorUnidadesApp.Pages
{
    public class PesoModel : PageModel
    {
        [BindProperty]
        public double? Valor { get; set; }

        [BindProperty]
        public string DeUnidade { get; set; } = "quilograma";

        [BindProperty]
        public string ParaUnidade { get; set; } = "grama";

        public string? Resultado { get; private set; }

        public List<SelectListItem> Unidades { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "miligrama", Text = "Miligrama" },
            new SelectListItem { Value = "grama", Text = "Grama" },
            new SelectListItem { Value = "quilograma", Text = "Quilograma" },
            new SelectListItem { Value = "onca", Text = "Onça" },
            new SelectListItem { Value = "libra", Text = "Libra" }
        };

        public void OnPost()
        {
            if (Valor == null)
            {
                Resultado = "Por favor, insira um valor para converter.";
                return;
            }

            var fatores = new Dictionary<string, double>
            {
                {"miligrama", 0.001}, {"grama", 1}, {"quilograma", 1000},
                {"onca", 28.3495}, {"libra", 453.592}
            };

            double valorEmGramas = Valor.Value * fatores[DeUnidade];
            double valorConvertido = valorEmGramas / fatores[ParaUnidade];

            Resultado = $"{Valor:N4} {DeUnidade}(s) é igual a {valorConvertido:N4} {ParaUnidade}(s).";
        }
    }
}
