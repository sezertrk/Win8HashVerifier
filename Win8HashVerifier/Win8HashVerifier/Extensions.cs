using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace ExtensionManager
{
    public static class Extensions
    {
        public static string GetMD5(this string filename)
		{
			string result = string.Empty;

			try
			{
				MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
				FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				byte[] arrByteHashValue = md5Provider.ComputeHash(fileStream);
				fileStream.Close();

				string hashData = BitConverter.ToString(arrByteHashValue).Replace("-", "");
				result = hashData;
			}
			catch
			{
			}
			return result.ToLower();
		}
    }
}
