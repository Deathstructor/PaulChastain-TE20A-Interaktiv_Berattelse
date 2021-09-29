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
        Console.ForegroundColor = ConsoleColor.Yellow;
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
         Console.ForegroundColor = ConsoleColor.Yellow;
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
        Console.ForegroundColor = ConsoleColor.Yellow;
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

    while (choice3 != "dallas" && choice3 != "jump") {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Enter 'Dallas' or 'Jump' to continue.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        choice3 = Console.ReadLine().ToLower();
    }

    if(choice3 == "dallas") {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        DallasPath();
    } else {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        JumpPath();
    }
}

static void LoudPath() {
    Console.WriteLine("The gang decided that it would be better to do it loud. Just get on the train");
    Console.WriteLine("quickly, find the loot, and get off the train. Sounds easy right?");
    Console.WriteLine();
    Console.WriteLine("As soon as the train arrived at the station in Alexandria, they got on the");
    Console.WriteLine("train. Many shots were fired as the gang tried to get to the loot, and many");
    Console.WriteLine("lost their lives, but they finally got to the loot. They looted the train,");
    Console.WriteLine("but when they where on their way off of the train, they realized that they");
    Console.WriteLine("were completely surrounded by the police. The gang only saw one way out;");
    Console.WriteLine("to go all guns blazing. Unfortunately for the gang, the police were way");
    Console.WriteLine("stronger, and everey gang member either got shot to death or put in prison");
    Console.WriteLine("to later be hung in the middle of the city in front of a crowd.");
    Console.WriteLine();
    Console.WriteLine("The heist was therefore unsuccessful and the entire gang got killed.");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("This is ending 1/?");
    Console.WriteLine("Press enter to exit.");
    Console.ReadLine();
}





//Andra valet, första för "Friend Path": "Stopped Path" och "Running Path"
static void StoppedPath() {

}

static void RunningPath() {

}





//Tredje valet, andra för "Money Path": "Dallas Path" och "Jump Path"
static void DallasPath() {

}

static void JumpPath() {

}