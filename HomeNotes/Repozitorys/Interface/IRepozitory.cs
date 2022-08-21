using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeNotes.Repozitorys.Interface
{
    public interface IRepozitory
    {
        Notes DisplayInfoNotes(string tag);
        List<string> GetTags();
        //void SaveFile();
       // void LoadFile();
    }
}
