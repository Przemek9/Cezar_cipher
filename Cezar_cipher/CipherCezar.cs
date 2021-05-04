using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezar_cipher
{
    public class CipherCezar
    {


        public static char Cipher(char my_char, int key)
        {
            if (!char.IsLetter(my_char))
            {
                return my_char;
            }

            char start = char.IsUpper(my_char) ? 'A' : 'a';
            return (char)((((my_char + key) - start) % 26) + start);

        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char my_char in input)
                output += Cipher(my_char, key);

            return output;
        }



    }
}