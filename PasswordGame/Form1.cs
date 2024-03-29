using Entities;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PasswordGame
{
    public partial class PasswordGame : Form
    {
        private readonly List<Question> _questions = [];

        public PasswordGame()
        {
            InitializeComponent();
            PopulateQuestionList();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            progressBarPassword.Value = 0;
            int inputLength = textBoxPassword.Text.Length;
            labelCount.Text = inputLength.ToString();

            string[] patterns =
            {
                @"^.{5,}$",
                @"^.*[0-9].*$",
                @"^.*[A-Z].*$",
                @"^.*\W+.*$",
                @"^automatos.*$",
                @"^.*(january|february|march|april|may|june|july|august|september|october|november|december).*$",
                @"^.*(I|V|X|L|C|D|M).*$",
                @"^.*(Ac|Al|Am|Sb|Ar|As|At|Ba|Bk|Be|Bi|Bh|Br|Cd|Ca|Cf|Ce|Cs|Cl|Cr|Co|Cu|Cm|Ds|Db|Dy|Es|Er|Eu|Fm|Fr|Gd|Ga|Ge|Au|Hf|Hs|He|Ho|In|Ir|Fe|Kr|La|Lr|Pb|Li|Lu|Mg|Mn|Mt|Md|Hg|Mo|Nd|Ne|Np|Ni|Nb|No|Os|Pd|Pt|Pu|Po|Pr|Pm|Pa|Ra|Rn|Re|Rh|Rg|Rb|Ru|Rf|Sm|Sc|Sg|Se|Si|Ag|Na|Sr|Ta|Tc|Te|Tb|Tl|Th|Tm|Sn|Ti|Xe|Yb|Zn|Zr).*$",
                @"^.*Brazil.*$",
                $@"^.*{LeapYears()}.*$",
                $@"^.*{inputLength}.*$",
                $@"^.*{DateTime.Now:d}.*$"
            };

            foreach (string pattern in patterns)
            {
                if (Regex.IsMatch(textBoxPassword.Text, pattern))
                {
                    progressBarPassword.Value++;
                }
            }
        }

        private void PopulateQuestionList()
        {
            string[] questions = ["Rule 1 - Your password must be at least 5 characters.",
                                  "Rule 2 – Your password must include a number.",
                                  "Rule 3 – Your password must include an uppercase letter.",
                                  "Rule 4 – Your password must include a special character.",
                                  "Rule 5 - Your password must start with \"automatos\".",
                                  "Rule 6 – Your password must include a month of the year in lowercase.",
                                  "Rule 7 – Your password must include a roman numeral.",
                                  "Rule 8 – Your password must include a two letter symbol from the periodic.",
                                  "Rule 9 – Your password must include the country of football and carnival.",
                                  "Rule 10 – Your password must include a leap year that has already passed.",
                                  "Rule 11 – Your password must include the length of your password.",
                                  "Rule 12 – Your password must include the current date (dd/MM/yyyy)."
            ];

            progressBarPassword.Maximum = questions.Length;


            foreach (string question in questions)
            {
                listBoxRules.Items.Add(question);
                _questions.Add(new(question));
            }
        }

        private static string LeapYears()
        {
            List<string> leapYears = [];

            for (int FirstLeapYear = 1900; FirstLeapYear < DateTime.Now.Year; FirstLeapYear += 4)
            {
                leapYears.Add(FirstLeapYear.ToString());
            }

            string regexPattern = string.Join("|", leapYears.Select(year => year.ToString()));

            return regexPattern;
        }
    }
}
