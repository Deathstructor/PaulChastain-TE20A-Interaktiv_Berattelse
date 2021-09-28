using Internal;
using System;

beginning();

//Introduktionen / början
static void beginning() {
    string choice1 = "";

    Console.WriteLine("The Train Robbery");
    Console.WriteLine();
    Console.WriteLine("The year is 1851. John Roberts and his gang is gathered around the fire");
    Console.WriteLine("at their camp located close to the border between Texas and Louisiana.");
    Console.WriteLine("James have found information about two trains that the gang could rob.");
    Console.WriteLine("One of the trains contains a lot of money and jewelry that would make");
    Console.WriteLine("them rich for the rest of their lifes. The other train have two of their");
    Console.WriteLine("imprisoned friends on it that they could save.");
    Console.WriteLine();
    Console.WriteLine("Which train should they rob? Money or friends, which one is more important?");
    Console.WriteLine();
    
    while(choice1 != "money" && choice1 != "friends") {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Enter 'Money' or 'Friends' to continue.");
        choice1 = Console.ReadLine().ToLower();
    }
    
    if (choice1 == "money") {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        MoneyPath();
    } else {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        FriendPath();
    }
}





//Första valet: väg 1A och 1B
static void MoneyPath() {
    string choice2 = "";

    Console.WriteLine("The gang decided to go for the money and leave their imprisoned friends");
    Console.WriteLine("behind. They were just annoying anyway.");
    Console.WriteLine();
    Console.WriteLine("The train would stop in the town of Alexandria, which is where they're");
    Console.WriteLine("going to rob it. The next question was; should they try to do it stealthy");
    Console.WriteLine("or if they sould go all guns blazing? Stealthing it would make the heist");
    Console.WriteLine("way more difficult but the escape wouldn't be any problem. Doing it loud");
    Console.WriteLine("would make the heist itself very easy, but the escape a lot harder.");
    Console.WriteLine();
    Console.WriteLine("Should they do it stealth or loud?");
    Console.WriteLine();

    while (choice2 != "stealth" && choice2 != "loud") {
         Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine("Enter 'Stealth' or 'Loud' to continue.");
         choice2 = Console.ReadLine().ToLower();
    }

    if(choice2 == "stealth") {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        StealthPath();
    } else {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        LoudPath();
    }
}

static void FriendPath() {
    string choice2 = "";

    Console.WriteLine("The gang decided that it would be better to save their friends while they");
    Console.WriteLine("still could. The money could wait.");
    Console.WriteLine();
    Console.WriteLine("This train will not stop until it has reached it's final destination, which");
    Console.WriteLine("is far west, so they would either have to jump on the train while it's running,");
    Console.WriteLine("or stop the train to get on it. Either way would be very dangerous, but it will");
    Console.WriteLine("well worth it when it's done.");
    Console.WriteLine();
    Console.WriteLine("Should they stop the train or jump on the train while it's running?");
    Console.WriteLine();

    while (choice2 != "stopped" && choice2 != "running") {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Enter 'Stopped' or 'Running' to continue.");
        choice2 = Console.ReadLine().ToLower();
    }

    if(choice2 == "stopped") {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        StoppedPath();
    } else {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        RunningPath();
    }
}





//Andra valet, första för "Money Path": "Stealth Path" och "Loud Path"
static void StealthPath() {
    string choice3 = "";

    Console.WriteLine("Stealth is the way to go. It's much safer and the chance to succeed");
    Console.WriteLine("with the robbery is much higher this way.");
    Console.WriteLine();
    Console.WriteLine("The train just arrived at the train station and it was time for the");
    Console.WriteLine("gang to begin with the heist. Because it was supposed to be done");
    Console.WriteLine("stealthy, they would have to use knives instead of guns to take out");
    Console.WriteLine("the guards on the train. Now it's just time for them to complete");
    Console.WriteLine("the heist and hope that they don't do any mistakes.");
    Console.WriteLine();
    Console.WriteLine("They managed to get to the loot without any major problems as expected,");
    Console.WriteLine("but, because of the time it took the gang to work their way through the");
    Console.WriteLine("train, it had already left the station and was now heading to Dallas");
    Console.WriteLine("wich would be the next stop. The question was, should they jump off the");
    Console.WriteLine("whie it's running or try to sneak off the train when it arrives in Dallas?");
    Console.WriteLine();

    while (choice3 != "") {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Enter 'Dallas' or 'Running' to continue.")
        choice3 = Console.ReadLine().ToLower();
    }
}

static void LoudPath() {

}





//Andra valet, första för "Friend Path": "Stopped Path" och "Running Path"
static void StoppedPath() {

}

static void RunningPath() {

}