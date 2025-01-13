using KnowledgeCheck2;
using System.Data.Common;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Grades>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new Grades();

    Console.WriteLine("Enter the students name");
    myClass.Name = Console.ReadLine();
    
    Console.WriteLine("Enter the students grade from A-F");
    myClass.Grade = Console.ReadLine();
    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()
foreach (var record in recordList)
{
    Console.WriteLine($"{record.Name} recieved a grade of letter {record.Grade}");
}


