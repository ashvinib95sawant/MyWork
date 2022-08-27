using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;


namespace Advance_Traning
{
    /*
      Implement all the 4 serialization with Product class
        ProductId
       ProductName
       Price
     */


    // Binary Serialization

    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    class Binary_Serializationn1
    {
        static void BinarySerializationWrite(Product prod)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, prod);
                Console.WriteLine("Bianry data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BinarySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Product prod = (Product)bf.Deserialize(fs);
                Console.WriteLine(prod.ProductId);
                Console.WriteLine(prod.ProductName);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //Product prod = new Product { ProductId = 11, ProductName = "Mobile", Price = 20044 };
            //BinarySerializationWrite(prod);
            BinarySerializationRead();
        }
    }


    //XML_Serialization
    class XML_Serialization1
    {
        static void XmlSerializationWrite(Product stud)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\XmlFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, stud);
                Console.WriteLine("Xml data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\XmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                Product prod = (Product)xs.Deserialize(fs);
                Console.WriteLine(prod.ProductId);
                Console.WriteLine(prod.ProductName);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            //Product prod = new Product { ProductId = 21, ProductName = "TV", Price = 40000 };
            //XmlSerializationWrite(prod);
            XmlSerializationRead();
        }
    }

    //Json_Serialization

    class Json_serializationn1
    {
        static void JsonSerializationWrite(Product stud)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Product>(fs, stud);
                Console.WriteLine("Json data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Product prod = JsonSerializer.Deserialize<Product>(fs);
                Console.WriteLine(prod.ProductId);
                Console.WriteLine(prod.ProductName);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            //Product prod = new Product { ProductId = 31, ProductName = "Laptop", Price = 39440 };
            //JsonSerializationWrite(prod);
            JsonSerializationRead();
        }

    }

    //Soap_Serialization

    class Soap_Serialization1
    {
        static void SoapSerializationWrite(Product stud)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, stud);
                Console.WriteLine("Soap data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Product prod = (Product)sf.Deserialize(fs);
                Console.WriteLine(prod.ProductId);
                Console.WriteLine(prod.ProductName);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            //Product prod = new Product { ProductId = 101, ProductName = "Suraj", Price = 89.44 };
            //SoapSerializationWrite(prod);
            SoapSerializationRead();
        }

    }
}
