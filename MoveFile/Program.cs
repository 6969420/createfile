﻿using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void MoveFile()
        {
            string sourceDirectory = @"C:\Users\opilane\samples\playerOne";
            string destinationPath = @"C:\Users\opilane\samples\playerOne";
            string fileName = "ball.txt";

            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }
    }
}