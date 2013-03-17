using System;

namespace Encrypt
{
    public class Vijiner
    {
    private static readonly char[,] matrix = new char[26,26];
    public static char[,] GetMatrix(){
        SetMatrix(Caesar.GetAlphabet());
        return matrix;
    }
    private static void SetMatrix(String alphabet){
        for(int i = 0;  i < alphabet.Length; i++){
            for(int j = 0; j < alphabet.Length; j++){
                matrix[i,j] = alphabet.ToCharArray()[j];
            }
            alphabet = Caesar.Encrypt(alphabet,1);
        }
    }

    public static char GetCharInMatrix(int i,int j){
        try
        {
            return matrix[i, j];
        }
        catch (Exception)
        {
            throw new IndexOutOfRangeException();
        }
    }
    public static String Encrypt(String encryptText, String keyWord){
        String endText = "";
        for(int i = 0; i < encryptText.Length; i++){
            endText += GetCharInMatrix(Caesar.FindCharPosition(encryptText.ToCharArray()[i])
                                        , Caesar.FindCharPosition(keyWord.ToCharArray()[i % keyWord.Length]) + 1);
        }
        return endText;
    }
    public static String Decrypt(String decryptText, String keyWord){
        String endText = "";
        for(int i = 0; i < decryptText.Length; i++){
            endText += GetCharInMatrix(Caesar.FindCharPosition(decryptText.ToCharArray()[i])
                       , Caesar.GetAlphabet().Length - Caesar.FindCharPosition(keyWord.ToCharArray()[i % keyWord.Length]) - 1);
        }
        return endText;
    }
    }
}
