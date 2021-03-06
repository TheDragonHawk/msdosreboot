﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        private static int exitCode;

        static void Main(string[] args)
        {
            // Initial Boot
            Console.Beep();
            Console.WriteLine("Starting MS DOS");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HIMEM is testing extended memory...done.");
            Console.WriteLine(@"C:\>C:\DOS\SMARTDRV.EXE /X");
            Console.WriteLine("To shut down the computer, type shutdown and press enter");
            while (true)
            {
                Console.Write(@"C:\>");
                var input = Console.ReadLine();
                // Disk Drive Scanning
                if (input.Equals("chkdsk"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Volume MS-DOS_6     created 03-09-1991 8:00a");
                    Console.WriteLine("Volume Serial Number is 4A69-401B");
                    Console.WriteLine();
                    Console.WriteLine("1,073,168,384 bytes total disk space");
                    Console.WriteLine("       98,304 bytes in 2 hidden files");
                    Console.WriteLine("       16,384 bytes in 1 directories");
                    Console.WriteLine("       6,979,584 bytes in 127 user files");
                    Console.WriteLine("1,066,074,112 bytes available on disk");
                    Console.WriteLine();
                    Console.WriteLine("       16,384 bytes in each allocation unit");
                    Console.WriteLine("       65,501 total allocation units on disk");
                    Console.WriteLine("       65,068 available allocation units on disk");
                    Console.WriteLine();
                    Console.WriteLine("      655,360 total bytes memory");
                    Console.WriteLine("      606,336 bytes free");
                    Console.WriteLine();
                    Console.WriteLine("Instead of using chkdsk, try using scandisk. scandisk can reliably detect");
                    Console.WriteLine("and fix a much wider range of disk problems. For more information,");
                    Console.WriteLine("type help scandisk from the command prompt.");
                    Console.WriteLine();
                }
                if (input.Equals("shutdown"))
                {
                    Console.WriteLine(); 
                    Console.WriteLine("Stopping services");
                    Console.WriteLine(@"Ending C:\DOS\SMARTDRV.EXE");
                    Console.WriteLine("Your system will now shut down");
                    Environment.Exit(exitCode);
                }
                if (input.Equals("dir"))
                {
                    Console.WriteLine();
                    Console.WriteLine(" Volume in drive C is MS-DOS_6");
                    Console.WriteLine(" Volume Serial Number is 4A69-401B");
                    Console.WriteLine(@" Directory of C:\");
                    Console.WriteLine("DOS           <DIR>         03-09-91   8:00a");
                    Console.WriteLine("COMMAND  COM         54,645 01-02-91   6:22a");
                    Console.WriteLine("WINA20   386          9,349 01-02-91   6:22a");
                    Console.WriteLine("CONFIG   SYS             71 03-09-91   8:02a");
                    Console.WriteLine("AUTOEXEC BAT             78 03-09-91   8:02a");
                    Console.WriteLine("        5 file(s)          64,153 bytes");
                    Console.WriteLine("                   1,066,074,112 bytes free");
                    Console.WriteLine();
                }
            }
        }
    }
}
