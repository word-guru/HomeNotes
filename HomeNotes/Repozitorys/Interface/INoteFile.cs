using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeNotes.Repozitorys.Interface
{
    public interface INoteFile
    {
        void SaveFile(string text);
        void LoadFile();
    }
}
