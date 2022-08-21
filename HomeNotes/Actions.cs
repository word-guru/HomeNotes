using HomeNotes.Repozitorys.Interface;
using System.Xml.Linq;

namespace HomeNotes
{
    public class Actions
    {
        private readonly IRepozitory _repozitory;
        private readonly INoteFile _noteFile;
        private Notes _notes;
        private List<string> _tags;
        
        public Actions(IRepozitory repozitory, INoteFile noteFile)
        {
            _repozitory = repozitory;
            _noteFile = noteFile;
            _notes = new Notes();
            _tags = new List<string>();
        }

        public void Info(string tag)
        {
           _notes = _repozitory.DisplayInfoNotes(tag);
            Console.WriteLine($"{_notes.Name}:");
            Console.WriteLine($"{_notes.Text}.");
            Console.WriteLine($"Дата: {_notes.DateOfCreation.ToString("d")}\n\n");
        }

        public void Tags()
        {
           _tags = _repozitory.GetTags();
            Console.WriteLine("Теги:");
            foreach ( string tag in _tags )
                Console.WriteLine($"{tag}");
        }
        public void Save()
        {
            string text = "";
            text = $"Name: {_notes.Name}\nText: {_notes.Text}\nDate: {_notes.DateOfCreation.ToString("d")}\nTag: {_notes.Tags}";
            _noteFile.SaveFile(text);
        }
        public void Load()
        {
            _noteFile.LoadFile();
        }
    }
}
