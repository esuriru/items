using System.Text;

namespace Esuriru.Items.Utility.ExtensionMethods
{
    public static class StringExtensionMethods
    {
        public static string ToSentence(this string text, bool preserveAcronyms)
        {
            // Return empty string when the string is invalid for conversion
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            StringBuilder newTextBuilder = new(text.Length * 2);
            newTextBuilder.Append(text[0]);

            for (int i = 1; i < text.Length; ++i)
            {
                if (char.IsUpper(text[i]))
                {
                    if ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) && 
                        i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                    {
                        newTextBuilder.Append(' ');
                    }
                }
                newTextBuilder.Append(text[i]);
            }
            return newTextBuilder.ToString();
        }
    }
}