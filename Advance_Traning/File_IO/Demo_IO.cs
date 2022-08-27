using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Advance_Traning
{

    //Using Directory
    class Demo_directory
    {
        static void CreateFolder()
        {

            string path = @"C:\Ashvini\TestFolder";

            if (Directory.Exists(path))

            {

                Console.WriteLine("Folder is already created");

            }

            else

            {

                Directory.CreateDirectory(path);

                Console.WriteLine("Folder is created");

            }

        }

        static void CreateFile()
        {

            string path = @"C:\Ashvini\TestFolder\TestFile.txt";

            if (File.Exists(path))
            {

                Console.WriteLine("File already exits");

            }

            else
            {

                File.Create(path);

                Console.WriteLine("File created");

            }


        }

        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();
        }
    }

   
    //Using DirectoryInfo & file info class

    class Demo_Directory_Info
    {
        static void CreateFolder()
        {

            string path = @"C:\Ashvini\TestFolder1";

            DirectoryInfo d = new DirectoryInfo(path);

            if (d.Exists)

            {

                Console.WriteLine("Folder is already created");

            }

            else

            {

                d.Create();

                Console.WriteLine("Folder is created");

            }

        }

        static void CreateFile()

        {

            string path = @"C:\Ashvini\TestFolder1\TestFile1.txt";

            FileInfo f = new FileInfo(path);

            if (f.Exists)

            {

                Console.WriteLine("File already exits");

            }

            else

            {

                f.Create();

                Console.WriteLine("File created");

            }


        }

        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();
        }

    }


    // Dept example
    class Demo_Dept
    {
        public class Dept

        {

            public int Id { get; set; }

            public string Name { get; set; }

            public string Location { get; set; }

        }



        static void WriteToFile(Dept dept)

        {

            try

            {

                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\TestFile", FileMode.Create, FileAccess.Write);

                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(dept.Id);

                bw.Write(dept.Name);

                bw.Write(dept.Location);

                bw.Close();

                fs.Close();

                Console.WriteLine("Data added to file");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }


        }

        static void ReadFromFile()

        {

            try

            {

                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\TestFile", FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);

                Console.WriteLine(br.ReadInt32()); //Id

                Console.WriteLine(br.ReadString());// Name

                Console.WriteLine(br.ReadString());// Location

                br.Close();

                fs.Close();

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }




        static void Main(string[] args)

        {

           // Dept dept = new Dept { Id = 1, Name = "HR", Location = "Pune" };

           // WriteToFile(dept);

            ReadFromFile();

        }

    }


    //Stream
    class Demo_Stream
    {



        static void WriteToFileUsingStream()

        {

            try

            {

                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\TextDoc.txt", FileMode.Create, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("This is sample text in the file");

                sw.Close();

                fs.Close();

                Console.WriteLine("Done");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        static void ReadFromFileUsingStream()

        {

            try

            {

                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\TextDoc.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                Console.WriteLine(sr.ReadToEnd());

                sr.Close();

                fs.Close();

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        static void Main(string[] args)

        {

            WriteToFileUsingStream();
            ReadFromFileUsingStream();

        }
    }

    
}