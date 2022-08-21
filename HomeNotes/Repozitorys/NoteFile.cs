using HomeNotes.Repozitorys.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeNotes.Repozitorys
{
    public class NoteFile : INoteFile
    {
        
        public void LoadFile()
        {
            string path = @"E:\ASP.NET\HomeNotes\HomeNotes\File\TextFile.txt";
            var regex = new Regex(@"[a-zA-Z]+");
            foreach (var item in File.ReadLines(path))
            {
                if (regex.IsMatch(item))
                {
                    var str = item.Split(':');
                    Console.WriteLine($"{str[1]}");
                }
            }
        }

        public void SaveFile(string text)
        {
            string path = @"E:\ASP.NET\HomeNotes\HomeNotes\File\Notes.txt";
            File.WriteAllText(path, text);
        }
    }
}
