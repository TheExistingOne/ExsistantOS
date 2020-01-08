using System;
using System.Collections.Generic;
using ExistentOS.Formatting;
using ExistentOS.Extensions;
using Sys = Cosmos.System;

namespace ExistentOS
{
    public class Kernel : Sys.Kernel
    {
        //Black <black>
        //DarkBlue <dark blue>
        //DarkGreen <dark green>
        //DarkCyan <dark cyan>
        //DarkRed <dark red>
        //DarkMagenta <dark magenta>
        //DarkYellow <dark yellow>
        //Gray <gray>
        //DarkGray <dark gray>
        //Blue <blue>
        //Green <green>
        //Cyan <cyan>
        //Red <red>
        //Magenta <magenta>
        //Yellow <yellow>
        //White <white>
        //Default <default>

        protected List<ManagedMemoryBlock> allocatedBlocks;

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔╗  ╔╗   ╔╗");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║║  ║║   ╚╝   ExistentOS");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║╠══╣║   ╔╗   Half Anarchy");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("║║  ║║   ║║   Beta 0.1");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("╚╝  ╚╝   ╚╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            FormatManager.WriteFormattedLine("<yellow>Memory: " + MemoryManager.GetFreeMemory() + " Bytes Free, " + MemoryManager.GetUsedMemory() +" Bytes in use</yellow>");
            Console.WriteLine("Ready.");
            Console.WriteLine();
        }

        protected override void Run()
        {
            FormatManager.WriteFormatted("<default>Enter Command: </default>");
            var input = Console.ReadLine();

            if (input == "version")
            {
                Console.WriteLine("Beta 0.1");
            }
            else if (input == "memory get")
            {
                Console.WriteLine("Memory: " + MemoryManager.GetFreeMemory() + " Bytes Free, " + MemoryManager.GetUsedMemory() + " Bytes in use");
            }
            else if (input == "memory allocate")
            {
                if (input.Substring(15).Contains("1") || input.Substring(15).Contains("2") || input.Substring(15).Contains("3") || input.Substring(15).Contains("4") || input.Substring(15).Contains("5") || input.Substring(15).Contains("6") || input.Substring(15).Contains("7") || input.Substring(15).Contains("8") || input.Substring(15).Contains("9") || input.Substring(15).Contains("0"))
                {
                    uint allocate;
                    UInt32.TryParse(input.Substring(15), out allocate);
                    if (allocate < MemoryManager.GetFreeMemory())
                    {
                        allocatedBlocks.Add(new ManagedMemoryBlock(allocate));
                        Console.WriteLine("Allocated " + allocate + " Bytes");
                    }
                    else
                    {
                        Console.WriteLine("<red>Not enough memory available</red>");
                    }
                }
                else
                {
                    FormatManager.WriteFormattedLine("<red>Error: No value passed</red>");
                }
            }
            else if (input == "clear")
            {
                Console.Clear();
            }
            else if (input == "shutdown")
            {
                Sys.Power.Shutdown();
            }
            else if (input == "reboot")
            {
                Sys.Power.Reboot();
            }
            else if (input == "help")
            {
                Console.WriteLine("Availible Commands");
                Console.WriteLine();
                Console.WriteLine("version - prints version of os");
                Console.WriteLine("memory get - returns current available memory");
                Console.WriteLine("memory allocate <bytes> - allocates a block of memory");
                Console.WriteLine("clear - clears console");
                Console.WriteLine("shutdown - shuts down the computer");
                Console.WriteLine("reboot - reboots the computer");
                Console.WriteLine("help - prints this guide");
            }
            else
            {
                FormatManager.WriteFormattedLine("<red>Invalid Command: Try using the help command</red>");
            }
        }
    }
}
