using System;

namespace CalorieCalculator
{
    class Exercise
    {

    private string exerciseName; 
    private double caloriePerMin;

    public string ExerciseName
    {
        get { return exerciseName; }
    }

    public Exercise(string exName, double caloriee ) :base()
    {
        exerciseName = exName;
        caloriePerMin = caloriee;
    }

    public static void WarmUp()
    {
        Console.WriteLine("\nRoll your shoulders forwards and backwards for 30 seconds....");
        Console.WriteLine("Rotate your head in clockwise and anticlockwise directions 10 times....");
        Console.WriteLine("Slowly stretch your neck left to right for 30 seconds...");
        Console.WriteLine("Stretch your back and legs as required...\n");
    }

    public double CalorieCalculator(double numOfmin)
    {
        return caloriePerMin * numOfmin;
    }
    }

}