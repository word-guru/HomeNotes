using HomeNotes.Repozitorys;
using HomeNotes.Repozitorys.Interface;
using Ninject.Modules;


namespace HomeNotes
{
    public class NoteModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepozitory>().To<Repozitory>();
            Bind<INoteFile>().To<NoteFile>();
        }
    }
}
