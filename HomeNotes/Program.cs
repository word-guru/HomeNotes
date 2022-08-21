
using HomeNotes;
using Ninject;

IKernel kernel = new StandardKernel(new NoteModule());
var note = kernel.Get<Actions>();

note.Tags();

string str = "";
Console.Write("\nДля просмотра заметки введите соответствующий тег: ");
str = Console.ReadLine();
Console.WriteLine("\n");
note.Info(str);

Console.Write("\nСохранить в файл:(y/n)");
string menu = Console.ReadLine();
if(menu == "y")
    note.Save();

Console.Write("Показать информацию из файла(y/n)");
menu = Console.ReadLine();
Console.WriteLine();
note.Load();
