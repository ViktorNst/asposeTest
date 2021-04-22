using System;
using System.Collections.Generic;
using System.Text;

namespace AsposeTest
{
    public class StringToKeypadConverter
    {

        public String convertToKeyPad(String input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            SymbolEnum previousSymbol = null;
            for (int i = 0; i < input.Length; i++)
            {
                char inputChar = input[i];
                SymbolEnum symbol = SymbolEnum.getByChar(inputChar);
                if (previousSymbol != null && symbol != null && symbol.key == previousSymbol.key)
                {
                    stringBuilder.Append(" ");
                }
                if (symbol != null)
                {
                    stringBuilder.Append(symbol.keySequence);
                }
                previousSymbol = symbol;
            }
            return stringBuilder.ToString();
        }

    }

    public class SymbolEnum
    {

        public static SymbolEnum[] enumArray = new SymbolEnum[128];
        public static List<SymbolEnum> values = new List<SymbolEnum>();

        static SymbolEnum()
        {
            values = new List<SymbolEnum>() {
                new SymbolEnum('a', '2', "2"),
                new SymbolEnum('b', '2', "22"),
                new SymbolEnum('c', '2', "222"),
                new SymbolEnum('d', '3', "3"),
                new SymbolEnum('e', '3', "33"),
                new SymbolEnum('f', '3', "333"),
                new SymbolEnum('g', '4', "4"),
                new SymbolEnum('h', '4', "44"),
                new SymbolEnum('i', '4', "444"),
                new SymbolEnum('j', '5', "5"),
                new SymbolEnum('k', '5', "55"),
                new SymbolEnum('l', '5', "555"),
                new SymbolEnum('m', '6', "6"),
                new SymbolEnum('n', '6', "66"),
                new SymbolEnum('o', '6', "666"),
                new SymbolEnum('p', '7', "7"),
                new SymbolEnum('q', '7', "77"),
                new SymbolEnum('r', '7', "777"),
                new SymbolEnum('s', '7', "7777"),
                new SymbolEnum('t', '8', "8"),
                new SymbolEnum('u', '8', "88"),
                new SymbolEnum('v', '8', "888"),
                new SymbolEnum('w', '9', "9"),
                new SymbolEnum('x', '9', "99"),
                new SymbolEnum('y', '9', "999"),
                new SymbolEnum('z', '9', "9999"),
                new SymbolEnum(' ', '0', "0")
            };
            foreach (var value in values)
            {
                enumArray[value.chr] = value;
            }
        }

        public char chr;
        public char key;
        public String keySequence;

        public SymbolEnum(char chr, char key, String keySequence)
        {
            this.chr = chr;
            this.key = key;
            this.keySequence = keySequence;
        }

        public static SymbolEnum getByChar(char chr)
        {
            if (chr >= 128)
            {
                return null;
            }
            return enumArray[chr];
        }
    }

}
