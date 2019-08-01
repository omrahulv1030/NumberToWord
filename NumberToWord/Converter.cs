namespace NumberToWord
{
    using System;
    public static class Converter
    {
        public static string ConvertNumber(int number)
        {
            string word = string.Empty;
            string place = string.Empty;
            bool Converted = false;
            try
            {
                if (number > 0)
                {
                    int digits = number.ToString().Length;
                    int pos = 0;
                    switch (digits)
                    {
                        case 1:
                            word = Words.NumberToWord[number];
                            Converted = true;
                            break;
                        case 2:
                            word = Words.NumberToWord.ContainsKey(number) ? Words.NumberToWord[number] :
                                Words.NumberToWord[number - (number % 10)] + " " + Words.NumberToWord[number % 10];
                            Converted = true;
                            break;
                        case 3:
                            pos = (digits % 3) + 1;
                            place = " hundred and ";
                            break;
                        case 4:
                        case 5:
                        case 6:
                            pos = (digits % 4) + 1;
                            place = " thousand ";
                            break;
                        case 7:
                        case 8:
                        case 9:
                            pos = (digits % 7) + 1;
                            place = " million ";
                            break;
                        default:
                            Converted = true;
                            break;
                    }
                    if (!Converted)
                    {
                        var Number = number.ToString();
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertNumber(Convert.ToInt32(Number.Substring(0, pos))) + place + ConvertNumber(Convert.ToInt32(Number.Substring(pos)));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            word = ConvertNumber(Convert.ToInt32(Number.Substring(0, pos))) + ConvertNumber(Convert.ToInt32(Number.Substring(pos)));
                        }
                    }
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return word.Trim();
        }
    }
}
