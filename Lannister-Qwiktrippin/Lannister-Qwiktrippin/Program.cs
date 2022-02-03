using Lannister_Qwiktrippin.prompts;

Menu.MainMenu();
int selection = Menu.MenuSelection(5);

Console.WriteLine($"You selected {selection}");

//Console.WriteLine($"Create Store #{EnterStoreNumber.Prompt()}");