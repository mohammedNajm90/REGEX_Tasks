namespace RegexTask
{
    public class RegexFunctions
    {
        /// <summary>
        /// Extracts a local-format Iraqi phone number starting with 0790 from the input string.
        /// </summary>
        /// <param name="input">The input string that may contain a phone number.</param>
        /// <returns>
        /// The matched phone number if found; otherwise, an empty string.
        /// If an exception occurs, returns the exception message prefixed with "Exception:".
        /// </returns>
        public static string MatchPhonNumberLocalFormat(string input)
        {
            try
            {
                string pattern = @"0790\d{7}";

                Match match = Regex.Match(input, pattern);

                return match.Value;
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }
    }
}
