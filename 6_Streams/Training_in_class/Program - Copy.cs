using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Xml;

namespace Training_in_class
{
    class Program
    {
      //  const int portNum = 0808;

        static void Main()
        {

            /////////////////////////reader writer///////////

            using (var reader = new StreamReader("../../Program.cs"))
            {
                using (var writer = new StreamWriter("../../reversed.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = line.Length; i >= 0; i--)
                        {
                            writer.Write(line[i]);
                        }
                        writer.WriteLine();
                        line = reader.ReadLine();
                    }
                }
            }




//=======================================================================
            //var tcpListener = new TcpListener(IPAddress.Any,portNum);
            //tcpListener.Start();

            //Console.WriteLine("Listening on port...{0}",portNum);

            //while (true)
            //{
            //    using (NetworkStream stream = tcpListener.AcceptTcpClient().GetStream())
            //    {
            //        byte[] request = new byte[4096];
            //        stream.Read(request, 0, 4096);
            //        Console.WriteLine(Encoding.UTF8.GetString(request));

            //        string html = string.Format("{0} {1} {2} {3} - {4} {2} {1} {0}",
            //            "<html>", "<body>", "<h1>", "Welcome to my sitee!", DateTime.Now);

            //        byte[] htmlBytes = Encoding.UTF8.GetBytes(html);
            //        stream.Write(htmlBytes,0,htmlBytes.Length);

            //    }
            //}


       //======================================================================================================

            //string text = "First try! Rock on";

            //FileStream stream = new FileStream("../../log.txt",FileMode.Append);

            //try
            //{
            //    byte[] bytes = Encoding.UTF8.GetBytes(text);
            //    stream.Write(bytes,0,bytes.Length);
            //}
            //finally
            //{
                
            //    stream.Close();
            //}


          
            





        }
    }
}
