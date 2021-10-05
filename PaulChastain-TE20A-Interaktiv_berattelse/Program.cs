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





//Första valet: "Money Path" och "Friend Path"
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

    while(choice2 != "stealth" && choice2 != "loud") {
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

    while(choice2 != "stopped" && choice2 != "running") {
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

    while(choice3 != "dallas" && choice3 != "jump") {
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
    Console.WriteLine("This is ending 1/7");
    Console.WriteLine("Press enter to exit.");
    Console.ReadLine();
}





//Andra valet, första för "Friend Path": "Stopped Path" och "Running Path"
static void StoppedPath() {
    string choice2 = "";

    Console.WriteLine("Stopping the train would is the smartest thing to do, it would make the whole");
    Console.WriteLine("thing much easier.");
    Console.WriteLine();
    Console.WriteLine("To stop the train, they would have to do something that will force it to stop.");
    Console.WriteLine("The best thing they could come up with was to blow up the track and to put a");
    Console.WriteLine("large obstacle on the track, so they stole a large wagon and some barrels and");
    Console.WriteLine("put them on the track. It was now time to wait for the train to arrive.");
    Console.WriteLine();
    Console.WriteLine("When the train arrived it saw the obstacles and stopped. The gang took the train");
    Console.WriteLine("driver as a hostage and went in to the train. There were of course many guards,");
    Console.WriteLine("but because they were more or less in the middle of nowhere they could use their");
    Console.WriteLine("firearms to kill them. They got to the cells and opened the cells where their");
    Console.WriteLine("were, but they saw that the rest of the prisoners were old enimies. That raised");
    Console.WriteLine("another question: should they only release their friends, release everyone, or");
    Console.WriteLine("kill all of their old enemies?");
    Console.WriteLine();

    while(choice2 != "friends" && choice2 != "everyone" && choice2 != "kill") {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Enter 'Friends', 'Everyone' or 'Kill' to continue.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        choice2 = Console.ReadLine().ToLower();
    }

    if(choice2 == "friends") {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        OnlyFriendsPath();
    } else if (choice2 == "everyone") {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        EveryonePath();
    } else {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        KillPath();
    }
}

static void RunningPath() {
    Console.WriteLine("Jumping on the while it's running wouldn't be easy, but they won't have to stop");
    Console.WriteLine("the train, which means a lot more work.");
    Console.WriteLine();
    Console.WriteLine("It was now time for the gang to get on the train. They jumped onto their horses");
    Console.WriteLine("and rode to the railway. The train was ahead of them, so they had do ride a bit,");
    Console.WriteLine("but they eventually arrived next to the train. When they were about to jump on");
    Console.WriteLine("the train, a guard noticed them and alerted the rest of the guards on the train.");
    Console.WriteLine("The gang tried to shoot the guards, but it was very hard to aim when they were");
    Console.WriteLine("on the horses and they quickly got overwhelmed by the guards who shot everyone");
    Console.WriteLine("in the gang to death in a matter of seconds.");
    Console.WriteLine();
    Console.WriteLine("The attempt to release their friends was unsuccessful as everyone died.");
    Console.WriteLine();

    Console.ForegroundColor =ConsoleColor.Green;
    Console.WriteLine("This is ending 2/7");
    Console.WriteLine("Press enter to exit.");
    Console.ReadLine();
}





//Tredje valet, andra för "Money Path": "Dallas Path" och "Jump Path"
static void DallasPath() {
    Console.WriteLine("Going to dallas was probably the best idea as they wouldn't have to risk their");
    Console.WriteLine("lifes, just to jump off the train.");
    Console.WriteLine();
    Console.WriteLine("The gang was now on it's way to Dallas. They had so much money that it could be");
    Console.WriteLine("very risky to get it off the train without beeing noticed, especially since there");
    Console.WriteLine("will be people there, waiting to get the money.");
    Console.WriteLine();
    Console.WriteLine("After some time, they finally arrived in Dallas. They had to act quick to not be");
    Console.WriteLine("seen with the valuables. As if God wanted to help the gang for some reason, there");
    Console.WriteLine("was a horse with an empty wagon right outside the traincart. They quickly dumped");
    Console.WriteLine("all the loot in the wagon and stole it to ride out of Dallas, back to their camp.");
    Console.WriteLine();
    Console.WriteLine("The heist was successful! The gang managed to steal all the loot and get away.");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("This is ending 3/7");
    Console.WriteLine("Press enter to exit.");
    Console.ReadLine();
}

static void JumpPath() {
    Console.WriteLine("After some reflecting, the gang decided that they should try to jump of the.");
    Console.WriteLine("train while it's running.");
    Console.WriteLine();
    Console.WriteLine("The gang went to one of the wagons that were \"open\", that didn't have any");
    Console.WriteLine("walls or roof to mak it easier to jump. After some hesitation they all jumped");
    Console.WriteLine("one after one. Unfortunately for the gang, it wasn't as easy to escape by");
    Console.WriteLine("jumping off the train as they initially thought it would be. Because of the");
    Console.WriteLine("speed of the train they all died from not landing properly and breaking their");
    Console.WriteLine("or crushing something vital in the body, and one even fell under the train");
    Console.WriteLine("and got sliced in half by the train.");
    Console.WriteLine();
    Console.WriteLine("They didn't succeed with the heist as they all died from jumping off the train.");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("This is ending 4/7");
    Console.WriteLine("Press enter to exit.");
    Console.ReadLine();
}





//Tredje valet, andra för "Friend Path"; "Only Friends Path", "Everyone Path" och "Kill Path"
static void OnlyFriendsPath() {
    Console.WriteLine("The gang decided to just release their friends. Why should they release their");
    Console.WriteLine("enemies? That would be really stupid, so they decided to leave the bastards in");
    Console.WriteLine("the train. The gang was now finally complete and back together!");
    Console.WriteLine();
    Console.WriteLine("The rescue was successful! The gang is now complete.");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("This is ending 5/7");
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
}

static void EveryonePath() {
    Console.WriteLine("The gang decided to release everyone and not just their friends. Maybe they");
    Console.WriteLine("could convert their enemies to join the gang and strengthen it? At first,");
    Console.WriteLine("everything seemed to be ok, but then they heard multiple gunshots, and many");
    Console.WriteLine("in the gang dropped dead. Their enemies had decided to still be their enemies");
    Console.WriteLine("and they managed to kill Johns entire gang with the guards weapons before the");
    Console.WriteLine("gang even had time to register what happened.");
    Console.WriteLine();
    Console.WriteLine("The rescue was kind of successful, but they got killed after the rescue.");
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("This is ending 6/7");
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
}

static void KillPath() {
    Console.WriteLine("The gang decided that they shouldn't show their enemies any mercy and they");
    Console.WriteLine("therefore decided to kill all their enemies. They released their friends");
    Console.WriteLine("and got them out of the train. Then they all gathered lots of flammable");
    Console.WriteLine("material, filled the train with it and lit it on fire. Then they left left");
    Console.WriteLine("with their newly released friends to go back to their camp.");
    Console.WriteLine();
    Console.WriteLine("The rescue was successful! The gang released their friends and they killed");
    Console.WriteLine("a lot of their enemies.");
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("This is ending 7/7");
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
}