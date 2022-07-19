//программa которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrome(int num)
{

  if(num % 10000 == num / 10) return true;
  if(num % 1000 == num / 100); 
  else return false;

}

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool nam = Palindrome(number);
