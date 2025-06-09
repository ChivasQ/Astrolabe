namespace Astrolabe.Models
{
    /// <summary>
    /// Статичний клас для підсвічування синтаксису фільтрів у RichTextBox.
    /// Виділяє ключові слова, пов'язані з фільтрами, зроблені жирним шрифтом і кольором.
    /// </summary>
    public static class FilterSyntaxHighlighter
    {
        public static void Highlight(RichTextBox box)
        {
            int selectionStart = box.SelectionStart;
            int selectionLength = box.SelectionLength;

            string text = box.Text;
            box.SelectAll();
            box.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            box.SelectionColor = Color.Black;

            string[] keywords = { "distance:", "dist:", "name:", "magnitude:", "mag:", "constellation:", "cons:", "isvisible:", "visible:" };

            foreach (string keyword in keywords)
            {
                int index = 0;
                while ((index = text.IndexOf(keyword, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    box.Select(index, keyword.Length);
                    box.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    box.SelectionColor = Color.Blue;
                    index += keyword.Length;
                }
            }

            box.Select(selectionStart, selectionLength);
        }
    }

}
