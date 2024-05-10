#region previousApp
//bool appStatus = true;
//List<string> usersCurrentTodos = new List<string>();

//do
//{
//    string usersChoice;
//    Console.WriteLine("\n[S]ee all todos");
//    Console.WriteLine("[A]dd a todo");
//    Console.WriteLine("[R]emove a todo");
//    Console.WriteLine("[E]xit");
//    usersChoice = Console.ReadLine();
//    appStatus = CheckChosenOption(usersChoice, usersCurrentTodos);
//}
//while (appStatus);

//bool CheckChosenOption(string choiceGotten, List<string> usersCurrentTodos)
//{
//    bool result = true;
//    if (choiceGotten == "s" || choiceGotten == "S")
//    {
//        UserSeeToDos(usersCurrentTodos);
//    }
//    else if (choiceGotten == "a" || choiceGotten == "A")
//    {
//        UserAddToDos(usersCurrentTodos);
//    }
//    else if (choiceGotten == "r" || choiceGotten == "R")
//    {
//        UserRemoveToDos(usersCurrentTodos);
//    }
//    else if (choiceGotten == "e" || choiceGotten == "E")
//    {
//        result = false;
//    }
//    else if (choiceGotten == "")
//    {
//        Console.WriteLine("must insert input!");
//    }
//    else
//    {
//        Console.WriteLine("\nPlease give correct input! \n");
//    }
//    return result;
//}

//bool UserSeeToDos(List<string> listToOperate)
//{

//    if (listToOperate.Count > 0)
//    {
//        for (int i = 0; i < listToOperate.Count; i++)
//        {
//            Console.WriteLine((i + 1) + ". " + listToOperate[i]);
//        }
//    }
//    else
//    {
//        Console.WriteLine("\nList is empty! \n");
//    }
//    return true;
//}
//bool UserAddToDos(List<string> listToOperate)
//{
//    string toDo = "";
//    bool doesSameOneExist = false;
//    do
//    {
//        doesSameOneExist = false;
//        Console.WriteLine("What is ToDo you want to add?");
//        toDo = Console.ReadLine();
//        if (toDo == "")
//        {
//            Console.WriteLine("description cannot be empty!\n");
//        }
//        else if (listToOperate.Contains(toDo))
//        {
//            Console.WriteLine("ToDo with the same description already exists! \n");
//            doesSameOneExist = true;
//        }

//    } while (toDo == "" || doesSameOneExist);
//    listToOperate.Add(toDo);

//    return true;
//}
//bool UserRemoveToDos(List<string> listToOperate)
//{
//    int chosenNumber;
//    bool isProccessDone = false;
//    do
//    {
//        Console.WriteLine("Which ToDo would you like to remove? Please type in a number\n");
//        for (int i = 0; i < listToOperate.Count; i++)
//        {
//            Console.WriteLine((i + 1) + ". " + listToOperate[i] + "\n");
//        }
//        bool isParsingSuccessfull = int.TryParse(Console.ReadLine(), out int number);
//        if (isParsingSuccessfull)
//        {
//            if (number <= listToOperate.Count() && number >= 1)
//            {
//                chosenNumber = number - 1;
//                Console.WriteLine("ToDo removed!\n");
//                isProccessDone = true;
//                listToOperate.RemoveAt(chosenNumber);
//            }
//            else if (listToOperate.Count == 0)
//            {
//                Console.WriteLine("List is empty!\n");
//                isProccessDone = true;

//            }
//            else { Console.WriteLine("insert correct number from the list!\n"); }
//        }
//        else
//        {
//            Console.WriteLine("\nPlease insert a number!");

//        }

//    }
//    while (!isProccessDone);

//    return true;
//}
#endregion
List<string> typicalList = new List<string> { "first", "second", "third" };
bool statusOfTheApplication = true;
string usersChoice;
var firstList = new UsersToDoList(typicalList);

do
{
    Console.WriteLine("\n[s]ee all todos");
    Console.WriteLine("[a]dd a todo");
    Console.WriteLine("[r]emove a todo");
    Console.WriteLine("[e]xit\n");

    usersChoice = Console.ReadLine();
    


    switch (usersChoice)
    {
        case "s":
        case "S":
            firstList.SeeToDo();
            continue;

        case "a":
        case "A":
            Console.WriteLine("\nWhat is ToDo you want to add?");
            string newToDo = Console.ReadLine();
            firstList.AddToDo(newToDo);
            continue;

        case "r":
        case "R":
            firstList.SeeToDo();
            Console.WriteLine("\nWhich ToDo would you like to remove? Please type in a number from the ones above\n");
            string toDoToRemove = Console.ReadLine();
            firstList.RemoveToDo(toDoToRemove);
            continue;

        case "e":
        case "E":
            statusOfTheApplication = false;
            break;

        default:
            Console.WriteLine("\nPlease enter a valid value");
            break;
    }

} while (statusOfTheApplication);

class UsersToDoList
{
    private List<string> _toDos = new List<string>();

    #region UsersToDoList(List<string> toDos)
    public UsersToDoList(List<string> toDos)
    {
        _toDos = toDos;
    }
    #endregion

    class IsParsingSuccessAndItsResult
    {
        public bool IsParseSuccess { get; }
        public int ParsingOutputNumber { get; }

        #region IsParsingSuccessAndItsResult(bool isParseSuccess, int parsingOutputNumber)
        public IsParsingSuccessAndItsResult(bool isParseSuccess, int parsingOutputNumber)
        {
            IsParseSuccess = isParseSuccess;
            ParsingOutputNumber = parsingOutputNumber;
        }
        #endregion

    }
    // main application methods
    #region SeeToDo()
    public void SeeToDo()
    {
        int seeToDoValidationResult = SeeToDoValidation();
        switch (seeToDoValidationResult)
        {
            case 0:
                Console.WriteLine("\nThe list is currently empty, add some to do's if you want to check them out!");
                break;

            case 1:

                for (int i = 0; i < _toDos.Count; i++)
                {
                    int currentToDoListNumber = i + 1;

                    Console.WriteLine($"{currentToDoListNumber}. {_toDos[i]}");
                }
                break;

        }
        
    }
    #endregion

    #region AddToDo()
    public void AddToDo(string toDoToAdd)
    {
        int toDoToAddValidationResult = AddToDoValidation(toDoToAdd);
        switch (toDoToAddValidationResult)
        {
            case 0: 
                Console.WriteLine("\nMust insert a description!");
                break;
            case 1:
                Console.WriteLine("\nTo do with this description already exists.");
                break;
            case 2: 
                _toDos.Add(toDoToAdd);
                break;
        }
    }
    #endregion

    #region RemoveToDo()
    public void RemoveToDo(string toDoToRemove)
    {
        IsParsingSuccessAndItsResult parsingResults = ParsingString(toDoToRemove);
        int numberOfToDoToRemove = parsingResults.ParsingOutputNumber;
        bool isParsingSuccessful = parsingResults.IsParseSuccess;
        int numberValidationResult = RemoveToDoValidation(numberOfToDoToRemove, isParsingSuccessful);
        switch (numberValidationResult)
        {
            case 0:
            case 2:
            case 3:
                break;

            case 1:
                _toDos.RemoveAt(numberOfToDoToRemove - 1);
                break;

        }

    }
    #endregion

    // helper methods

    #region ParsingString()
    private IsParsingSuccessAndItsResult ParsingString(string givenStringToParse)
    {
        bool parsingBoolResult = int.TryParse(givenStringToParse, out int parsingOutputNumber);
        var methodResults = new IsParsingSuccessAndItsResult(parsingBoolResult, parsingOutputNumber);

        return methodResults;
    }
    #endregion

    #region SeeToDoValidation()
    public int SeeToDoValidation()
    {
        if (_toDos.Count == 0)
        {
            return 0;

        }
        return 1;
    }
    #endregion

    #region RemoveToDoValidation()
    public int RemoveToDoValidation(int numberOfToDoToRemove, bool isParsingSuccessful)
    {
        if (_toDos.Count == 0)
        {
            Console.WriteLine("\nThe list is empty, cannot remove a to do!");
            return 0;

        }
        else
        {
            if (isParsingSuccessful)
            {

                if (numberOfToDoToRemove > 0 && numberOfToDoToRemove <= _toDos.Count)
                {
                    return 1;

                }
                else
                {
                    Console.WriteLine("\nPlease, enter a valid number!");
                    return 2;

                }
            }
            Console.WriteLine("\nPlease, insert a number!");
            return 3;


        }
    }
    #endregion

    #region AddToDoValidation()
    public int AddToDoValidation(string toDoToAdd)
    {
        if (toDoToAdd == "")
        {
            return 0;
        }
        else if (_toDos.Contains(toDoToAdd))
        {
            return 1;

        }
        return 2;
 
    }
    #endregion

}
