using System;
namespace CalorieCalculator 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This program calculates the total number of calories you burned depending on how long you've exercised.");
            Exercise exercise1 = new Exercise("push-ups", 7);
            Exercise exercise2 = new Exercise("squats", 7);
            Exercise exercise3 = new Exercise("crunches", 5);
            Exercise exercise4 = new Exercise("glute-bridge", 8);

            Exercise[] exercises = {exercise1, exercise2, exercise3, exercise4}; 
            
            int totalNumOfExercise = exercises.Length;
            double[] totalMinCompleted = new double[totalNumOfExercise]; 
            double[] totalCalories = new double[totalNumOfExercise];
            
            Console.WriteLine("What is your name?");
            string PersonName = Console.ReadLine();

            Console.WriteLine($"Hello {PersonName}, the exercise that you need to complete is listed below:\n");

            foreach(Exercise exercise in exercises)
            {
                Console.WriteLine(exercise.ExerciseName + "\n");
            }
            Console.WriteLine($"Total number of exercise: {totalNumOfExercise}");

    
           Exercise.WarmUp();
            for(int i = 0; i < totalNumOfExercise; i++)
            {
                Console.WriteLine(  $"\n{i+1}) How many minutes of {exercises[i].ExerciseName} have you completed\n");
                try
                {
                    totalMinCompleted[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter a number");
                    i--;
                    continue;
                }
                
                
                totalCalories[i] = exercises[i].CalorieCalculator(totalMinCompleted[i]); 
            }

            double tottall = 0;
            for(int i = 0; i < totalNumOfExercise; i++)
            {
                tottall += totalCalories[i]; 
            };

            Console.WriteLine($"Total calories burned: {tottall} kJ"); 

        }
    }

}