Console.WriteLine(GetReadableTime(359999));

string GetReadableTime(int seconds) 
{
    string finaltime = "";

    //Get hours
    int hours = seconds / 3600;
    //Convert hours to string and format with leading zero
    string stringHours = String.Format("{0:00}", hours);
    //Get the remainder of seconds after getting the hours
    int remainderSecondsForMinutes = seconds % 3600;
    //Converting remaining seconds to remaining minutes
    int minutes = remainderSecondsForMinutes / 60;
    //Convert minutes to string and format with leading zero
    string stringMinutes = String.Format("{0:00}", minutes);
    //Get the remainder of seconds after getting remaining minutes
    int remainingSeconds = remainderSecondsForMinutes % 60;
    //Convert remaining seconds to string and format with leading zero
    string stringRemainingSeconds = String.Format("{0:00}", remainingSeconds);

    //Combine Hours, Minutes, and Seconds to get final time
    finaltime = stringHours + ":" + stringMinutes + ":" + stringRemainingSeconds;
        
    return finaltime;
}
