// Palindrome - determine if string is a valid palindrome
// Example: kajak, level, radar, Ala, kobyła ma mały bok, a tu mam mamuta, Zakopane na pokaz, a kilku tu kilka, atak kata, nawijaj Iwan

string CheckPalindromeV1(string input)
{
    if (string.IsNullOrWhiteSpace(input))
        return "Not palindrome";
    
    input = input.Replace(" ","").ToLower();
    int n = input.Length % 2 == 0 ? input.Length / 2 : (input.Length - 1) / 2;

    for (var i = 0; i < n; ++i)
    {
        if (input[i] != input[input.Length - 1 - i])
        {
            Console.WriteLine($"{input[i]} vs {input[input.Length - 1 - n]}");
            return "Not palindrome";
        }
    }
    return "Palindrome";
}

bool CheckPalindromeV2(string input)
{
    if (string.IsNullOrWhiteSpace(input))
        return false;
    
    input = input.Replace(" ","").ToLower();
    var reversedInput = new string(input.Reverse().ToArray());
    return input == reversedInput;
}

var input = "nawijaj Iwan";
var result = CheckPalindromeV1(input);
var result2 = CheckPalindromeV2(input);
Console.WriteLine(result);
Console.WriteLine(result2);
 