using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            int numInputs = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < numInputs; i++)
            {
                string num = Console.ReadLine();

                switch (num[0])
                {
                    case '0':
                        word += ' ';
                        break;

                    case '2':
                        //additionalNum = 47;
                        if (num.Length == 1)
                        {
                            word += (char)('2' + '/');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)('3' + '/');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)('4' + '/');
                        }
                        break;

                    case '3':
                        //additionalNum = 49;
                        if (num.Length == 1)
                        {
                            word += (char)('3' + '1');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)('4' + '1');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)('5' + '1');
                        }
                        break;

                    case '4':
                        //additionalNum = 51;
                        if (num.Length == 1)
                        {
                            word += (char)('4' + '3');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)('5' + '3');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)('6' + '3');
                        }
                        break;

                    case '5':
                        //additionalNum = 53;
                        if (num.Length == 1)
                        {
                            word += (char)('5' + '5');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)('6' + '5');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)('7' + '5');
                        }
                        break;

                    case '6':
                        //additionalNum = 55;
                        if (num.Length == 1)
                        {
                            word += (char)('6' + '7');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)('7' + '7');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)('8' + '7');
                        }
                        break;

                    case '7':
                        //additionalNum = 57;
                        if (num.Length == 1)
                        {
                            word += (char)('7' + '9');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)('8' + '9');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)('9' + '9');
                        }
                        else if (num.Length == 4)
                        {
                            word += (char)(':' + '9');
                        }
                        break;

                    case '8':
                        //additionalNum = 59;
                        if (num.Length == 1)
                        {
                            word += (char)('8' + '<');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)('9' + '<');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)(':' + '<');
                        }
                        break;

                    case '9':
                        //additionalNum = 61;
                        if (num.Length == 1)
                        {
                            word += (char)('9' + '>');
                        }
                        else if (num.Length == 2)
                        {
                            word += (char)(':' + '>');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)(';' + '>');
                        }
                        else if (num.Length == 3)
                        {
                            word += (char)('<' + '>');
                        }
                        break;
                }
            }

            Console.WriteLine(word);
            //int clicks = int.Parse(Console.ReadLine());
            //string message = string.Empty;

            //for (int i = 0; i < clicks; i++)
            //{
            //    string digits = Console.ReadLine();
            //    int digitLength = digits.Length;
            //    int digit = digits[0] - '0';    
            //    int offset = (digit - 2) * 3;

            //    if (digit == 0)
            //    {
            //        message += (char)(digit + 32);
            //        continue;
            //    }

            //    if (digit == 8 || digit == 9)
            //    {
            //        offset++;
            //    }
            //    int letterIndex = offset + digitLength - 1;
            //    message += (char)(letterIndex + 97);
            //}

            //Console.WriteLine(message);

        }
    }
}
