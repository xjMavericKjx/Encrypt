using System;

namespace Encrypt
{
    public class Caesar
    {
        private const String ALPHABET = "abcdefghijklmonpqrstuvwxyz";

        public static String Encrypt(String encryptText, int shift)
        {
            return Crypt(encryptText, shift);
        }
       
        public static String Decrypt(String encryptText, int shift)
        {
            return Crypt(encryptText, -shift);
        }

        public static int FindCharPosition(char ch)
        {
            int positionNumber = 0;
            for (int i = 0; i < ALPHABET.Length; i++)
                if (ch == ALPHABET.ToCharArray()[i])
                {
                    positionNumber = i;
                    break;
                }
                else
                {
                    positionNumber = 0;
                }
            return positionNumber;
        }

        public static String Crypt(String encryptText, int shift)
        {
            String endString = "";
            int encryptStringLength = encryptText.Length;
            for (int i = 0; i < encryptStringLength; i++)
            {
                if (encryptText.ToCharArray()[i].Equals('1'))
                {
                    throw new ArgumentOutOfRangeException();
                }
                endString += CryptChar(encryptText.ToCharArray()[i], shift);
            }
            return endString;
        }
        public static String GetAlphabet()
        {
            return ALPHABET;
        }
        public static char CryptChar(char ch, int shift)
        {
            char endChar = ' ';
            int alphabetsLength = ALPHABET.Length;
            for (int j = 0; j < alphabetsLength; j++)
            {
                if (ch == ALPHABET.ToCharArray()[j])
                {
                    int temp = j + shift + alphabetsLength;
                    while (temp >= alphabetsLength)
                    {
                        temp -= alphabetsLength;
                    }
                    endChar = ALPHABET.ToCharArray()[temp];
                }
            }
            return endChar;
        }
    }
}
