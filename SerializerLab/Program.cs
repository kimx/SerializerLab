using Framework.Serialization;
using NTX.SysCore.Services.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMenuInfo info = new UserMenuInfo();
            info.MVC_ACT = "Kim";
            info.ORDERNUM = 100;
            SerializationWriter(info);
            BinaryFormaterObj(info);
            BinaryFormaterCommon();
            Console.ReadLine();
        }

        private static void SerializationWriter(UserMenuInfo info)
        {
            Console.WriteLine("SerializationWriter");
            SerializationWriter writer = new SerializationWriter(new FileStream(AppDomain.CurrentDomain.BaseDirectory + "info.txt", FileMode.Create));
            writer.WriteObject(info);
        }

        private static void BinaryFormaterObj(UserMenuInfo info)
        {
            Console.WriteLine("BinaryFormatter-obj");
            string value = "";
            using (MemoryStream stream = new MemoryStream())
            {
                var binaryWriter = new BinaryFormatter();
                binaryWriter.Serialize(stream, info);
                value = Convert.ToBase64String(stream.ToArray());
                Console.WriteLine(value);
            }

            using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(value)))
            {
                var binaryWriter = new BinaryFormatter();
                UserMenuInfo info2 = (UserMenuInfo)binaryWriter.Deserialize(stream);
                Console.WriteLine(info2.MVC_ACT);
            }
        }

        private static void BinaryFormaterCommon()
        {
            Console.WriteLine("BinaryFormaterCommon");
            string value = "kim1234567";
            string valueSerialize = "";
            using (MemoryStream stream = new MemoryStream())
            {
                var binaryWriter = new BinaryFormatter();
                binaryWriter.Serialize(stream, value);
                valueSerialize = Convert.ToBase64String(stream.ToArray());
                Console.WriteLine(value);
            }

            using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(valueSerialize)))
            {
                var binaryWriter = new BinaryFormatter();
                value = (string)binaryWriter.Deserialize(stream);
                Console.WriteLine(value);
            }
        }
    }
}
