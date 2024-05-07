List<string> wordies = new List<string> { "one", "two", "THREE", "ei221", "EI223" };
var tempList = GetOnlyUpperCaseWords(wordies);
foreach (var phrase in tempList)
{
    Console.WriteLine(phrase);
}
Console.ReadKey();

List<string> GetOnlyUpperCaseWords(List<string> words)
{
    List<string> result = new List<string>();
    foreach (var word in words)
    {
        for (var i = 0; i < word.Length; i++)
        {
            if (Char.IsUpper(word[i]) == true)
            {
                if (result.Contains(word))
                {
                    continue;
                }
                result.Add(word);
            }
            else
            {
                result.Remove(word);
                break;
            }
            
        }
    }
    return result;
    //your code goes here
}