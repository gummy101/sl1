// See https://aka.ms/new-console-template for more information
RunApp();

void RunApp()
{
    string[] student3A, student3B;
    student3A = new string[] { "Rahul", "Sheela", "Mukesh", "Afzal", "Ramesh", "Geeta", "Jason", "Robert", "Gopal", "Meera" };
    student3B = new string[] { "Pinky", "Rakesh", "Rafi", "Mumtaz", "Devi", "Sukhi", "Gopi", "Tulsi", "Chandrika", "Ann" };

    string[] subjects = new string[6];
    subjects[0] = "Physics";
    subjects[1] = "Chemistry";
    subjects[2] = "History";
    subjects[3] = "Maths";
    subjects[4] = "English";
    subjects[5] = "Spanish";

    int[] marks = new int[6];
    for (int i = 0; i < 6; i++)
        marks[i] = 100 - (i * 3);

    Console.WriteLine("Students of Class 3A");
    foreach (string student in student3A)
        Console.Write(student + " ");
    Console.WriteLine("");

    Console.WriteLine("Students of Class 3B");
    foreach (string student in student3B)
        Console.Write(student + ", ");
    Console.WriteLine("");

    Console.WriteLine("Marks for Student1");
    int total = 0;
    for (int i = 0; i < 6; i++)
    {
        total += marks[i];
        Console.WriteLine(subjects[i] + " = " + marks[i]);
    }
    Console.WriteLine($"Grade Average = {total/6}%");
}