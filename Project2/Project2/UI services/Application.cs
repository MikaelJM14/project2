using Project2;
using System.Data;
using System.Linq.Expressions;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Application : IApplication
{
    public void activate()
    {
        Console.WriteLine("What class?");
        Console.WriteLine("reseptionF? " + "reseptionW? " + "Y1F? " + "Y1W? " + "Y2F? " + "Y2W? " + "Y3F? " + "Y3W? " + "Y4F? " + "Y4W? " + "Y5F? " + "Y5W? " + "Y6F? " + "Y6W? " + "Y6WF? " + "High School? " + "or College");
        var Class = Console.ReadLine();

        switch (Class)
        {
            case "reseptionF":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geography 5.French or 6.quit");
                var input17 = Console.ReadLine();

                switch (input17)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "reseptionW":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input1 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input18 = Console.ReadLine();

                switch (input18)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer6 = Console.ReadLine();

                        switch (answer6)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer7 = Console.ReadLine();

                        switch (answer7)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer8 = Console.ReadLine();

                        switch (answer8)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer9 = Console.ReadLine();

                        switch (answer9)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer10 = Console.ReadLine();

                        switch (answer10)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer11 = Console.ReadLine();

                        switch (answer11)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;

            case "Y1F":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input2 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input19 = Console.ReadLine();

                switch (input19)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer12 = Console.ReadLine();

                        switch (answer12)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer13 = Console.ReadLine();

                        switch (answer13)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer14 = Console.ReadLine();

                        switch (answer14)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer15 = Console.ReadLine();

                        switch (answer15)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer16 = Console.ReadLine();

                        switch (answer16)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer17 = Console.ReadLine();

                        switch (answer17)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y1W":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input3 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input20 = Console.ReadLine();

                switch (input20)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer18 = Console.ReadLine();

                        switch (answer18)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer19 = Console.ReadLine();

                        switch (answer19)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer20 = Console.ReadLine();

                        switch (answer20)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer21 = Console.ReadLine();

                        switch (answer21)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer22 = Console.ReadLine();

                        switch (answer22)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer23 = Console.ReadLine();

                        switch (answer23)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y2F":
                Console.Clear();
                Console.WriteLine("What's the name of your school" + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input4 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson ");
                var input21 = Console.ReadLine();

                switch (input21)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer24 = Console.ReadLine();

                        switch (answer24)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer25 = Console.ReadLine();

                        switch (answer25)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer26 = Console.ReadLine();

                        switch (answer26)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer27 = Console.ReadLine();

                        switch (answer27)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer28 = Console.ReadLine();

                        switch (answer28)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer29 = Console.ReadLine();

                        switch (answer29)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y2W":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input5 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input22 = Console.ReadLine();

                switch (input22)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer30 = Console.ReadLine();

                        switch (answer30)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer31 = Console.ReadLine();

                        switch (answer31)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer32 = Console.ReadLine();

                        switch (answer32)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer33 = Console.ReadLine();

                        switch (answer33)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer34 = Console.ReadLine();

                        switch (answer34)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer35 = Console.ReadLine();

                        switch (answer35)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y3F":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input6 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input23 = Console.ReadLine();
                switch (input23)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer36 = Console.ReadLine();

                        switch (answer36)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer37 = Console.ReadLine();

                        switch (answer37)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Are you sure?");
                var answer38 = Console.ReadLine();

                switch (answer38)
                {
                    case "yes":

                        Console.Clear();
                        Console.WriteLine("do you want to pick to choose student or teacher?");
                        var studorteach = Console.ReadLine();

                        switch (studorteach)
                        {
                            case "student":
                                Console.Clear();
                                Console.WriteLine("how many students?");
                                var stud = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                            case "teacher":
                                Console.Clear();
                                Console.WriteLine("how many teachers?");
                                var teach = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                        }
                        break;
                    case "no":
                        Console.Clear();
                        Console.WriteLine("bye! bye!");
                        break;
                }
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Are you sure?");
                var answer39 = Console.ReadLine();

                switch (answer39)
                {
                    case "yes":
                        Console.Clear();
                        Console.WriteLine("do you want to pick to choose student or teacher?");
                        var studorteach = Console.ReadLine();

                        switch (studorteach)
                        {
                            case "student":
                                Console.Clear();
                                Console.WriteLine("how many students?");
                                var stud = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                            case "teacher":
                                Console.Clear();
                                Console.WriteLine("how many teachers?");
                                var teach = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                        }
                        break;
                    case "no":
                        Console.Clear();
                        Console.WriteLine("bye! bye!");
                        break;
                }
                break;
            case "5":
                Console.Clear();
                Console.WriteLine("Are you sure?");
                var answer40 = Console.ReadLine();

                switch (answer40)
                {
                    case "yes":
                        Console.Clear();
                        Console.WriteLine("do you want to pick to choose student or teacher?");
                        var studorteach = Console.ReadLine();

                        switch (studorteach)
                        {
                            case "student":
                                Console.Clear();
                                Console.WriteLine("how many students?");
                                var stud = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                            case "teacher":
                                Console.Clear();
                                Console.WriteLine("how many teachers?");
                                var teach = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                        }
                        break;
                    case "no":
                        Console.Clear();
                        Console.WriteLine("bye! bye!");
                        break;
                }
                break;
            case "6":
                Console.Clear();
                Console.WriteLine("Are you sure?");
                var answer41 = Console.ReadLine();

                switch (answer41)
                {
                    case "yes":
                        Console.Clear();
                        Console.WriteLine("do you want to pick to choose student or teacher?");
                        var studorteach = Console.ReadLine();

                        switch (studorteach)
                        {
                            case "student":
                                Console.Clear();
                                Console.WriteLine("how many students?");
                                var stud = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                            case "teacher":
                                Console.Clear();
                                Console.WriteLine("how many teachers?");
                                var teach = Console.ReadLine();
                                Console.WriteLine("thanks for info");
                                break;
                        }
                        break;
                    case "no":
                        Console.Clear();
                        Console.WriteLine("bye! bye!");
                        break;
                }
                break;


            case "Y3W":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input7 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input24 = Console.ReadLine();

                switch (input24)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y4F":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input8 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input25 = Console.ReadLine();

                switch (input25)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y4W":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input9 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input26 = Console.ReadLine();

                switch (input26)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y5F":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input10 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input27 = Console.ReadLine();

                switch (input27)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y5W":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input11 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input28 = Console.ReadLine();

                switch (input28)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y6F":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input12 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input29 = Console.ReadLine();

                switch (input29)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y6W":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input13 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input30 = Console.ReadLine();

                switch (input30)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "Y6WF":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input14 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input31 = Console.ReadLine();

                switch (input31)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "High School":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input15 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input32 = Console.ReadLine();

                switch (input32)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            case "College":
                Console.Clear();
                Console.WriteLine("What's the name of your school");
                var input16 = Console.ReadLine();
                Console.WriteLine("What's the name of your lesson " + "1.Maths 2.English 3.Sience 4.geografy 5.French or 6.quit");
                var input33 = Console.ReadLine();

                switch (input33)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer1 = Console.ReadLine();

                        switch (answer1)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer3 = Console.ReadLine();

                        switch (answer3)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer4 = Console.ReadLine();

                        switch (answer4)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        var answer5 = Console.ReadLine();

                        switch (answer5)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("do you want to pick to choose student or teacher?");
                                var studorteach = Console.ReadLine();

                                switch (studorteach)
                                {
                                    case "student":
                                        Console.Clear();
                                        Console.WriteLine("how many students?");
                                        var stud = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                    case "teacher":
                                        Console.Clear();
                                        Console.WriteLine("how many teachers?");
                                        var teach = Console.ReadLine();
                                        Console.WriteLine("thanks for info");
                                        break;
                                }
                                break;
                            case "no":
                                Console.Clear();
                                Console.WriteLine("bye! bye!");
                                break;
                        }
                        break;
                }
                break;
            default:
                Console.WriteLine("wrong input!! pick an option from the menu");
                break;
        }
    }
}