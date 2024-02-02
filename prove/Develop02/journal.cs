namespace JournalApp;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Journal {
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string[] import)
    {
        entries = new List<Entry>();
        foreach(var line in import)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

    public void Display()
    {
        foreach(var entry in entries){
            Console.WriteLine(entry.Display());
        }
    }

    public string[] Export(){
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.Export());
        }
        return exportLines.ToArray();
    }
}