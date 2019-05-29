using System;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;

public class DatabaseController
{
    private string url;

    public DatabaseController(string url)
    {
        this.url = url;
    }
    public void SubmitData(string player, string data)
    {
        byte[] dataBytes = Encoding.UTF8.GetBytes(player + data);
        Console.WriteLine("10");
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
        request.ContentLength = dataBytes.Length;
        request.ContentType = "text/plain";
        request.Method = "POST";
        Console.WriteLine("1");
        //HttpClient httpClient = new HttpClient();
        //StringContent stringContent = new StringContent(dataToSend, Encoding.UTF8, "text/plain");
        //HttpResponseMessage message = httpClient.PostAsync(url, stringContent).GetAwaiter().GetResult();
        //MessageBox.Show(message.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        //httpClient.PostAsync(url, stringContent);
        using (Stream requestBody = request.GetRequestStream())
        {
            Console.WriteLine("11");
            requestBody.Write(dataBytes, 0, dataBytes.Length);
            Console.WriteLine("3");
        }
        Console.WriteLine("2");
        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
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
