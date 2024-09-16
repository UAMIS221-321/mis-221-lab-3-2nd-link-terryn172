// start main 

string name = "";
SayHello(name);
string enjoymentLevel = GetEnjoymentLevel();
// string recommendation1 =
string stadiumRecommendation = GetStadiumRecommendation(enjoymentLevel);
string gameRecommendation = GetGameRecommendation(stadiumRecommendation);
DisplayStadiumDetails(enjoymentLevel, stadiumRecommendation, gameRecommendation);


// end main 
static void SayHello(string name){
    System.Console.WriteLine("Please enter your name");
    name = Console.ReadLine();
    System.Console.WriteLine($"Hello {name} and welcome to College Football Intro application!"); 
    
}
string GetEnjoymentLevel(){
    System.Console.WriteLine("Please enter your prefered enjoyment level \nBoring\nAverage\nFun\nEpic");
    string enjoymentLevel = Console.ReadLine().ToUpper();
    return enjoymentLevel;
}
string GetStadiumRecommendation(string enjoymentLevel){
    string stadiumRecommendation = "";
    if(enjoymentLevel == "BORING"){
        stadiumRecommendation = "Neyland Stadium";
        return stadiumRecommendation;
    } 
    else if(enjoymentLevel == "AVERAGE"){
        stadiumRecommendation = "Jordan-Hare Stadium";
        return stadiumRecommendation;
    } 
    else if(enjoymentLevel == "FUN"){
        stadiumRecommendation = "Tiger Stadium";
        return stadiumRecommendation;
    } 
    else if(enjoymentLevel == "EPIC"){
        stadiumRecommendation = "Saban Field at Bryant Denny Stadium"; 
        return stadiumRecommendation;
    }
    return stadiumRecommendation;
    }
string GetGameRecommendation(string stadiumRecommendation){
    string gameRecommendation = "";
if(stadiumRecommendation == "Neyland Stadium"){
    gameRecommendation = "Kent State";
    return gameRecommendation;
} else if(stadiumRecommendation == "Jordan-Hare Stadium"){
    gameRecommendation = "Kentucky";
    return gameRecommendation;
} else if(stadiumRecommendation == "Tiger Stadium"){
    gameRecommendation = "Alabama";
    return gameRecommendation;
}else if(stadiumRecommendation == "Saban Field at Bryant Denny Stadium"){
    gameRecommendation = "Auburn";
    return gameRecommendation;
    }
    return gameRecommendation;
}
static void DisplayStadiumDetails(string enjoymentLevel, string stadiumRecommendation, string gameRecommendation){
System.Console.WriteLine($"Based on your enjoyment preference {enjoymentLevel} I recommend that you go to {stadiumRecommendation} for the {gameRecommendation} game");
}