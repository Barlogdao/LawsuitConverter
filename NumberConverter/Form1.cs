using System;
using System.Text;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        static string ConvertToText(int number)
        {
            int[] array_int = new int[4];
            string[,] array_string = new string[4, 3] {
            { " миллиард", " миллиарда", " миллиардов" },
            { " миллион", " миллиона", " миллионов" },
            { " тысяча", " тысячи", " тысяч" },
            { "", "", "" }
        };

            array_int[0] = (number - (number % 1000000000)) / 1000000000;
            array_int[1] = ((number % 1000000000) - (number % 1000000)) / 1000000;
            array_int[2] = ((number % 1000000) - (number % 1000)) / 1000;
            array_int[3] = number % 1000;

            StringBuilder result = new StringBuilder();

 
            if (number == 0) result.Append(" ноль");
            else for (int i = 0; i < 4; i++)
                {
                    if (array_int[i] != 0)
                    {
                        if (((array_int[i] - (array_int[i] % 100)) / 100) != 0)
                            switch (((array_int[i] - (array_int[i] % 100)) / 100))
                            {
                                case 1: result.Append(" сто"); break;
                                case 2: result.Append(" двести"); break;
                                case 3: result.Append(" триста"); break;
                                case 4: result.Append(" четыреста"); break;
                                case 5: result.Append(" пятьсот"); break;
                                case 6: result.Append(" шестьсот"); break;
                                case 7: result.Append(" семьсот"); break;
                                case 8: result.Append(" восемьсот"); break;
                                case 9: result.Append(" девятьсот"); break;
                            }
                        if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)
                        {
                            switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)
                            {
                                case 2: result.Append(" двадцать"); break;
                                case 3: result.Append(" тридцать"); break;
                                case 4: result.Append(" сорок"); break;
                                case 5: result.Append(" пятьдесят"); break;
                                case 6: result.Append(" шестьдесят"); break;
                                case 7: result.Append(" семьдесят"); break;
                                case 8: result.Append(" восемьдесят"); break;
                                case 9: result.Append(" девяносто"); break;
                            }
                            switch (array_int[i] % 10)
                            {
                                case 1: if (i == 2) result.Append(" одна"); else result.Append(" один"); break;
                                case 2: if (i == 2) result.Append(" две"); else result.Append(" два"); break;
                                case 3: result.Append(" три"); break;
                                case 4: result.Append(" четыре"); break;
                                case 5: result.Append(" пять"); break;
                                case 6: result.Append(" шесть"); break;
                                case 7: result.Append(" семь"); break;
                                case 8: result.Append(" восемь"); break;
                                case 9: result.Append(" девять"); break;
                            }
                        }
                        else switch (array_int[i] % 100)
                            {
                                case 10: result.Append(" десять"); break;
                                case 11: result.Append(" одиннадцать"); break;
                                case 12: result.Append(" двенадцать"); break;
                                case 13: result.Append(" тринадцать"); break;
                                case 14: result.Append(" четырнадцать"); break;
                                case 15: result.Append(" пятнадцать"); break;
                                case 16: result.Append(" шестнадцать"); break;
                                case 17: result.Append(" семнадцать"); break;
                                case 18: result.Append(" восемнадцать"); break;
                                case 19: result.Append(" девятнадцать"); break;
                            }
                        if (array_int[i] % 100 >= 10 && array_int[i] % 100 <= 19) result.Append(array_string[i, 2]);
                        else switch (array_int[i] % 10)
                            {
                                case 1: result.Append(array_string[i, 0]); break;
                                case 2:
                                case 3:
                                case 4: result.Append(array_string[i, 1]); break;
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                case 9:
                                case 0: result.Append(array_string[i, 2]); break;
                            }
                    }
                }



            result[1] = char.ToUpper(result[1]);
            return number.ToString("# ### ### ###") + " (" + result.ToString().TrimStart() + ")" + AddCurrency(number);
        }
        static string ConvertNumber(string number)
        {
            try
            {
              return ConvertToText(int.Parse(number));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"  Необходимо вводить цифры \n ({ex.Message})", "Ошибка ввода");
                return "";
            }
        }
        static string ConvertDrobnoe(string number)
        {
            int drobnoe = 0;
            try
            {
                if (number.Length > 2)
                {
                    number = number.Substring(0, 2);
                }
                drobnoe = int.Parse(number);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"  Необходимо вводить цифры \n ({ex.Message})", "Ошибка ввода");

            }

            
            if (number.Length == 1)
            {
                drobnoe *= 10;
            }
          
            string slovami = drobnoe switch
            {
                1 or 21 or 31 or 41 or 51 or 61 or 71 or 81 or 91 => " копейка",
                (> 1 and <= 4) or
                (> 21 and < 25) or (> 31 and < 35)
                or (> 41 and < 45) or (> 51 and < 55)
                or (> 61 and < 65) or (> 71 and < 75)
                or (> 81 and < 85) or (> 91 and < 95) => " копейки",
                _ => " копеек"
            };
            return string.Format(" {0:d2}{1}", drobnoe, slovami);
        }
        static string AddCurrency(int number)
        {
            string rubles;
            if (number.ToString().Length > 2)
                rubles = number.ToString()[^2..];
            else
                rubles = number.ToString();
            number = int.Parse(rubles);
            rubles = number switch
            {
                1 or 21 or 31 or 41 or 51 or 61 or 71 or 81 or 91 => " рубль",
                (> 1 and <= 4) or
                (> 21 and < 25) or (> 31 and < 35)
                or (> 41 and < 45) or (> 51 and < 55)
                or (> 61 and < 65) or (> 71 and < 75)
                or (> 81 and < 85) or (> 91 and < 95) => " рубля",
                _ => " рублей"
            };
            return rubles;




        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxGeneralClaim_TextChanged(object sender, EventArgs e)
        {
            string stringWithoutSpaces = textBoxGeneralClaim.Text.Replace(" ", "");
            char[] separators = { ' ', '.', ',' };
            string[] convertres = stringWithoutSpaces.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            //Если есть дробная часть
            if (convertres.Length > 1)
            {
                textBoxGeneralResult.Text = ConvertNumber(convertres[0]).Trim();
                textBoxGeneralResult.Text += ConvertDrobnoe(convertres[1]);               
            }
            // Если нет дробной части
            else if (convertres.Length == 1)
            {
                textBoxGeneralResult.Text = ConvertNumber(convertres[0]).Trim();
                if (textBoxGeneralResult.Text != "")
                textBoxGeneralResult.Text += " 00 копеек";
            }
            //Если вообще ничего нет
            else
                return;    
        }

        private void AddClaim_TextChanged(object sender, EventArgs e)
        {
            string stringWithoutSpaces = AddClaim.Text.Replace(" ", "");
            char[] separators = { ' ', '.', ',' };
            string[] convertres = stringWithoutSpaces.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            if (convertres.Length > 1)
            {
                AddClaimResult.Text = ConvertNumber(convertres[0]).Trim();
                AddClaimResult.Text += ConvertDrobnoe(convertres[1]);
            }
            else if (convertres.Length == 1)
            {
                AddClaimResult.Text = ConvertNumber(convertres[0]).Trim();
                if (AddClaimResult.Text != "")
                AddClaimResult.Text += " 00 копеек";
            }
            else
                return;
            
        }

        private void AddClaimResult_TextChanged(object sender, EventArgs e)
        {
            if (AddClaimResult.TextLength < 1)
            {
                AddClaimResult.Enabled = false;
                TotalClaim.Enabled = false;
                TotalClaimResultBox.Enabled = false;
            }
            else
            {
                AddClaimResult.Enabled = true;
                TotalClaim.Enabled = true;
                TotalClaimResultBox.Enabled =true;
            }

            double generalValue;
            double addValue;
            double sumClaim;
            if (double.TryParse(textBoxGeneralClaim.Text.Replace('.',','), out generalValue) && (double.TryParse(AddClaim.Text.Replace('.',','),out addValue)))
            {
                sumClaim = generalValue + addValue;
                TotalClaim.Text = sumClaim.ToString("F2");
                char[] separators = { ' ', '.', ',' };
                string[] convertres = TotalClaim.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                if (convertres.Length > 1)
                {
                    TotalClaimResultBox.Text = ConvertNumber(convertres[0]).Trim();
                    TotalClaimResultBox.Text += ConvertDrobnoe(convertres[1]);
                }
                else if (convertres.Length == 1)
                {
                    TotalClaimResultBox.Text = ConvertNumber(convertres[0]).Trim();
                    TotalClaimResultBox.Text += " 00 копеек";
                }
                else
                {
                 return;
                }

            }

        }

        private void buttonGeneralCopy_Click(object sender, EventArgs e)
        {
            if (textBoxGeneralResult.Text != "")
            {
                Clipboard.SetText(textBoxGeneralResult.Text);
                labelCopyInfo.Text = buttonGeneralCopy.Tag.ToString();
            }
        }

        private void buttomAddCopy_Click(object sender, EventArgs e)
        {
            if (AddClaimResult.Text != "")
            {
                Clipboard.SetText(AddClaimResult.Text);
                labelCopyInfo.Text = buttomAddCopy.Tag.ToString();
            }
        }

        private void buttonTotalCopy_Click(object sender, EventArgs e)
        {
            if (TotalClaimResultBox.Text != "")
            {
                Clipboard.SetText(TotalClaimResultBox.Text);
                labelCopyInfo.Text = buttonTotalCopy.Tag.ToString();
            }
        }

        private void textBoxGeneralResult_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGeneralResult.TextLength < 1)
            {
                textBoxGeneralResult.Enabled = false;
                TotalClaim.Enabled = false;
                TotalClaimResultBox.Enabled = false;
            }

            else
            {
                textBoxGeneralResult.Enabled = true;
                if (AddClaimResult.TextLength >= 1)
                {
                    TotalClaim.Enabled = true;
                    TotalClaimResultBox.Enabled = true;
                }
            }
                

            if (TotalClaimResultBox.TextLength > 1)
            {
                
                double generalValue;
                double addValue;
                double sumClaim;
                if (double.TryParse(textBoxGeneralClaim.Text.Replace('.', ','), out generalValue) && (double.TryParse(AddClaim.Text.Replace('.', ','), out addValue)))
                {
                    sumClaim = generalValue + addValue;
                    TotalClaim.Text = sumClaim.ToString("F2");
                    char[] separators = { ' ', '.', ',' };
                    string[] convertres = TotalClaim.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    if (convertres.Length > 1)
                    {
                        TotalClaimResultBox.Text = ConvertNumber(convertres[0]).Trim();
                        TotalClaimResultBox.Text += ConvertDrobnoe(convertres[1]);
                    }
                    else if (convertres.Length == 1)
                    {
                        TotalClaimResultBox.Text = ConvertNumber(convertres[0]).Trim();
                        TotalClaimResultBox.Text += " 00 копеек";
                    }
                    else
                    {
                        return;
                    }

                }
            }
        }

        private void TotalClaimResultBox_TextChanged(object sender, EventArgs e)
        {
            if (TotalClaimResultBox.TextLength < 1)
                TotalClaimResultBox.Enabled = false;
            else
                TotalClaimResultBox.Enabled = true;
        }

        private void TotalClaim_TextChanged(object sender, EventArgs e)
        {
            if (TotalClaim.TextLength < 1)
                TotalClaim.Enabled = false;
            else
                TotalClaim.Enabled = true;
        }
    }
}
