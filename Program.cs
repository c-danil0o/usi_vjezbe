class Program{

    static void Main(string[] args){
        string[] data = Calculator.getInputData();
        int res = Calculator.Calculate(data);
        Console.WriteLine(res);
    }

}

