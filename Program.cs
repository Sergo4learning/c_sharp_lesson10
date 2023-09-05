// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

const string quote = "\"";
string[] get_array(int num)
{
    string[] new_array=new string[num];
    for (int i=1; i<=num; i++)
    {
        Console.Write("Введите "+i+" элемент массива:");
        new_array[i-1] = Console.ReadLine();
    }
    return  new_array;
}
string[] get_3_letter_words_array (int num, string[] words_array, ref int num2)
{
    string[] res_array=new string[num];    
    for (int i=1; i<= num; i++)
    {
        if ( words_array[i-1].Length <= 3)
        {
            res_array[num2-1]=words_array[i-1];
            num2++;
        }
    }
    num2--;
    return res_array;
}
void output_array(string[] arr, int num)
{
    if (num==1)
    {
        Console.Write("["+ quote);        
        Console.WriteLine(arr[num-1]+ quote+"]");        
    }
    else
    {
    Console.Write("[");    
    for (int i=1; i<num;i++)
    {
        Console.Write(quote+arr[i-1]+ quote+", ");
    }
    Console.WriteLine(quote+arr[num-1]+ quote+"]");    
    }    
}
int num2=1;
Console.Write("Введите размерность массива:");
int arr_dim = Convert.ToInt32(Console.ReadLine());
string[] word_array=new string[arr_dim];
word_array=get_array(arr_dim);
string[] my_array=new string[arr_dim];
my_array=get_3_letter_words_array (arr_dim, word_array, ref num2);
output_array(word_array, arr_dim);
Console.WriteLine("");    
output_array(my_array, num2);