using System;

namespace Question11FromHomework4
{
    class Program
    {

        public static int personTryAge;
        public static int secondPersonTryAge;

        static string PersonName()
        {
            bool checkerFirstPerson = true;

            do
            {
                string personName = Convert.ToString(Console.ReadLine());

                for (int i = 0; i < personName.Length; i++)
                {
                    char element = personName[i];

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

                NameForCompare = personName;
                upFirstName = NameForCompare[0].ToString().ToUpper() + NameForCompare.Substring(1);

                return NameForCompare;
            }
            while (checkerFirstPerson == false);
        }

        static int PersonAge()
        {
            bool checkerFirstPerson = true;

            do
            {
                string personAge = Convert.ToString(Console.ReadLine());
                bool firstAge = int.TryParse(personAge, out personTryAge);

                for (int i = 0; i < personAge.Length; i++)
                {
                    char elementForFirstAge = personAge[i];

                    if (personTryAge < 0)
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
                return personTryAge;
            }
            while (checkerFirstPerson == false);
        }

        public static string NameForCompare;
        public static string upFirstName;
        public static string upSecondName;
        public static string sameAge = "same";

        static void Display(string getNameForFirst, int getAgeForFirst, string getNameForSecond, int getAgeForSecond)
        {
            bool ageComparing = true;

            do
            {
                Console.Write($"Who is older {getNameForFirst}, {getNameForSecond} or {sameAge}(if same, please type = same) ? Please enter name: ");
                string checkerForCompare = Convert.ToString(Console.ReadLine());

                if (checkerForCompare == getNameForFirst)
                {
                    if (getAgeForFirst > getAgeForSecond)
                    {
                        Console.WriteLine($"{getNameForFirst} older than {getNameForSecond} on {getAgeForFirst - getAgeForSecond} years");
                    }
                    else if (getAgeForFirst < getAgeForSecond)
                    {
                        Console.WriteLine($"{getNameForFirst} not older than {getNameForSecond}");
                    }
                    else if (getAgeForFirst == getAgeForSecond)
                    {
                        Console.WriteLine("No, they are the same age");
                    }
                }

                else if (checkerForCompare == getNameForSecond)
                {
                    if (getAgeForSecond > getAgeForFirst)
                    {
                        Console.WriteLine($"{getNameForSecond} older than {getNameForFirst} on {getAgeForSecond - getAgeForFirst} years");
                    }
                    else if (getAgeForSecond < getAgeForFirst)
                    {
                        Console.WriteLine($"{getNameForSecond} not older than {getNameForFirst}");
                    }
                    else if (getAgeForFirst == getAgeForSecond)
                    {
                        Console.WriteLine("No, they are the same age");
                    }
                }

                else if (checkerForCompare == sameAge)
                {
                    if (getAgeForFirst == getAgeForSecond)
                    {
                        Console.WriteLine("Yes, they are the same age ");
                    }
                    else if (getAgeForFirst > getAgeForSecond)
                    {
                        Console.WriteLine("No, they are not a same age ");
                    }
                    else if (getAgeForFirst < getAgeForSecond)
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
                Console.Write("Enter first person name: ");
                string getNameForFirst = PersonName();

                Console.Write("Enter first person age: ");
                int getAgeForFirst = PersonAge();

                Console.Write("Enter second person name: ");
                string getNameForSecond = PersonName();

                Console.Write("Enter second person age: ");
                int getAgeForSecond = PersonAge();

                Display(getNameForFirst, getAgeForFirst, getNameForSecond, getAgeForSecond);

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