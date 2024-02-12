namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 string
            Console.WriteLine("Opgave 1 \n" + WordSeparator() + "\n\n");

            //1 string
            Console.WriteLine("Opgave 2 \n" + IsPalindrome() + "\n\n");

            //1 string
            Console.WriteLine("Opgave 3 \n" + StrLen() + "\n\n");

            //1 string
            Console.WriteLine("Opgave 4 \n" + StrRev() + "\n\n");

            //1 string
            Console.WriteLine("Opgave 5 \n" + NumWords() + "\n\n");

            //1 string
            Console.WriteLine("Opgave 6 \n" + RevWordsOrder() + "\n \n");

            //2 string
            Console.WriteLine("Opgave 7 \n" + HowManyOcc() + "\n \n");

            //1 string
            Console.WriteLine("Opgave 8 \n" + SortedWord() + "\n \n");

            //1 string
            Console.WriteLine("Opgave 9 \n" + CompressedString("Marcus Liam Nielsen") + "\n \n");
        }

        //Opgave 1
        static string WordSeparator(string Word = "ABCD", string separator = "^")
        {
            string NewWord = "";
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i].ToString() != " ")
                {
                    NewWord += Word[i];
                    if (Word[i].ToString() != Word[Word.Length  - 1].ToString() && Word[i + 1].ToString() != " ")
                    NewWord += separator;
                }
                else
                {
                    NewWord += Word[i];
                }
            }
            return NewWord;
        }

        //Opgave 2
        static bool IsPalindrome(string Word = "eye")
        {
            Char[] WordRevChar = Word.ToCharArray();
            Array.Reverse(WordRevChar);

            string WordRev = "";

            foreach(char C in WordRevChar)
            {
                WordRev += C.ToString();
            }

            if (Word.ToLower() == WordRev.ToLower()) { return true; }
            else { return false; }
        }

        //Opgave 3
        static int StrLen(string word = "Computer")
        {
            int len = 0;
            foreach(int letter in word)
            {
                len++;
            }
            return len;
        }

        //Opgave 4
        static string StrRev(string Word = "ABCD")
        {
            Char[] WordRevChar = Word.ToCharArray();
            Array.Reverse(WordRevChar);

            string WordRev = "";

            foreach (char C in WordRevChar)
            {
                WordRev += C.ToString();
            }
            return WordRev;
        }

        //Opgave 5
        static int NumWords(string Words = "Det her er en test")
        {
            string[] WordList = Words.Split(' ');
            return WordList.Length;

        }

        //Opgave 6

        //*Husk at ændre tegnsæt
        static string RevWordsOrder(string Sentence = "John Doe.")
        {
            string[] WordList = Sentence.Split(' ');
            Sentence = "";
            foreach (string word in WordList.Reverse()) 
            {
                Sentence += word;
                Sentence += " ";
            }
            return Sentence;
        }

        //Opgave 7
        static int HowManyOcc(string Sentence = "Hello, World!", string SearchWord = "Hello")
        {
            string[] WordList = Sentence.Split(' ', ',', '.', '?');
            int NumCount = 0;
            foreach (string Word in WordList)
            {
                if (Word == SearchWord)
                {
                    NumCount++;
                }
            }
            return NumCount;
        }

        //Opgave 8
        static string SortedWord(string word = "onomatopoeia")
        {
            char[] Letters = word.ToCharArray();
            Array.Sort(Letters);
            word = "";
            foreach (char Letter in Letters.Reverse())
            {
                word += Letter;
            }
            return word;
        }

        //Opgave 9
        static string CompressedString(string Word = "kkkktttrrrrrrrrrr")
        {
            int count = 0;
            char[] LettersArray = Word.ToCharArray();
            Word = "";
            List<string> values = new List<string>();
            List<string> LettersList = new List<string>();
            foreach (char c in LettersArray)
            {
                values.Add(c.ToString());
                if (!LettersList.Contains(c.ToString()))
                {
                    LettersList.Add(c.ToString());
                }
            }
            foreach (string Letter in LettersList)
            {
                count = values.Count(c => c == Letter);
                Word += Letter + ": " + count.ToString() + "\n";
            }


            
            return Word;
        }
    }
}
