using System.IO; 

class Journal{
    Page page = new Page();
    private string fileName = "";
    private List<string> journalEntries = new List<string>();
    private string currentEntry;

    public Journal(){

    }

    public void AddEntry(){
        currentEntry = page.createEntry();
        journalEntries.Add(currentEntry);
    }

    public void SaveFile(){
        Console.WriteLine("What is the journal file?");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(string entry in journalEntries){
                    outputFile.WriteLine($"{entry}");
                }
            }

    }
    public void LoadFile(){
        Console.WriteLine("What is the journal file?");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines){
            journalEntries.Add(line);
        }
    }
    


    public void Display(){
        foreach(string entry in journalEntries){
            Console.WriteLine(entry);
        }
        
    }
}