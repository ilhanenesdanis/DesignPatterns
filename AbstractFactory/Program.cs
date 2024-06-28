using AbstractFactory.Models;

IEatFactory eatFactory = new TurkishCuisine();

IMainCourse mainCourse = eatFactory.PrepareMeal();
mainCourse.Prepare();

ISalad salad= eatFactory.PrepareSalad();
salad.Prepare();

Console.ReadLine();
