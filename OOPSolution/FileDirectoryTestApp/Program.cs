﻿using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string path = @"C:\Windows"; // Verbatin string
            var dirs = Directory.GetDirectories(path);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirInfo.Name} / {dirInfo.Attributes} / {dirInfo.CreationTime}");
            }

            var files = Directory.GetFiles(path);
            foreach(var item in files)
            {
                Console.WriteLine(item);
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name} / {fileInfo.Attributes} / {fileInfo.CreationTime} / {fileInfo.Length}");
            }*/        // 컨트롤 쉬프트 슬래쉬

            string newPath = @"C:\Test\Help";//디렉토리, 파일을 생성할 위치
            int dirNum = 0; //디렉토리 1씩 증가시켜서 중복피하기 위한 정수

            int i = 0;
            while(true)
            {
                Console.WriteLine("file/dir을 입력하세요(종료는 X)");
                var input = Console.ReadLine();

                if(input == "X")
                {
                    break;
                }
                else
                {
                    //파일/폴더를 만드는 로직
                    if(input=="file")
                    {
                        var fileName = $"SampleFile_{DateTime.Now.ToString("yyMMddHHmmss")}.txt";
                        var fullPath = $@"{newPath}\{fileName}";
                        File.Create(fullPath);
                    }
                    else if(input=="dir")
                    {
                        //Console.WriteLine("디렉토리생성");
                        var dirName = "SampleDirectory";
                        var fullPath = $@"{newPath}\{dirName}";  //C:\Test\Help\SampleDirectory
                        if(!Directory.Exists(fullPath))
                         {
                            Directory.CreateDirectory(fullPath);
                        }  
                        else
                        {
                            dirNum++;
                            fullPath = $@"{newPath}\{dirName}{dirNum}";
                            Directory.CreateDirectory(fullPath);
                        }
                    }
                    else
                    {
                        
                        Console.WriteLine("file / dir로 값을 입력하세요");
                    }
                }
            }
            Console.WriteLine("프로그램 종료");
        }
    }
}
