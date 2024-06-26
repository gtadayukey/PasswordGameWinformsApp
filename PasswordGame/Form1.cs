using System.Data;
using System.Text.RegularExpressions;

namespace PasswordGame
{
    public partial class PasswordGame : Form
    {
        public PasswordGame()
        {
            InitializeComponent();
            PopulateQuestionList();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            progressBarPassword.Value = 0;
            labelCount.Text = textBoxPassword.Text.Length.ToString();
            ValidatePattern();

            if (progressBarPassword.Value == progressBarPassword.Maximum)
            {
                WinScreen();
            }
        }

        private void ValidatePattern()
        {
            string[] patterns =
            {
                @"^.*[a-z].*$",
                @"^.{5,}$",
                @"^.*[0-9].*$",
                @"^.*[A-Z].*$",
                @"^.*\W+.*$",
                @"^automatos.*$",
                @"^.*(january|february|march|april|may|june|july|august|september|october|november|december).*$",
                @"^.*(I|V|X|L|C|D|M).*$",
                @"^.*(Ac|Al|Am|Sb|Ar|As|At|Ba|Bk|Be|Bi|Bh|Br|Cd|Ca|Cf|Ce|Cs|Cl|Cr|Co|Cu|Cm|Ds|Db|Dy|Es|Er|Eu|Fm|Fr|Gd|Ga|Ge|Au|Hf|Hs|He|Ho|In|Ir|Fe|Kr|La|Lr|Pb|Li|Lu|Mg|Mn|Mt|Md|Hg|Mo|Nd|Ne|Np|Ni|Nb|No|Os|Pd|Pt|Pu|Po|Pr|Pm|Pa|Ra|Rn|Re|Rh|Rg|Rb|Ru|Rf|Sm|Sc|Sg|Se|Si|Ag|Na|Sr|Ta|Tc|Te|Tb|Tl|Th|Tm|Sn|Ti|Xe|Yb|Zn|Zr).*$",
                @"^.*(Brazil|brazil).*$",
                $@"^.*({LeapYears()}).*$",
                $@"^.*{textBoxPassword.Text.Length}.*$",
                $@"^.*{DateTime.Now:d}.*$",
                @"^.*:\)$"
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
            string[] questions = 
            [   
                "Rule 1 - Your password must include an lowercase letter.",
                "Rule 2 - Your password must be at least 5 characters.",
                "Rule 3 � Your password must include a number.",
                "Rule 4 � Your password must include an uppercase letter.",
                "Rule 5 � Your password must include a special character.",
                "Rule 6 - Your password must start with \"automatos\".",
                "Rule 7 � Your password must include a month of the year in lowercase.",
                "Rule 8 � Your password must include a roman numeral.",
                "Rule 9 � Your password must include a two letter symbol from the periodic.",
                "Rule 10 � Your password must include the country of football and carnival.",
                "Rule 11 � Your password must include a leap year before nowadays.",
                "Rule 12 � Your password must include the length of your password.",
                "Rule 13 � Your password must include the current date (dd/MM/yyyy).",
                "Rule 14 - Your password must finish with \":)\" happy face.",
            ];

            progressBarPassword.Maximum = questions.Length;


            foreach (string question in questions)
            {
                listBoxRules.Items.Add(question);
            }
        }

        private void WinScreen()
        {
            listBoxRules.Visible = false;
            listBoxRules.Enabled = false;
            textBoxPassword.Visible = false;
            textBoxPassword.Enabled = false;
            progressBarPassword.Visible = false;
            progressBarPassword.Enabled = false;
            labelCount.Visible = false;
            labelCount.Enabled = false;
            labelProgress.Visible = false;
            labelProgress.Enabled = false;
            labelPasswordTitle.Visible = false;
            labelPasswordTitle.Enabled = false;
            labelWinner.Enabled = true;
            labelWinner.Visible = true;
            labelWinner.Text = "CONGRATS, YOU WIN THE PASSWORD GAME!";
        }

        private static string LeapYears()
        {
            List<string> leapYears = [];

            for (int FirstLeapYear = 1900; FirstLeapYear < DateTime.Now.Year; FirstLeapYear += 4)
            {
                leapYears.Add(FirstLeapYear.ToString());
            }

            string regexPattern = string.Join("|", leapYears.Select(year => year.ToString()));

            regexPattern = regexPattern.TrimStart('|');

            return regexPattern;
        }
    }
}
