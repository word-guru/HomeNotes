using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeNotes.Repozitorys.Interface;

namespace HomeNotes.Repozitorys
{
    public class Repozitory : IRepozitory
    {
        private List<Notes> notes = new List<Notes>()
        {
            new Notes()
            {
                Name = "Поход в магазин",
                Text = "Молоко, Хлеб",
                DateOfCreation = DateTime.Today,
                Tags = "#Магазин"
            },
            new Notes()
            {
                Name = "На работу",
                Text = "придти на работу",
                DateOfCreation = DateTime.Today,
                Tags = "#Работа"
            },
            new Notes()
            {
                Name = "Цель дня",
                Text = "Уйти с работы",
                DateOfCreation = DateTime.Today,
                Tags = "#Цель"
            },
        };
        public Notes DisplayInfoNotes(string tag)
        {
            Notes not = new Notes();
            foreach (var note in notes)
            {
                if (tag == note.Tags)
                {
                    not.Name = note.Name;
                    not.Text = note.Text;
                    not.DateOfCreation = note.DateOfCreation;
                    not.Tags = note.Tags;
                }
            }
            return not;
        }

        public List<string> GetTags()
        {
            List<string> tags = new List<string>();

            foreach (var note in notes)
                tags.Add(note.Tags);

            return tags;
        }
    }
}
