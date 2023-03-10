class Calculator{

    public static string[] getInputData(){
        var input = Console.ReadLine();
        while (input == null || input == ""){
            Console.WriteLine("Greska u unosu!");
            input = Console.ReadLine();
        }
        return input.Split(' ');
    }

    public static int Calculate(string[] data){
        int num1 = Convert.ToInt32(data[0]);
        int num2 = Convert.ToInt32(data[2]);

        switch (data[1]){
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                return num1 / num2;
            case "^":
                return num1 ^ num2;
            default:
                return -1;
        }
    }


}