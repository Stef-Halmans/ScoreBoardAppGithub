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
        byte[] dataBytes = Encoding.Unicode.GetBytes("abcdefghijklmnop");
        string dataToEncrypt = player + data;
        byte[] dataToSend;


        Aes aes = Aes.Create();
        aes.BlockSize = 128;
        aes.Key = Encoding.UTF8.GetBytes("abcdefghijklmnop");
        aes.Padding = PaddingMode.Zeros;
        aes.Mode = CipherMode.ECB;
        ICryptoTransform encryptor = aes.CreateEncryptor();
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
            {
                using(StreamWriter streamWriter = new StreamWriter(cryptoStream))
                {
                    streamWriter.Write(dataToEncrypt);
                }
                dataToSend = memoryStream.ToArray();
 
            }
        }
         for (int i = 0; i < dataToSend.Length; i++){
            Console.WriteLine(dataToSend[i]);
        }





        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "post");
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
    public string GetData(string path)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + path);
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using(Stream stream = response.GetResponseStream())
        using(StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }


    }
}
public static class ThreadHelperClass
{
    delegate void SetTextCallback(Form f, Control ctrl, string text);
    /// <summary>
    /// Set text property of various controls
    /// </summary>
    /// <param name="form">The calling form</param>
    /// <param name="ctrl"></param>
    /// <param name="text"></param>
    public static void SetText(Form form, Control ctrl, string text)
    {
        // InvokeRequired required compares the thread ID of the 
        // calling thread to the thread ID of the creating thread. 
        // If these threads are different, it returns true. 
        if (ctrl.InvokeRequired)
        {
            SetTextCallback d = new SetTextCallback(SetText);
            form.Invoke(d, new object[] { form, ctrl, text });
        }
        else
        {
            ctrl.Text = text;
        }
    }
}
