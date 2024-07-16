using task5_additional;

class Program
{
    public static void Main()
    {
        int codePlan;

        Console.WriteLine("Введите код плана лечения:");
        while(!int.TryParse(Console.ReadLine(), out codePlan))
        {
            Console.Clear();
            Console.WriteLine("Ошибка! Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Введите код плана лечения:");
        }

        TreatmentPlan plan = new TreatmentPlan(codePlan);

        Patient patient = new Patient(plan);
        patient.Heal();
    }
}