using System;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using EasyEncryption;
using System.Security.Cryptography;
public class DatabaseController
{
    private string url;

    public DatabaseController(string url)
    {
        this.url = url;
    }

  
   


    public void SubmitData(string player, string data)
    {
        byte[] iv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        byte[] dataBytes = Encoding.UTF8.GetBytes(player+ data);
        byte[] dataToSend;


        SymmetricAlgorithm encryption = Aes.Create();
        encryption.BlockSize = 128;
        encryption.IV = iv;
        encryption.Key = Encoding.Unicode.GetBytes("abcdefghijklmnop");
        encryption.Mode = CipherMode.CBC;
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryption.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(dataBytes, 0, dataBytes.Length);
            }

            dataToSend = memoryStream.ToArray();
        }
        Console.WriteLine(Encoding.Default.GetString(dataToSend));




        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
        request.ContentLength = dataToSend.Length;
        request.ContentType = "text/plain";
        request.Method = "POST";

        using (Stream requestBody = request.GetRequestStream())
        {
            requestBody.Write(dataToSend, 0, dataToSend.Length);
        }

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

        using (Stream stream = response.GetResponseStream())

        using (StreamReader reader = new StreamReader(stream))
        {
            Console.WriteLine(reader.ReadToEnd());
            MessageBox.Show(reader.ReadToEnd());
        }
    }
    public string GetData()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using(Stream stream = response.GetResponseStream())
        using(StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }


    }
}
