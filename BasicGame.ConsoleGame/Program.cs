﻿
using Microsoft.Extensions.Configuration;



//var ui = config.GetSection("game:ui").Value;

//IUI implementation;

//switch (ui)
//{
//    case "console" :
//        implementation = new ConsoleUI();
//        break;
//    default:
//        break;
//}
//var x = config.GetSection("game:mapsettings:x").Value;
//var mapsettings = config.GetSection("game:mapsettings").GetChildren();

//var someValue = mapsettings.First();
var startup = new Startup();
startup.SetUp();

//var game = new Game(new ConsoleUI(), config);
//game.Run();

Console.WriteLine("Thanks for playing");
Console.ReadLine();
