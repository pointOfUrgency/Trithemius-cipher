using System;

char[] alphabetAndPunctuation = new char[]
{
    'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 
    'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Э', 'Ю', 'Я', 
    'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 
    'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'э', 'ю', 'я',
    '.', ',', '!', '?', ':', ';', '-', '(', ')', '"', '\'', '№', '—', '.', ' ', '…'
};

Console.WriteLine("Type the key: ");
string? keyword = Convert.ToString(Console.ReadLine());
keyword = keyword.ToUpper();
Console.WriteLine("Type the phrase: ");
string? phrase = Convert.ToString(Console.ReadLine());
phrase = phrase.ToUpper();

string fullkeyword = Trit.Repeater(keyword, phrase);
string crypted = Trit.Encrypt(fullkeyword, phrase, alphabetAndPunctuation);
Console.WriteLine("Encrypted: " + crypted);
string decrypted = Trit.Decrypt(fullkeyword, crypted, alphabetAndPunctuation);
Console.WriteLine("Decrypted: " + decrypted);

class Trit
{
    // Метод для повторения ключа до длины фразы
    public static string Repeater(string key, string phrase)
    {
        int keylen = key.Length;
        int phraselen = phrase.Length;
        if (keylen == phraselen)
        {
            return key;
        }

        char[] fullkey = new char[phraselen];
        for (int i = 0; i < phraselen; i++)
        {
            fullkey[i] = key[i % keylen];
        }
        return new string(fullkey);
    }

    // Шифрование фразы
    public static string Encrypt(string fullkeyword, string phrase, char[] alphabet)
    {
        char[] cryptedArray = new char[phrase.Length];
        for (int i = 0; i < phrase.Length; i++)
        {
            int phraseIndex = Array.IndexOf(alphabet, phrase[i]);
            int keyIndex = Array.IndexOf(alphabet, fullkeyword[i]);
            
            // Расчет сдвига для шифрования
            int shift = (phraseIndex + keyIndex) % alphabet.Length; 

            cryptedArray[i] = alphabet[shift];
        }
        return new string(cryptedArray);
    }
    
    // Дешифровка фразы
    public static string Decrypt(string fullkeyword, string phrase, char[] alphabet)
    {
        char[] decryptedArray = new char[phrase.Length];
        for (int i = 0; i < phrase.Length; i++)
        {
            int phraseIndex = Array.IndexOf(alphabet, phrase[i]);
            int keyIndex = Array.IndexOf(alphabet, fullkeyword[i]);
            
            // Расчет сдвига для расшифровки
            int shift = (phraseIndex - keyIndex + alphabet.Length) % alphabet.Length; 

            decryptedArray[i] = alphabet[shift];
        }
        return new string(decryptedArray);
    }
}
