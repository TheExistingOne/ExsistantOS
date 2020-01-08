using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ExistentOS.Extensions;

namespace ExistentOS.Formatting
{
    class FormatManager
    {
        public static ConsoleColor defaultForeground = ConsoleColor.White;

        private static List<Object> formats = new List<Object>();
        private static List<String> blocks = new List<String>();

        public static void WriteFormattedLine(String write)
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

            int defaultAppearences = write.AllIndexesOf("<default>").Count;
            int lastTo = 0;
            for (int i = 0; i < defaultAppearences; i++)
            {
                int pFrom = write.IndexOf("<default>", lastTo) + "<default>".Length;
                int pTo = write.IndexOf("</default>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(defaultForeground);
                lastTo = pTo;
            }

            int blackAppearences = write.AllIndexesOf("<black>").Count;
            lastTo = 0;
            for (int i = 0; i < blackAppearences; i++)
            {
                int pFrom = write.IndexOf("<black>", lastTo) + "<black>".Length;
                int pTo = write.IndexOf("</black>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Black);
                lastTo = pTo;
            }

            int darkBlueAppearences = write.AllIndexesOf("<dark blue>").Count;
            lastTo = 0;
            for (int i = 0; i < darkBlueAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark blue>", lastTo) + "<dark blue>".Length;
                int pTo = write.IndexOf("</dark blue>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkBlue);
                lastTo = pTo;
            }

            int darkGreenAppearences = write.AllIndexesOf("<dark green>").Count;
            lastTo = 0;
            for (int i = 0; i < darkGreenAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark green>", lastTo) + "<dark green>".Length;
                int pTo = write.IndexOf("</dark green>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkGreen);
                lastTo = pTo;
            }

            int darkCyanAppearences = write.AllIndexesOf("<dark cyan>").Count;
            lastTo = 0;
            for (int i = 0; i < darkCyanAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark cyan>", lastTo) + "<dark cyan>".Length;
                int pTo = write.IndexOf("</dark cyan>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkCyan);
                lastTo = pTo;
            }

            int darkRedAppearences = write.AllIndexesOf("<dark red>").Count;
            lastTo = 0;
            for (int i = 0; i < darkRedAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark red>", lastTo) + "<dark red>".Length;
                int pTo = write.IndexOf("</dark red>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkRed);
                lastTo = pTo;
            }

            int darkMagentaAppearences = write.AllIndexesOf("<dark magenta>").Count;
            lastTo = 0;
            for (int i = 0; i < darkMagentaAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark magenta>", lastTo) + "<dark magenta>".Length;
                int pTo = write.IndexOf("</dark magenta>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkMagenta);
                lastTo = pTo;
            }

            int darkYellowAppearences = write.AllIndexesOf("<dark yellow>").Count;
            lastTo = 0;
            for (int i = 0; i < darkYellowAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark yellow>", lastTo) + "<dark yellow>".Length;
                int pTo = write.IndexOf("</dark yellow>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkYellow);
                lastTo = pTo;
            }

            int grayAppearences = write.AllIndexesOf("<gray>").Count;
            lastTo = 0;
            for (int i = 0; i < grayAppearences; i++)
            {
                int pFrom = write.IndexOf("<gray>", lastTo) + "<gray>".Length;
                int pTo = write.IndexOf("</gray>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Gray);
                lastTo = pTo;
            }

            int darkGrayAppearences = write.AllIndexesOf("<dark gray>").Count;
            lastTo = 0;
            for (int i = 0; i < darkGrayAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark gray>", lastTo) + "<dark gray>".Length;
                int pTo = write.IndexOf("</dark gray>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkGray);
                lastTo = pTo;
            }

            int blueAppearences = write.AllIndexesOf("<blue>").Count;
            lastTo = 0;
            for (int i = 0; i < blueAppearences; i++)
            {
                int pFrom = write.IndexOf("<blue>", lastTo) + "<blue>".Length;
                int pTo = write.IndexOf("</blue>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Blue);
                lastTo = pTo;
            }

            int greenAppearences = write.AllIndexesOf("<green>").Count;
            lastTo = 0;
            for (int i = 0; i < greenAppearences; i++)
            {
                int pFrom = write.IndexOf("<green>", lastTo) + "<green>".Length;
                int pTo = write.IndexOf("</green>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Green);
                lastTo = pTo;
            }

            int cyanAppearences = write.AllIndexesOf("<cyan>").Count;
            lastTo = 0;
            for (int i = 0; i < cyanAppearences; i++)
            {
                int pFrom = write.IndexOf("<cyan>", lastTo) + "<cyan>".Length;
                int pTo = write.IndexOf("</cyan>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Cyan);
                lastTo = pTo;
            }

            int redAppearences = write.AllIndexesOf("<red>").Count;
            lastTo = 0;
            for (int i = 0; i < redAppearences; i++)
            {
                int pFrom = write.IndexOf("<red>", lastTo) + "<red>".Length;
                int pTo = write.IndexOf("</red>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Red);
                lastTo = pTo;
            }

            int magentaAppearences = write.AllIndexesOf("<magenta>").Count;
            lastTo = 0;
            for (int i = 0; i < magentaAppearences; i++)
            {
                int pFrom = write.IndexOf("<magenta>", lastTo) + "<magenta>".Length;
                int pTo = write.IndexOf("</magenta>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Magenta);
                lastTo = pTo;
            }

            int yellowAppearences = write.AllIndexesOf("<yellow>").Count;
            lastTo = 0;
            for (int i = 0; i < yellowAppearences; i++)
            {
                int pFrom = write.IndexOf("<yellow>", lastTo) + "<yellow>".Length;
                int pTo = write.IndexOf("</yellow>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Yellow);
                lastTo = pTo;
            }

            int whiteAppearences = write.AllIndexesOf("<white>").Count;
            lastTo = 0;
            for (int i = 0; i < whiteAppearences; i++)
            {
                int pFrom = write.IndexOf("<white>", lastTo) + "<white>".Length;
                int pTo = write.IndexOf("</white>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.White);
                lastTo = pTo;
            }

            for (int i = 0; i < blocks.Count; i++)
            {
                Console.ForegroundColor = (ConsoleColor)formats[i];
                Console.Write((String)blocks[i]);
            }

            Console.WriteLine("");

            formats.Clear();
            blocks.Clear();

            Console.ForegroundColor = defaultForeground;
        }

        public static void WriteFormatted(String write)
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

            int defaultAppearences = write.AllIndexesOf("<default>").Count;
            int lastTo = 0;
            for (int i = 0; i < defaultAppearences; i++)
            {
                int pFrom = write.IndexOf("<default>", lastTo) + "<default>".Length;
                int pTo = write.IndexOf("</default>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(defaultForeground);
                lastTo = pTo;
            }

            int blackAppearences = write.AllIndexesOf("<black>").Count;
            lastTo = 0;
            for (int i = 0; i < blackAppearences; i++)
            {
                int pFrom = write.IndexOf("<black>", lastTo) + "<black>".Length;
                int pTo = write.IndexOf("</black>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Black);
                lastTo = pTo;
            }

            int darkBlueAppearences = write.AllIndexesOf("<dark blue>").Count;
            lastTo = 0;
            for (int i = 0; i < darkBlueAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark blue>", lastTo) + "<dark blue>".Length;
                int pTo = write.IndexOf("</dark blue>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkBlue);
                lastTo = pTo;
            }

            int darkGreenAppearences = write.AllIndexesOf("<dark green>").Count;
            lastTo = 0;
            for (int i = 0; i < darkGreenAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark green>", lastTo) + "<dark green>".Length;
                int pTo = write.IndexOf("</dark green>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkGreen);
                lastTo = pTo;
            }

            int darkCyanAppearences = write.AllIndexesOf("<dark cyan>").Count;
            lastTo = 0;
            for (int i = 0; i < darkCyanAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark cyan>", lastTo) + "<dark cyan>".Length;
                int pTo = write.IndexOf("</dark cyan>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkCyan);
                lastTo = pTo;
            }

            int darkRedAppearences = write.AllIndexesOf("<dark red>").Count;
            lastTo = 0;
            for (int i = 0; i < darkRedAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark red>", lastTo) + "<dark red>".Length;
                int pTo = write.IndexOf("</dark red>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkRed);
                lastTo = pTo;
            }

            int darkMagentaAppearences = write.AllIndexesOf("<dark magenta>").Count;
            lastTo = 0;
            for (int i = 0; i < darkMagentaAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark magenta>", lastTo) + "<dark magenta>".Length;
                int pTo = write.IndexOf("</dark magenta>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkMagenta);
                lastTo = pTo;
            }

            int darkYellowAppearences = write.AllIndexesOf("<dark yellow>").Count;
            lastTo = 0;
            for (int i = 0; i < darkYellowAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark yellow>", lastTo) + "<dark yellow>".Length;
                int pTo = write.IndexOf("</dark yellow>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkYellow);
                lastTo = pTo;
            }

            int grayAppearences = write.AllIndexesOf("<gray>").Count;
            lastTo = 0;
            for (int i = 0; i < grayAppearences; i++)
            {
                int pFrom = write.IndexOf("<gray>", lastTo) + "<gray>".Length;
                int pTo = write.IndexOf("</gray>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Gray);
                lastTo = pTo;
            }

            int darkGrayAppearences = write.AllIndexesOf("<dark gray>").Count;
            lastTo = 0;
            for (int i = 0; i < darkGrayAppearences; i++)
            {
                int pFrom = write.IndexOf("<dark gray>", lastTo) + "<dark gray>".Length;
                int pTo = write.IndexOf("</dark gray>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.DarkGray);
                lastTo = pTo;
            }

            int blueAppearences = write.AllIndexesOf("<blue>").Count;
            lastTo = 0;
            for (int i = 0; i < blueAppearences; i++)
            {
                int pFrom = write.IndexOf("<blue>", lastTo) + "<blue>".Length;
                int pTo = write.IndexOf("</blue>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Blue);
                lastTo = pTo;
            }

            int greenAppearences = write.AllIndexesOf("<green>").Count;
            lastTo = 0;
            for (int i = 0; i < greenAppearences; i++)
            {
                int pFrom = write.IndexOf("<green>", lastTo) + "<green>".Length;
                int pTo = write.IndexOf("</green>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Green);
                lastTo = pTo;
            }

            int cyanAppearences = write.AllIndexesOf("<cyan>").Count;
            lastTo = 0;
            for (int i = 0; i < cyanAppearences; i++)
            {
                int pFrom = write.IndexOf("<cyan>", lastTo) + "<cyan>".Length;
                int pTo = write.IndexOf("</cyan>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Cyan);
                lastTo = pTo;
            }

            int redAppearences = write.AllIndexesOf("<red>").Count;
            lastTo = 0;
            for (int i = 0; i < redAppearences; i++)
            {
                int pFrom = write.IndexOf("<red>", lastTo) + "<red>".Length;
                int pTo = write.IndexOf("</red>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Red);
                lastTo = pTo;
            }

            int magentaAppearences = write.AllIndexesOf("<magenta>").Count;
            lastTo = 0;
            for (int i = 0; i < magentaAppearences; i++)
            {
                int pFrom = write.IndexOf("<magenta>", lastTo) + "<magenta>".Length;
                int pTo = write.IndexOf("</magenta>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Magenta);
                lastTo = pTo;
            }

            int yellowAppearences = write.AllIndexesOf("<yellow>").Count;
            lastTo = 0;
            for (int i = 0; i < yellowAppearences; i++)
            {
                int pFrom = write.IndexOf("<yellow>", lastTo) + "<yellow>".Length;
                int pTo = write.IndexOf("</yellow>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.Yellow);
                lastTo = pTo;
            }

            int whiteAppearences = write.AllIndexesOf("<white>").Count;
            lastTo = 0;
            for (int i = 0; i < whiteAppearences; i++)
            {
                int pFrom = write.IndexOf("<white>", lastTo) + "<white>".Length;
                int pTo = write.IndexOf("</white>", lastTo);

                blocks.Add(write.Substring(pFrom, pTo - pFrom));
                formats.Add(ConsoleColor.White);
                lastTo = pTo;
            }

            for (int i = 0; i < blocks.Count; i++)
            {
                Console.ForegroundColor = (ConsoleColor)formats[i];
                Console.Write((String)blocks[i]);
            }

            formats.Clear();
            blocks.Clear();

            Console.ForegroundColor = defaultForeground;
        }
    }
}
