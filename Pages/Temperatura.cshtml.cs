using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ConversorUnidadesApp.Pages
{
    public class TemperaturaModel : PageModel
    {
        [BindProperty]
        public double? Valor { get; set; }

        [BindProperty]
        public string DeUnidade { get; set; } = "celsius";

        [BindProperty]
        public string ParaUnidade { get; set; } = "fahrenheit";

        public string? Resultado { get; private set; }

        public List<SelectListItem> Unidades { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "celsius", Text = "Celsius" },
            new SelectListItem { Value = "fahrenheit", Text = "Fahrenheit" },
            new SelectListItem { Value = "kelvin", Text = "Kelvin" }
        };

        public void OnPost()
        {
            if (Valor == null)
            {
                Resultado = "Por favor, insira um valor para converter.";
                return;
            }

            double valorConvertido = 0;
            double valorEntrada = Valor.Value;

            if (DeUnidade == ParaUnidade)
            {
                valorConvertido = valorEntrada;
            }
            else if (DeUnidade == "celsius")
            {
                if (ParaUnidade == "fahrenheit") valorConvertido = (valorEntrada * 9 / 5) + 32;
                else if (ParaUnidade == "kelvin") valorConvertido = valorEntrada + 273.15;
            }
            else if (DeUnidade == "fahrenheit")
            {
                if (ParaUnidade == "celsius") valorConvertido = (valorEntrada - 32) * 5 / 9;
                else if (ParaUnidade == "kelvin") valorConvertido = (valorEntrada - 32) * 5 / 9 + 273.15;
            }
            else if (DeUnidade == "kelvin")
            {
                if (ParaUnidade == "celsius") valorConvertido = valorEntrada - 273.15;
                else if (ParaUnidade == "fahrenheit") valorConvertido = (valorEntrada - 273.15) * 9 / 5 + 32;
            }

            Resultado = $"{valorEntrada:N2} graus {DeUnidade} é igual a {valorConvertido:N2} graus {ParaUnidade}.";
        }
    }
}
