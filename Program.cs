namespace Ejednevnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Note Onenote = new Note("День 1 - Утро", "10 практическая 50%", DateTime.Now.Date);
            Note Onenote1 = new Note("День 1 - Вечер", "10 практическая 80%", DateTime.Now.Date);
            Note SecondNote = new Note("День 2", "10 практическая 90%", DateTime.Now.Date.AddDays(1));
            Note ThirdNote = new Note("День 3", "10 практическая 100%", DateTime.Now.Date.AddDays(2));
            Note FourthNote = new Note("Сдача зачёта", "Всем гг, помянем", DateTime.Now.Date.AddDays(3));
            List<Note> Notes = new List<Note>();
            Notes.Add(Onenote);
            Notes.Add(Onenote1);
            Notes.Add(SecondNote);
            Notes.Add(ThirdNote);
            Notes.Add(FourthNote);
            Program.Function(Notes);
        }
        static void Function(List<Note> notes)
        {
            DateTime day = DateTime.Now.Date;
            int pos = 0;
            while (true)
            {
                if (pos < 1)
                {
                    pos = 1;
                }
                int numofnotes = 0;
                foreach (Note i in notes)
                {
                    if (i.Date == day)
                    {
                        numofnotes++;
                    }

                }

                Console.Write("День: ");
                Console.Write(day.ToString());

                for (int i = 1; i <= numofnotes; i++)
                {
                    for (int j = 0; j < notes.Count; j++)
                    {
                        if (notes[j].Date == day)
                        {
                            Console.SetCursorPosition(2, i);
                            Console.WriteLine(i.ToString() + ". " + notes[j].Name);
                            i++;
                        }
                    }
                }


                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");


                if (key.Key == ConsoleKey.Enter)
                {
                    if (numofnotes != 0)
                    {
                        if (pos != (numofnotes + 1))
                        {
                            List<Note> notesofday = new List<Note>();
                            for (int j = 0; j < notes.Count; j++)
                            {
                                if (notes[j].Date == day)
                                {
                                    notesofday.Add(notes[j]);
                                }
                            }
                            Console.Clear();
                            notesofday[pos - 1].GetInfo();
                        }
                    }

                }
                if (key.Key == ConsoleKey.Escape) { break; }
                if (key.Key == ConsoleKey.LeftArrow) { day = day.AddDays(-1); }
                if (key.Key == ConsoleKey.RightArrow) { day = day.AddDays(1); }

                Console.Clear();
            }
        }
    }
}