# PalindromeNumber
Second day on LeetCode this is challenge number 9 (going for the easy ones first)

Program Class:

The Program class is the entry point of the application.
It contains the Main method, which is the starting point of execution when you run the application.
User Input:

The application begins by displaying "Palindrome Checker" to the console to indicate its purpose.
It then prompts the user to enter a number with the line Console.Write("Enter a number: ");.
Input Validation:

It uses int.TryParse to attempt to parse the user's input as an integer.
If the input can be successfully parsed as an integer, it stores the parsed value in the number variable. Otherwise, it displays an error message.
Solution Class:

The Solution class contains the IsPalindrome method, which is responsible for checking whether a given number is a palindrome.
Palindrome Checking:

Inside the IsPalindrome method:
It first checks if the input number x is negative. If it is, the method immediately returns false because negative numbers are not palindromes.
It then initializes two variables: original to store the original input value and reversed to store the reversed version of the number.
The method then enters a while loop that runs as long as x is greater than 0. In each iteration, it extracts the last digit of x using the modulus operator (%) and appends it to the reversed variable, effectively reversing the number. It also removes the last digit from x.
After the loop, it compares the original value with the reversed value. If they are equal, it returns true, indicating that the number is a palindrome; otherwise, it returns false.
Display Result:

Back in the Main method, if the user input was successfully parsed as an integer, it creates an instance of the Solution class and uses the IsPalindrome method to check if the entered number is a palindrome.
Depending on the result, it displays a message indicating whether the number is a palindrome or not.
Error Handling:

If the user enters invalid input (i.e., non-integer input), it displays an "Invalid input" error message.
Running the Application:

You can run this application in a C# development environment (e.g., Visual Studio or Visual Studio Code).
When you run the program, it will execute the Main method, and you can input a number to check if it's a palindrome.
In summary, this application takes user input, checks if the input is a valid integer, and then uses the provided IsPalindrome method to determine whether the entered number is a palindrome or not. It provides a simple user interface for this task and displays the result to the user.
