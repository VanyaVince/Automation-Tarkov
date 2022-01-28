namespace Tarkov.Utils
{
    public class ParsingHelper
    {
        public static string ParseProductPrice(string product)
        {
            var removeSpecialCharacter = product.Replace("₽", "");
            var removeLeadingAndTrailingSpaces = removeSpecialCharacter.Trim();

            return removeLeadingAndTrailingSpaces;
        }
    }
}
