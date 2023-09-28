// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int SetNumber(string message)
{
    Console.WriteLine($"{message}");
    string strNum = Console.ReadLine();
    int num = 0;

    if (int.TryParse(strNum, out num))
    {
        return num;
    }

    System.Console.WriteLine("неверный формат(((");
    return SetNumber(message);
}
string PrintNumbers(int start, int stop)
{
    if (start == stop)
    {

        return Convert.ToString(start);
    }

    string str = Convert.ToString(stop) + ", " + PrintNumbers(start, stop-1);


    return str;
}
int start = 1;
int num = SetNumber("Введите число: ");
Console.WriteLine(PrintNumbers(start, num));
Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int start, int stop)
{
    if (start == stop)
    {

        return start;
    }

    int sum = start + GetSum(start+1, stop);


    return sum;
}
int num1 = SetNumber("Введите первое число: ");
int num2 = SetNumber("Введите первое число: ");
if (num1>num2){
    Console.WriteLine(GetSum(num2, num1));
}
else
{
    Console.WriteLine(GetSum(num1, num2));
}

Console.WriteLine();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkermanFun(int m, int n)
{
   if (m == 0) return n + 1;
  else if (n == 0) return AkermanFun(m - 1, 1);
  else return AkermanFun(m - 1, AkermanFun(m, n - 1));
}

Console.WriteLine($"Результат вычисления функции Аккермана = {AkermanFun(num1, num2)}");
Console.ReadLine();

//О счастливчик!

bool life = true;
string[,] array = {
    {"Какие из перечисленных ниже программ являются антивирусными?", "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
    {"Какого типа графики не существует?", "Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
    {"Когда появился термин «информационные технологии» в современном значении?", "В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
    {"В каком году компанией IBM был выпущен первый в истории жесткий диск?", "В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
    {"Какая поисковая система была самой популярной в 2011 году?", "Yahoo!", "Google", "Bing", "Yandex", "Google"},
    {"Страна лидер по количеству суперкомпьютеров?", "Китай", "США", "Япония", "Россия", "Китай"},
    {"Какого Интернет-браузера не существует?", "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
    {"Какие из клавиш клавиатуры относятся к группе функциональных?", "F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
    {"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?", "200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"},
};
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Clear();
    Console.WriteLine(array[i, 0]);
    Console.WriteLine("Выберите вариант ответа: ");
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        Console.WriteLine($"{j} {array[i, j]}");
    }
    int answer = int.Parse(Console.ReadLine());
    if(array[i, answer] == array[i, array.GetLength(1) - 1])
    {
        Console.WriteLine("Правильный ответ!");
    }
    else
    {
        Console.WriteLine("Ответ неверный!");
        if (life == false)
        {
            break;
        }
        life = false;
    }     
}