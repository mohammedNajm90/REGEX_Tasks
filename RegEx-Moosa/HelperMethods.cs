using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEx_Moosa
{
    class HelperMethods
    {
        public static void SafetyCheck (String word)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(word))
                    throw new ArgumentNullException(nameof(word), "Input is null or whitespace.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
