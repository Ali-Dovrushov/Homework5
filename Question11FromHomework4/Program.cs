using System;

namespace Question11FromHomework4
{
    class Program
    {

        public static int firstPersonTryAge;
        public static int secondPersonTryAge;

        static void FirstPersonName()
        {
            bool checkerFirstPerson = true;

            do
            {
                Console.Write("Enter first person name: ");
                string firstPersonName = Convert.ToString(Console.ReadLine());

                for (int i = 0; i < firstPersonName.Length; i++)
                {
                    char element = firstPersonName[i];

                    if (!Char.IsLetter(element))
                    {
                        checkerFirstPerson = false;
                        Console.WriteLine("Incorrect name type, please enter correct name\n");
                        break;
                    }
                    else
                    {
                        checkerFirstPerson = true;
                    }
                }
                firstNameForCompare = firstPersonName;
                upFirstName = firstNameForCompare[0].ToString().ToUpper() + firstNameForCompare.Substring(1);
            }
            while (checkerFirstPerson == false);
        }

        static void FirstPersonAge()
        {
            bool checkerFirstPerson = true;

            do
            {
                Console.Write("Enter first person age: ");
                string firstPersonAge = Convert.ToString(Console.ReadLine());
                bool firstAge = int.TryParse(firstPersonAge, out firstPersonTryAge);

                for (int i = 0; i < firstPersonAge.Length; i++)
                {
                    char elementForFirstAge = firstPersonAge[i];

                    if (firstPersonTryAge < 0)
                    {
                        checkerFirstPerson = false;
                        Console.WriteLine("Age cannot be negativ number");
                        break;
                    }
                    else if (Char.IsLetter(elementForFirstAge))
                    {
                        checkerFirstPerson = false;
                        Console.WriteLine("Incorrect age type, please enter correct age\n");
                        break;
                    }
                    else
                    {
                        checkerFirstPerson = true;
                    }
                }
            }
            while (checkerFirstPerson == false);
        }

        static void SecondPersonName()
        {
            bool checkerSecondPerson = true;

            do
            {
                Console.Write("Enter second person name: ");
                string secondPersonName = Convert.ToString(Console.ReadLine());

                for (int i = 0; i < secondPersonName.Length; i++)
                {
                    char elementForSecondName = secondPersonName[i];

                    if (!Char.IsLetter(elementForSecondName))
                    {
                        checkerSecondPerson = false;
                        Console.WriteLine("Incorrect name type, please enter correct name\n");
                        break;
                    }
                    else
                    {
                        checkerSecondPerson = true;
                    }
                }
                secondNameForCompare = secondPersonName;
                upSecondtName = secondNameForCompare[0].ToString().ToUpper() + secondNameForCompare.Substring(1);
            }
            while (checkerSecondPerson == false);
        }

        static void SecondPersonAge()
        {
            bool checkerSecondPerson = true;

            do
            {
                Console.Write("Enter second person age: ");
                string secondPersonAge = Convert.ToString(Console.ReadLine());
                bool secondAge = int.TryParse(secondPersonAge, out secondPersonTryAge);

                for (int i = 0; i < secondPersonAge.Length; i++)
                {
                    char elementForSecondAge = secondPersonAge[i];

                    if (secondPersonTryAge < 0)
                    {
                        checkerSecondPerson = false;
                        Console.WriteLine("Age cannot be negativ number");
                        break;
                    }
                    else if (Char.IsLetter(elementForSecondAge))
                    {
                        checkerSecondPerson = false;
                        Console.WriteLine("Incorrect age type, please enter correct age\n");
                        break;
                    }
                    else
                    {
                        checkerSecondPerson = true;
                    }
                }
            }
            while (checkerSecondPerson == false);
        }

        public static string firstNameForCompare;
        public static string secondNameForCompare;
        public static string upFirstName;
        public static string upSecondtName;
        public static string sameAge = "same";

        static void Display()
        {
            bool ageComparing = true;

            do
            {
                Console.Write($"Who is older {upFirstName}, {upSecondtName} or {sameAge}(if same, please type = same) ? Please enter name: ");
                string checkerForCompare = Convert.ToString(Console.ReadLine());
                checkerForCompare = checkerForCompare[0].ToString().ToUpper() + checkerForCompare.Substring(1);

                if (checkerForCompare == upFirstName)
                {
                    if (firstPersonTryAge > secondPersonTryAge)
                    {
                        Console.WriteLine($"{upFirstName} older than {upSecondtName} on {firstPersonTryAge - secondPersonTryAge} years");
                    }
                    else if (firstPersonTryAge < secondPersonTryAge)
                    {
                        Console.WriteLine($"{upFirstName} not older than {upSecondtName}");
                    }
                    else if (firstPersonTryAge == secondPersonTryAge)
                    {
                        Console.WriteLine("No, they are the same age");
                    }
                }

                else if (checkerForCompare == upSecondtName)
                {
                    if (secondPersonTryAge > firstPersonTryAge)
                    {
                        Console.WriteLine($"{upSecondtName} older than {upFirstName} on {secondPersonTryAge - firstPersonTryAge} years");
                    }
                    else if (secondPersonTryAge < firstPersonTryAge)
                    {

                        Console.WriteLine($"{upSecondtName} not older than {upFirstName}");
                    }
                    else if (firstPersonTryAge == secondPersonTryAge)
                    {
                        Console.WriteLine("No, they are the same age");
                    }
                }

                else if (checkerForCompare == sameAge)
                {
                    if (firstPersonTryAge == secondPersonTryAge)
                    {
                        Console.WriteLine("Yes, they are the same age ");
                    }
                    else if (firstPersonTryAge > secondPersonTryAge)
                    {
                        Console.WriteLine("No, they are not a same age ");
                    }
                    else if (firstPersonTryAge < secondPersonTryAge)
                    {
                        Console.WriteLine("No, they are not a same age ");
                    }
                }
                else
                {
                    Console.WriteLine("You enter incorrect name, please enter valid name.");
                    ageComparing = false;
                }
            }
            while (ageComparing == false);
        }

        static void Main(string[] args)
        {
            bool checker = true;
            bool checkerForSwitchContinue = false;
            do
            {
                FirstPersonName();
                FirstPersonAge();
                SecondPersonName();
                SecondPersonAge();
                Display();

                Console.Write("\nWould you try again ? (Y/y) or (N/n): ");

                do
                {
                    string symbolForSwitch = Convert.ToString(Console.ReadLine());

                    switch (symbolForSwitch)
                    {
                        case "Y":
                            {
                                checker = true;
                                checkerForSwitchContinue = true;
                                break;
                            }
                        case "y":
                            {
                                checker = true;
                                checkerForSwitchContinue = true;
                                break;
                            }
                        case "N":
                            {
                                Console.WriteLine("Have a good day :)");
                                checker = false;
                                checkerForSwitchContinue = true;
                                break;
                            }
                        case "n":
                            {
                                Console.WriteLine("Have a good day :)");
                                checker = false;
                                checkerForSwitchContinue = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("You enter incorrect symbol, please enter Y/y or N/n: ");
                                checkerForSwitchContinue = false;
                                checker = true;
                                continue;
                            }
                    }
                }
                while (checkerForSwitchContinue == false);

            }
            while (checker == true);

            Console.ReadKey();
        }
    }
}