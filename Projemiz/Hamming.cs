using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projemiz
{
	public class Hamming
	{
		char[] hex = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

		private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
		  { '0', "0000" },
		  { '1', "0001" },
		  { '2', "0010" },
		  { '3', "0011" },
		  { '4', "0100" },
		  { '5', "0101" },
		  { '6', "0110" },
		  { '7', "0111" },
		  { '8', "1000" },
		  { '9', "1001" },
		  { 'a', "1010" },
		  { 'b', "1011" },
		  { 'c', "1100" },
		  { 'd', "1101" },
		  { 'e', "1110" },
		  { 'f', "1111" }
		};

		char[] hexChar = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

		private static readonly Dictionary<char, string> hexCharacterToBinaryChar = new Dictionary<char, string> {
		  { '0', "0000" },
		  { '1', "0001" },
		  { '2', "0010" },
		  { '3', "0011" },
		  { '4', "0100" },
		  { '5', "0101" },
		  { '6', "0110" },
		  { '7', "0111" },
		  { '8', "1000" },
		  { '9', "1001" },
		};
		public string HexStringToBinary(string hex)
		{
			StringBuilder result = new StringBuilder();
			foreach (char c in hex)
			{
				result.Append(hexCharacterToBinary[char.ToLower(c)]);
			}
			return result.ToString();
		}

		public string BinaryToHex(string BinaryTxt)
		{
			string result;
			result = Convert.ToInt32(BinaryTxt, 2).ToString("X");
			return result;
		}

		public string HexCharToBinary(char hexChar)
		{
			// Sadece tek bir hexadecimal karakteri al ve ikiliye dönüştür --
			return hexCharacterToBinary[char.ToLower(hexChar)];
		}

		public string BinaryToHexChar(string binaryStr)
		{
			// Sadece 4 bitlik bir ikili sayıyı al ve hexadecimal karaktere dönüştür
			if (binaryStr.Length != 4)
				throw new ArgumentException("Binary string must be exactly 4 digits long.");

			int decimalValue = Convert.ToInt32(binaryStr, 2);
			return decimalValue.ToString("X");
		}

		public bool IsBinary(string t)
		{
			bool control = true;
			for (int i = 0; i < t.Length; i++)
			{
				if (t[i].ToString() != "0" && t[i].ToString() != "1")
				{
					control = false;
					break;
				}
			}
			return control;
		}
		public bool IsEightDigit(string t)
		{
			if (t.Length == 8)
				return true;
			else
				return false;
		}
		public bool IsFourDigit(string t)
		{
			if (t.Length == 4)
				return true;
			else
				return false;
		}
		public bool IsHex(string t)
		{
			bool control = true;
			for (int i = 0; i < 16; i++)
			{
				if (Array.IndexOf(hex, t[0]) == -1 )
				{
					control = false;
					break;
				}
			}
			return control;

		}
		public bool IsTwoDigit(string t)
		{
			if (t.Length == 2)
				return true;
			else
				return false;
		}

		public bool IsOneDigit(string t)
		{
			if (t.Length == 1)
				return true;
			else
				return false;
		}
		public string XorOperator(string p1, string p2)
		{
			string s;
			if (p1 == p2)
				s = "0";
			else
				s = "1";
			return s;
		}
		public string XorOperator(string p1, string p2, string p3)
		{

			string s1, s2, s3;

			// İlk XOR işlemi
			if (p1 == p2)
				s1 = "0";
			else
				s1 = "1";

			// İkinci XOR işlemi
			if (s1 == p3)
				s2 = "0";
			else
				s2 = "1";

			// Üçüncü XOR işlemi
			if (s2 == "0")
				s3 = "1";
			else
				s3 = "0";

			return s3;

		}
		public string XorOperator(string p1, string p2, string p3, string p4)
		{

			string s1, s2, s3;
			if (p1 == p2)
				s1 = "0";
			else
				s1 = "1";
			if (s1 == p3)
				s2 = "0";
			else
				s2 = "1";
			if (s2 == p4)
				s3 = "0";
			else
				s3 = "1";

			return s3;
		}
		public string XorOperator(string p1, string p2, string p3, string p4, string p5)
		{
			string s4, s;
			s4 = XorOperator(p1, p2, p3, p4);
			if (p5 == s4)
				s = "0";
			else
				s = "1";

			return s;
		}

		public string NotOperator(string Bit)
		{
			if (Bit == "0")
				return "1";
			else
				return "0";
		}
	}
}
