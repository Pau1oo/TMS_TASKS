namespace task11
{
    public class Program
    {
        static void Main()
        {
            try
            {
                if(InputData.Verify(InputData.Input("логин"), 
                                    InputData.Input("пароль"), 
                                    InputData.Input("пароль повторно")))
                {
                    Console.WriteLine("Регистрация прошла успешно!");
                }
            }
            catch(WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
