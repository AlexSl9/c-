
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int result1 = doOperation(6, DoubleNumber); // 12
Console.WriteLine(result1);
int result2 = doOperation(6, SquareNumber); // 36
Console.WriteLine(result2);
int doOperation(int n, Func<int, int> operation) => operation(n); //Метод DoOperation() в качестве параметра принимает делегат Func<int, int>, то есть ссылку на метод, который принимает число int и возвращает также значение int.
int DoubleNumber(int n) => 2 * n;
int SquareNumber(int n) => n * n;

Func<int, int, string> creatingString = (a, b) => $"{a}{b}";//Здесь переменная createString представляет лямбда-выражение, которое принимает два числа int и возвращает строку, то есть представляет делегат Func<int, int, string>.
Console.WriteLine(creatingString(3,5));

Predicate<int> isPosistive = (int x) => x > 0;
Console.WriteLine(isPosistive(-22));


DoOperation(4, 5, Add);
void DoOperation(int a, int b, Action<int, int> op) => op(a, b);
void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x*y}");

public delegate void Action();
public delegate void Action<in T>(T obj); //Как правило, этот делегат передается в качестве параметра метода и предусматривает вызов определенных действий в ответ на произошедшие действия. Например:

delegate bool Predicate <in T>(T obj); //Как правило, используется для сравнения, сопоставления некоторого объекта T определенному условию. В качестве выходного результата возвращается значение true, если условие соблюдено, и false, если не соблюдено

/*
TResult Func<out TResult>()
TResult Func<in T, out TResult>(T arg)
TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2)
TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3)
TResult Func<in T1, in T2, in T3, in T4, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
 */