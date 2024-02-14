//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

string DivideNum(int a)
{
    if(a%3==0 && a % 7 == 0)
    {
        return "Can be divided";
    }
    else
    {
        return "Cannot be divided";
    }
   
}
//int n = 21;
//Console.WriteLine(DivideNum(n));

//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

int SumOfNums(int a,int b)
{
    int sum = 0;

    if(a%2==0 && b % 2 == 0)
    {
        sum = a + b;
    }
    return sum;
}

//int n = 6;
//int m = 4;
//Console.WriteLine(SumOfNums(n,m))


//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

int CountOfOdd(int a, int b)
{
    int count = 0;
    for (int i = a+1; i < b; i++)
    {
        if(i%2 != 0)
        {
            count++;
        }
    }
    return count;
}

//int n = 1;
//int m = 7;
//Console.WriteLine(CountOfOdd(n,m));


//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

int SumOfOdd(int a,int b)
{
    int sum = 0;
    for (int i = a+1; i < b; i++)
    {
        sum += i;
    }
    return sum;
}

//int n = 1;
//int m = 9;
//Console.WriteLine(SumOfOdd(n,m));


//5)Verilmish arrayin icindeki tek ededlerin cemini tapin.

int ArrOdd(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        if(number%2 != 0)
        {
            sum += number;
        }
    }
    return sum;
}

//int[] digits = { 1, 2, 3, 7, 11 };
//Console.WriteLine(ArrOdd(digits));


//6)Verilmish arrayin icindeki cut ededlerin sayini tapin.

int ArrEvenCount(int[] numbers)
{
    int count = 0;
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

//int[] ages = { 2, 6, 5, 12, 22, 15 };
//Console.WriteLine(ArrEvenCount(ages));


//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

string PrimeOrComposite(int n)
{
   
    if (n < 2)
    {
        return "Not Prime nor Composite";
    }
    else if (n == 2)
    {
        return "Is Prime";
    }
    else
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return "Is Composite";
            }
        }
        return "Is Prime";
    }
}

//int n = 10;
//Console.WriteLine(PrimeOrComposite(n));


//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.

string PowerOfTwo(int n)
{
    if (n == 1)
    {
        return "Is power of two";
    }
    if (n < 1)
    {
        return "Is not power of two";
    }
    else if(n>= 2)
    {
        for (int i = 2; i <= n; i*=2)
        {
            if (n % i != 0)
            {
                return "Is not power of two";
            }
        }
    }
    return "Is  power of two";
}

//int n = 16;
//Console.WriteLine(PowerOfTwo(n));


//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.

int MultiplyOfArr(int[] numbers)
{
    int result=1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]>1 && numbers[i] < 20)
        {
            result *= numbers[i];
        }
    }
    return result;
}

//int[] numbers = { 10, 2, 21, 20, 22 };
//Console.WriteLine(MultiplyOfArr(numbers));


//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

int SquareOfEven(int[] numbers)
{
    int result = 1;
    int sum = 0;
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;
            result = sum * sum;
        }
    }
    return result;
}

//int[] digits = { 1, 2, 2, 5 };
//Console.WriteLine(SquareOfEven(digits));


//11) Temp qebul eden method yazirsiz. Return type olan method olmalidir.
//Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.

string CheckTemprature(int temp)
{
    if (temp < 20)
    {
        return "Soyuq";
    }
    else if (temp == 20)
    {
        return "Mulayim";
    }
    return "Isti";
}

//int temperature = 21;
//Console.WriteLine(CheckTemprature(temperature));


//12)Methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin.

int CountOfNums(int a,int b)
{
    int count = 0;
    for (int i = a+1; i < b; i++)
    {
        count++;
    }
    return count;
}

//int a = 1;
//int b = 5;
//Console.WriteLine(CountOfNums(a,b));


//13)Method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin.

int SumOfElements(int[] elements1, int[] elements2)
{
    int sum1 = 0;
    int sum2 = 0;
    foreach (var element1 in elements1)
    {
        sum1 += element1;
    }
    foreach (var element2 in elements2)
    {
        sum2 += element2;
    }
    return  sum1 + sum2;
}

//int[] numbers1 = { 1, 2, 3 };
//int[] numbers2 = { 2, 3, 4 };

//Console.WriteLine(SumOfElements(numbers1,numbers2));


//14)Methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin.

int SquareOfNumber(int a)
{
    return a * a;
}

//Console.WriteLine(SquareOfNumber(6));


//15)Methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.

int SumOfEvenInArray (int a)
{
    int sum = 0;
    for (int i = 1; i < a; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    return sum;
}

//int a = 6;
//Console.WriteLine(SumOfEvenInArray(a));