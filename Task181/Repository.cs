using System.Collections.Generic;
using System.IO;

namespace Task181
{
    public static class Repository
    {

        public static Dictionary<string, string> getHackedUsers()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            using (var stream=new StreamReader("data.txt"))
            {
                while (!stream.EndOfStream)
                {
                    var item = stream.ReadLine().Split(' ');
                    users.Add(item[0], item[1]);
                }
            }

            return users;
        }

    }
}
