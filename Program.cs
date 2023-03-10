class Program{

    static void Main(string[] args){
        var txt = Console.ReadLine();
        string[] data = Calculator.getInputData();
        int res = Calculator.Calculate(data);
        Console.WriteLine(res);

        Console.WriteLine("Kraj!");
        Console.WriteLine("Kraj33!");
        Console.WriteLine("Kraj!");
    
    }

    static void Hello(){
        Console.WriteLine("hello world!");
    }

}

