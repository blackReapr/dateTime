#region Task 1

int[] numbers = { 1, 2, 3, 4, 5, 6 };

static int[] ReverseArray(int[] numbers)
{
    int[] result = new int[numbers.Length];
    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        result[numbers.Length - i - 1] = numbers[i];
    }
    return result;
}

#endregion

#region Task 2

Console.WriteLine("Enter your birthday: ");
DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
DateTime now = DateTime.Now;
int age = (now - dateTime).Days / 365;

Console.WriteLine($"Your age: {age}");
#endregion

#region Task 3
Console.WriteLine("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());
bool isLeapYear = false;
if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            isLeapYear = true;
        }
    }
    else
    {
        isLeapYear = true;
    }
}
Console.WriteLine("The year is" + (isLeapYear ? " " : " not ") + "a leap year");
#endregion