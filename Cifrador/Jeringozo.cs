using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrador
	{
	public class Jeringozo
		{
			private static char[] vocales = ['a', 'e', 'i', 'o', 'u'];
			private static char[] DividirPalabras(string texto)
			{
				char[] charArray = texto.ToCharArray();

				return charArray;
			}

			public static string Encriptar(string texto)
			{
        char[] charArray = DividirPalabras(texto);

        List<char> charList = new();

        foreach (char character in charArray)
        {
          switch (character)
          {
            case 'a':
              charList.Add(character);
              charList.Add('p');
              charList.Add('a');
              break;
            case 'e':
              charList.Add(character);
              charList.Add('p');
              charList.Add('e');
              break;
            case 'i':
              charList.Add(character);
              charList.Add('p');
              charList.Add('i');
              break;
            case 'o':
              charList.Add(character);
              charList.Add('p');
              charList.Add('o');
              break;
            case 'u':
              charList.Add(character);
              charList.Add('p');
              charList.Add('u');
              break;
            default:
              charList.Add(character);
              break;
						}
					}
					return new string(charList.ToArray());
			}

			public static string Desencriptar(string texto)
			{
        char[] charArray = DividirPalabras(texto);

        List<char> charList = charArray.ToList();

        for (int i = 0; i < charList.Count - 2; i++)
        {
          if (vocales.Contains(charList[i]))
          {
            charList.RemoveRange(i + 1, 2);
          }
        }				
        return new string(charList.ToArray());
			}
		}
	}
