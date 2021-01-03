namespace NarackaNaPica.Extensions
{
    public static class Helper
    {
        public static int GetNumberFromText(string text)
        {
            var flag = int.TryParse(text, out var value);
            return flag == true ? value : 0;
        }
    }
}