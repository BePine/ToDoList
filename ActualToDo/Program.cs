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

bool statusOfTheApplication = true;
string usersChoice;
Console.WriteLine("\n[s]ee all todos");
Console.WriteLine("[a]dd a todo");
Console.WriteLine("[r]emove a todo");
Console.WriteLine("[e]xit");
usersChoice = Console.ReadLine();
do
{
    switch (usersChoice)
    {
        case "s":
        case "S":
            break;
        case "a":
        case "A":
            break;
        case "r":
        case "R":
            break;
        case "e":
        case "E":
            statusOfTheApplication = false;
            break;
        default:
            Console.WriteLine("Please enter a valid value");
            break;
    }
} while (statusOfTheApplication);



