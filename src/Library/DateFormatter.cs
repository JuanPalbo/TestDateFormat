using System.Globalization;

namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (date == string.Empty)
        {
            return "Se ha ingresado una cadena vacía";
        }

        if (date.Contains("/"))
        {
            string[] SplitDate = date.Split('/');
            if (SplitDate.Length == 3)
            {
                if (Int16.Parse(SplitDate[0]) > 0 && Int16.Parse(SplitDate[0]) < 13 && Int16.Parse(SplitDate[1]) > 0 && Int16.Parse(SplitDate[1]) < 32 && Int16.Parse(SplitDate[2]) > 0 && Int16.Parse(SplitDate[2]) < 10000)
                {
                    return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
                }
            }
        }
        return "Formato incorrecto";
    }
}
