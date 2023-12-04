using System.Text;
using System.Text.RegularExpressions;

namespace Hex_Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MatchCollection GetMatches()
        {
            var pattern = new Regex("((?<=hex:)|(?<=hex\\(\\d\\):))[a-z0-9\\,]*");
            var whiteSpace = new Regex("\\s+");

            var source = Source_TextBox.Text.Replace("\\", string.Empty).Replace("\n", string.Empty);
            source = whiteSpace.Replace(source, string.Empty);

            return pattern.Matches(source);
        }

        private void ASCIIConvert_Button_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            //Match multiple values
            var matches = GetMatches();

            foreach (Match match in matches)
            {
                var hexString = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hexString);
                var result = Encoding.ASCII.GetString(bytes);

                if (result.Contains("\0"))
                {
                    var pattern = new Regex("^b(\\0)*");
                    result = pattern.Replace(result, string.Empty);
                }

                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }

        private void UTF16Convert_Button_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            //Match multiple values
            var matches = GetMatches();

            foreach (Match match in matches)
            {
                var hexString = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hexString);
                var result = Encoding.Unicode.GetString(bytes);

                //Remove null-terminated characters
                if (result.EndsWith("\0"))
                {
                    var pattern = new Regex("\\0*");
                    result = pattern.Replace(result, string.Empty);
                }

                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }

        private void Latin1_Convert_Button_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            //Match multiple values
            var matches = GetMatches();

            foreach (Match match in matches)
            {
                var hexString = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hexString);
                var result = Encoding.Latin1.GetString(bytes);

                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }

        private void Convert_S256H_Button_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            //Match multiple values
            var matches = GetMatches();

            foreach (Match match in matches)
            {
                var hexString = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hexString);
                var result = Convert.ToBase64String(bytes);

                builder.AppendLine(hexString.ToUpper());
                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }
    }
}