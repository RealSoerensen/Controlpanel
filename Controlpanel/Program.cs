using System;
using Controlpanel.Menus;
using Controlpanel.Model;

// Change the title
Console.Title = "Soerensen's Controlpanel";
Console.CursorVisible = true;
Account _account = null;
while (_account == null)
{
    _account = new LoginMenu().PrintMenu();
}

while (true)
{
    new MainMenu(_account).PrintMenu();
}