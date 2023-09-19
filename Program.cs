int[] PutArray(int size, int min, int max){
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0;i < size; i++){
        array[i] = rand.Next(min,max+1);
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0;i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
}

int EvenCount(int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            result++;
        } 
    }
    return result;
}

int EvenSum(int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i += 2){
        result += array[i];
    }
    return result;
}

          //First task//
// int[] array = PutArray(10, 100, 1000);
// ShowArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine(EvenCount(array));

           //Second task//
// int[] array = PutArray(5, 0, 100);
// ShowArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine(EvenSum(array));

double[] PutArray1(int size){
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0;i < size; i++){
        array[i] = rand.NextDouble(0,1) * 100;
    }

    return array;
}

void ShowArray1(double[] array){
    for (int i = 0;i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
}

double[] array = PutArray1(6);
ShowArray1(array);