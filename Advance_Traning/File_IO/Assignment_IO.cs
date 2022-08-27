using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Advance_Traning.File_IO
{
    /* Assignment 1
     Create a class Course with Id, Name & Fees properties,
       Create a file to Write course details using
        BianaryWriter & read the same using BinaryReader.
     */

    class Course
    {
        public class Dept

        {

            public int Id { get; set; }

            public string Name { get; set; }

            public int Fees { get; set; }

        }



        static void WriteToFile(Dept dept)

        {

            try

            {

                FileStream fs = new FileStream(@"C:\Ashvini\TestFolder\TestFile", FileMode.Create, FileAccess.Write);

                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(dept.Id);

                bw.Write(dept.Name);

                bw.Write(dept.Fees);

                bw.Close();

                fs.Close();

                Console.WriteLine("Data added to course");

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

                Console.WriteLine(br.ReadInt32());// Fees

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

            // Dept dept = new Dept { Id = 1, Name = "Java", Fees = 1000 };

            //WriteToFile(dept);

            ReadFromFile();

        }

    }


    /* Assignment 2
       Write a code to accept string from user &
       write to file using StreamWriter & read & display on console
     */

    class Demo_Stream1
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
