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
            Regex pattern = new Regex("((?<=hex:)|(?<=hex\\(\\d\\):))[a-z0-9\\,]*");
            Regex white_space = new Regex("\\s+");

            string source = Source_TextBox.Text.Replace("\\", string.Empty).Replace("\n", string.Empty);
            source = white_space.Replace(source, string.Empty);

            return pattern.Matches(source);
        }

        private void ASCIIConvert_Button_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            //Match multiple values
            MatchCollection matches = GetMatches();

            foreach (Match match in matches)
            {
                string hex_string = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hex_string);
                string result = Encoding.ASCII.GetString(bytes);

                if (result.Contains("\0"))
                {
                    Regex pattern = new Regex("^b(\\0)*");
                    result = pattern.Replace(result, string.Empty);
                }

                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }

        private void UTF16Convert_Button_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            //Match multiple values
            MatchCollection matches = GetMatches();

            foreach (Match match in matches)
            {
                string hex_string = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hex_string);
                string result = Encoding.Unicode.GetString(bytes);

                //Remove null-terminated characters
                if (result.EndsWith("\0"))
                {
                    Regex pattern = new Regex("\\0*");
                    result = pattern.Replace(result, string.Empty);
                }

                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }

        private void Latin1_Convert_Button_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            //Match multiple values
            MatchCollection matches = GetMatches();

            foreach (Match match in matches)
            {
                string hex_string = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hex_string);
                string result = Encoding.Latin1.GetString(bytes);

                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }

        private void Convert_S256H_Button_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            //Match multiple values
            MatchCollection matches = GetMatches();

            foreach (Match match in matches)
            {
                string hex_string = match.Value.Replace(",", string.Empty);
                byte[] bytes = Convert.FromHexString(hex_string);
                string result = Convert.ToBase64String(bytes);

                builder.AppendLine(hex_string.ToUpper());
                builder.AppendLine(result);
            }

            Target_TextBox.Text = builder.ToString();
        }
    }
}