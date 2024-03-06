
/*kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,
 3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız
*/

Console.Write("Enter the number of students: ");
int studentCount = int.TryParse(Console.ReadLine(), out int number) ? number : 0;

for (int i = 0; i < studentCount; i++)
{
    Console.WriteLine($"\nEnter details for student #{i + 1}");
    string name = Prompt("Student first name: ");
    string lastName = Prompt("Student last name: ");
    double exam1 = PromptForExamScore("1st exam score: ");
    double exam2 = PromptForExamScore("2nd exam score: ");
    double exam3 = PromptForExamScore("3rd exam score: ");

    double average = CalculateAverage(exam1, exam2, exam3);
    Console.WriteLine($"{name} {lastName}'s average score: {average:F2}");


    static string Prompt(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    static double CalculateAverage(double score1, double score2, double score3)
    {
        return (score1 + score2 + score3) / 3;
    }

    static double PromptForExamScore(string message)
    {
        double score;
        do
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (double.TryParse(input, out score) && score >= 0 && score <= 100)
            {
                break; // Valid score
            }
            Console.WriteLine("Invalid score. Please enter a value between 0 and 100.");
        } while (true);
        return score;
    }
}