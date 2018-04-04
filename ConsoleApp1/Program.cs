using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public int HelloMessage(int[] array)
        {
            if (array == null || array.Length < 1)
                return -1;
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    temp += array[i];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            string Msg = "";
            MemoryMappedFile Memory;
            // Объект для чтения из памяти
            StreamReader SR_Memory;
            // Объект для записи в память
            StreamWriter SW_Memory;

            Memory = MemoryMappedFile.CreateOrOpen("Memory", 200000, MemoryMappedFileAccess.ReadWrite);

            Memory = MemoryMappedFile.CreateOrOpen("Flag", 1, MemoryMappedFileAccess.ReadWrite);
            // Создает поток для чтения

            StreamReader SR_Flag = new StreamReader(Memory.CreateViewStream(), System.Text.Encoding.Default);
            // Создает поток для записи

            StreamWriter SW_Flag = new StreamWriter(Memory.CreateViewStream(), System.Text.Encoding.Default);

            SR_Memory = new StreamReader(Memory.CreateViewStream(), System.Text.Encoding.Default);
            // Создает поток для записи

            SW_Memory = new StreamWriter(Memory.CreateViewStream(), System.Text.Encoding.Default);
            // Встает в начало потока для чтения
            SR_Memory.BaseStream.Seek(0, SeekOrigin.Begin);
            // Считывает данные из потока памяти, обрезая ненужные байты
            Msg = SR_Memory.ReadToEnd().Trim('\0', '\r', '\n');

            Console.WriteLine(Msg);

         //   SW_Memory.BaseStream.Seek(0, SeekOrigin.Begin);
            // Очищает память, заполняя "нулевыми байтами"
         //   for (int i = 0; i < 32768; i++)
           //     SW_Memory.Write("X");
            // Очищает все буферы для SW_Memory и вызывает запись всех данных буфера в основной поток
          //  SW_Memory.Flush();

            // Встает в начало потока для чтения
              SR_Memory.BaseStream.Seek(0, SeekOrigin.Begin);
           //  Считывает данные из потока памяти, обрезая ненужные байты
              Msg = SR_Memory.ReadToEnd().Trim('\0', '\r', '\n');

            Console.WriteLine(Msg.Count());

            Console.ReadLine();
        }
        
    }
}
