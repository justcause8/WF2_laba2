using System.Text.RegularExpressions;

namespace WinFormsApp2_laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // �������� �������� �� ��������
            first.Text = Properties.Settings.Default.first.ToString();
            second.Text = Properties.Settings.Default.second.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstWord, secondWord;
            try
            {
                firstWord = this.first.Text;
                secondWord = this.second.Text;
            }
            catch (FormatException)
            {
                return;
            }

            //  �������� ��������� �������� � ���������
            Properties.Settings.Default.first = firstWord;
            Properties.Settings.Default.second = secondWord;
            Properties.Settings.Default.Save(); // ��������� ���������� ��������, ����� ��� �������������� ��� ��������� �������

            var outMassage = Logic.Compare(firstWord, secondWord);
            MessageBox.Show(outMassage);
        }

        public class Logic
        {
            public static string Compare(string firstWord, string secondWord)
            {
                string outMessage = "";

                if (CheckInput(firstWord) && CheckInput(secondWord))
                {
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        char letter = firstWord[i];
                        bool foundLetter = false;
                        bool letterChecked = false;

                        for (int k = 0; k < i; k++)
                        {
                            if (firstWord[k] == letter)
                            {
                                letterChecked = true;
                                break;
                            }
                        }

                        if (letterChecked)
                        {
                            continue;
                        }

                        for (int j = 0; j < secondWord.Length; j++)
                        {
                            if (secondWord[j] == letter)
                            {
                                foundLetter = true;
                                break;
                            }
                        }

                        if (foundLetter == true)
                        {
                            outMessage += "�� ";
                        }
                        else
                        {
                            outMessage += "��� ";
                        }
                    }
                }
                else
                {
                    outMessage = "������ �����\n";
                }
                return outMessage;
            }
            static bool CheckInput(string word)
            {
                return Regex.IsMatch(word, @"^[a-zA-Z�-��-�]+$");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� ��� �����. ��� ������ ����� ������� ����� ����������, ������ �� ��� �� ������ �����. " +
                "������������� ����� ������� ����� �� �������������. " +
                "��������, ���� �������� ����� ��������� � ����������, " +
                "�� ��� ���� ������� �� ��� ������� ������ ����: ��� �� �� �� ��� ���.");
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
