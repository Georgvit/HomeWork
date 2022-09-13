//Метод создания массива с пользовательским вводом элементов
void Array(string[] massif)
{
    for (int countElement = 0; countElement < massif.Length; countElement++)
    {
        Console.WriteLine("Введите элеммент массива:");
        massif[countElement] = Console.ReadLine();

    }


}
