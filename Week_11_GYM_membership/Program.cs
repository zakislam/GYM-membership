using System;

namespace Week_11_GYM_membership
{
    class Program
    {
        static double BMR, Kal, BMI; //This creates 3 global double variables
        static void Main(string[] args)
        {
            double age = 0, weight = 0, height = 0, Target_BMI = 0; // This creates 4 local double variables
            string gender; //This creates a string local variable
            Console.WriteLine("Hello, please enter your age: "); //This will display the message.
            age = Convert.ToDouble(Console.ReadLine()); //This will read what ever the user typed in the terminal and convert it an double then assign it to the variable age
            Console.WriteLine("Hello, please enter your current weight in kg: "); //This will display the message.
            weight = Convert.ToDouble(Console.ReadLine()); //This will read what ever the user typed in the terminal and convert it an double then assign it to the variable weight 
            Console.WriteLine("Hello, please enter your height in cm: "); //This will display the message.
            height = Convert.ToDouble(Console.ReadLine()); //This will read what ever the user typed in the terminal and convert it an double then assign it to the variable height

            if (Check_Data(age, weight, height) == true) //This is an if statement it will call the method Check_Data and if it returns true the code below will run
            {
                Console.WriteLine("Please enter your gender. M for Male or F for Female: ");  //This will ask the user for their gender.
                gender = Console.ReadLine().ToUpper();  //This will read what ever the user typed in the terminal and assign it to the variable gender and convert to upper case
                Console.WriteLine("Thanks thats been accepted calculating your results now."); //This will display the message.
                BMR = Cal_BMR(weight, height, age,gender); //This will call the method Cal_BMR and pass it the weight, height, age and gender variable. It will then assign the value returned to the BMR variable 
                Kal = Kal_Cal(BMR); //This will call the method Kal_Cal and pass it the BMR variable. It will then assign the value returned to the Kal variable 
                BMI = Cal_BMI(weight, height); //This will call the method Cal_BMI and pass it the weight and height variable. It will then assign the value returned to the BMI variable 
                Target_BMI = Cal_Target_BMI(height); //This will call the method Cal_BMR and pass it the height variable. It will then assign the value returned to the Target_BMI variable 
            }

            else { //This is an else statement the code below will run if the above if statment isn't met
                Console.WriteLine("Sorry it looks like you dont meet the gym membership requirments."); //This will display the message
            } 
            Console.WriteLine("Your Basal Metabolic Rate or BMR is "+ Math.Round(BMI, 1)); //This will display the users BMR to one decimal place.
            Console.WriteLine("To mentain your current body mass index or BMI you would need to consume "+ Math.Round(Kal, 0) +" per day"); //This will display the users calorie intake to zero decimal place.
            Console.WriteLine("Your BMI is "+ Math.Round(BMI, 2)); //This will display the users BMI to two decimal place.
            Console.WriteLine("Based on your target weight. Your taget BMI is "+Math.Round(Target_BMI,2)); //This will display the users target wieght to two decimal places
            Console.WriteLine("The ideal GYM member BMI is 22"); //This will display the message
        }
        static bool Check_Data(double age, double weight, double height) { //This is a method it has the return type of boolean. It accepts three vaiables
            int min_age = 14, max_age = 100, min_weight = 30, max_weight = 250, min_height = 120, max_height = 210; //This defines 6 integer variables
            if ((age >= min_age) && (age <= max_age) && (weight >= min_weight) && (weight <= max_weight) && (height >= min_height) && (height <= max_height)) //This is an if statement the code below will run if the codition is met
            {
                return true; //This will return the boolean value true
            }
            else { //This is an else  statment it will run if the above condition isnt met
                return false; //This will return the boolean value false
            }
        }
        static double Cal_BMR(double weight, double height, double age,string gender) { //This is a method it has the return type of double it accepts 4 variables
            double BMR = 0; //This defines a double variable called BMR and sets it to zero
            if (gender == "M") //This is an if statment it will run if the variable gender is equal to M
            {
                BMR = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age); //This will calculate the users BMR
                return BMR; //This will return the value assinged to the BMR variable
            }
            else if (gender == "F") //This is an else statment it will run if the above else if statment condition is not met 
            {
                BMR = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age); //This will calculate the users BMR
                return BMR; //This will return the value assinged to the BMR variable
            }
            else { //This is an else statment the code below will run if neither of the above if stament coditions are met
                Console.WriteLine("Sorry we couldn't calcualte your BMR"); //This will display the message.
                return BMR; //This will return 0
            }
        }
        static double Kal_Cal(double BMR)
        {//This is a method it has the return type of double it accepts 1 variable
            double Kal = 0; // This creates a double variable called Kal and assigs it the value zero
            string D_E; //This creates a string variable called D_E
            Console.WriteLine("How much exercise do you do? A.Little to no exercise, B.Light exercise (1–3 days per week), C.Moderate exercise (3–5 days per week), D.Heavy exercise (6–7 days per week) or E.Very heavy exercise(twice per day,extra heavy workouts): ");//This will display the message
            D_E = Console.ReadLine().ToUpper(); //This will read whatever the user typed into the terminal and assign it the variable D_E as a capital letter
            if (D_E == "A") { //This is an if statment the code below will run if the conditition is met
                Kal = BMR * 1.2; //This assigns the variable Kal the total of BMR * 1.2
                return Kal; //This returns the value for Kal
            }
            else if (D_E == "B")
            {
                Kal = BMR * 1.375;//This assigns the variable Kal the total of BMR * 1.375
                return Kal; //This returns the value for Kal
            }
            else if (D_E == "C")
            {
                Kal = BMR * 1.55;//This assigns the variable Kal the total of BMR * 1.55
                return Kal; //This returns the value for Kal
            }
            else if (D_E == "D")
            {
                Kal = BMR * 1.725;//This assigns the variable Kal the total of BMR * 1.725
                return Kal; //This returns the value for Kal
            }
            else if (D_E == "E")
            {
                Kal = BMR * 1.9;//This assigns the variable Kal the total of BMR * 1.9
                return Kal; //This returns the value for Kal
            }
            else {
                Console.WriteLine("Sorry something went wrong");
                return Kal;
            }

        }
        static double Cal_BMI(double weight, double height) { //This is a method it has the return type of double. It accepts 2 variables
            double BMI = 0; //This creates a double variable called BMI and assigns it value 0
            height = height / 100; //This assigns the value of height / 100 to the height variable
            BMI = weight / (height*height); //This will calulate the users BMI by doing the calculation weight divided by height squared
            if (BMI <= 18.5) //This is an if statment it will run if the condition is met
            {
                Console.WriteLine("You are underweight"); //This will display the message
                return BMI; //This will return the users BMI
            }
            else if ((BMI > 18.5) && (BMI <= 24.9)) //This is an else if statment it will run if the condition is met
            {
                Console.WriteLine("You are normal weight");//This will display the message
                return BMI; //This will return the users BMI
            }
            else if ((BMI >= 25) && (BMI <= 29.9)) //This is an else if statment it will run if the condition is met
            {
                Console.WriteLine("You are overweight");//This will display the message
                return BMI; //This will return the users BMI
            }

            else if (BMI <= 30) //This is an else if statment it will run if the condition is met
            {
                Console.WriteLine("You are obese");//This will display the message
                return BMI; //This will return the users BMI
            }
            else { //This is an else statment it will run if none of the above conditions are met
                Console.WriteLine("Sorry we couldn't calculate your BMI");//This will display the message
                return BMI; //This will return 0
            }
        }
        static double Cal_Target_BMI(double height) { //This is a method with the return type of double
            double Target_BMI, Target_weight; //This creates 2 double variables
            height = height / 100; //This will do the calculation of height divided by 100. then assign that value to the height variable
            Console.WriteLine("What is your target weight?: "); //This will display the message
            Target_weight = Convert.ToDouble(Console.ReadLine()); //This will read the terminal and assign the value to the variable Target_weight
            Target_BMI = Target_weight / (height * height); //This will calculate the users Target weight
            return Target_BMI; //This will return the users Target BMI

        }
    }
}