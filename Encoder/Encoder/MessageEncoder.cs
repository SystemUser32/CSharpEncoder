using System;
using System.Text;
using static System.Console;
using static System.Convert;

namespace Encoder
{
    public class MessageEncoder {

        private int option;
        private string message;

        public MessageEncoder(int option, string message) {
            this.option = option;
            this.message = message;
        }

        public string Perform() {

            Encoding encoder = option switch {
                1 => Encoding.ASCII,
                2 => Encoding.UTF7,  //Obsolete, this will cause a warning
                3 => Encoding.UTF8,
                4 => Encoding.Unicode,
                5 => Encoding.UTF32,
                _ => Encoding.Default
            };

            byte[] encoded = encoder.GetBytes(message);

            WriteLine($"{encoder.GetType().Name} uses {encoded.Length} bytes.");
            WriteLine("BYTE  HEX  CHAR");

            foreach (byte b in encoded)
            {
                WriteLine($"{b, 4} {b.ToString("X"), 4} {(char)b ,5}");
            }

            string decoded = encoder.GetString(encoded);

            return decoded;

        }

    }
}

