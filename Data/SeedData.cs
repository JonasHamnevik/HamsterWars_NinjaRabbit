using HamsterWars.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public class SeedData
{
    public static void Initialize(HamsterWarsDbContext context)
    {
        if (context == null)
        {
            throw new InvalidDataException("Null HamsterWarsDbContext");
        }

        if (context.Hamsters.Any())
        {
            return;
        }

        var hamsters = new Hamster[]
            {
                //id 1
                new Hamster
                {
                    Name = "Vanilla",
                    Age = 3,
                    FavouriteFood = "Carrots",
                    Loves = "Hamster wheels",
                    ImageName = "/hamster-1.jpg"
                },
                //id 2
                new Hamster
                {
                    Name = "Dulcie",
                    Age = 1,
                    FavouriteFood = "Apples",
                    Loves = "Hide and seek",
                    ImageName = "/hamster-2.jpg"
                },
                //id 3
                new Hamster
                {
                    Name = "Ipaku",
                    Age = 4,
                    FavouriteFood = "Hard boiled eggs",
                    Loves = "Hamsterwheels",
                    ImageName = "/hamster-3.jpg"
                },
                //id 4
                new Hamster
                {
                    Name = "Indigo",
                    Age = 5,
                    FavouriteFood = "Cucumbers",
                    Loves = "His owners",
                    ImageName = "/hamster-4.jpg"
                },
                //id 5
                new Hamster
                {
                    Name = "Fluffy",
                    Age = 2,
                    FavouriteFood = "Carrots",
                    Loves = "Food",
                    ImageName = "/hamster-5.jpg"
                },
                //id 6
                new Hamster
                {
                    Name = "Paige",
                    Age = 2,
                    FavouriteFood = "Apples",
                    Loves = "The Gardenwalks",
                    ImageName = "/hamster-6.jpg"
                },
                //id 7
                new Hamster
                {
                    Name = "Jammy",
                    Age = 1,
                    FavouriteFood = "Crackers",
                    Loves = "Sleeping",
                    ImageName = "/hamster-7.jpg"
                },
                //id 8
                new Hamster
                {
                    Name = "Vinnie",
                    Age = 3,
                    FavouriteFood = "Apples",
                    Loves = "Plastic ball",
                    ImageName = "/hamster-8.jpg"
                },
                //id 9
                new Hamster
                {
                    Name = "Gabby",
                    Age = 6,
                    FavouriteFood = "Carrots",
                    Loves = "Sleeping",
                    ImageName = "/hamster-9.jpg"
                },
                //id 10
                new Hamster
                {
                    Name = "Dessy",
                    Age = 4,
                    FavouriteFood = "Hard boiled eggs",
                    Loves = "Hamsterwheels",
                    ImageName = "/hamster-10.jpg"
                },
                //id 11
                new Hamster
                {
                    Name = "Ives",
                    Age = 2,
                    FavouriteFood = "Apples",
                    Loves = "His owners",
                    ImageName = "/hamster-11.jpg"
                },
                //id 12
                new Hamster
                {
                    Name = "Caville",
                    Age = 3,
                    FavouriteFood = "Cucumbers",
                    Loves = "Sleeping",
                    ImageName = "/hamster-12.jpg"
                },
                //id 13
                new Hamster
                {
                    Name = "Victoria",
                    Age = 4,
                    FavouriteFood = "Crackers",
                    Loves = "Food",
                    ImageName = "/hamster-13.jpg"
                },
                //id 14
                new Hamster
                {
                    Name = "Pierce",
                    Age = 1,
                    FavouriteFood = "Carrots",
                    Loves = "Food",
                    ImageName = "/hamster-14.jpg"
                },
                //id 15
                new Hamster
                {
                    Name = "Dio",
                    Age = 1,
                    FavouriteFood = "Hard boiled eggs",
                    Loves = "Sleeping",
                    ImageName = "/hamster-15.jpg"
                },
                //id 16
                new Hamster
                {
                    Name = "Quinn",
                    Age = 5,
                    FavouriteFood = "Apples",
                    Loves = "Hamsterwheels",
                    ImageName = "/hamster-16.jpg"
                },
                //id 17
                new Hamster
                {
                    Name = "Ronnie",
                    Age = 7,
                    FavouriteFood = "Cucumbers",
                    Loves = "His owners",
                    ImageName = "/hamster-17.jpg"
                },
                //id 18
                new Hamster
                {
                    Name = "Yamon",
                    Age = 5,
                    FavouriteFood = "Apples",
                    Loves = "Sleeping",
                    ImageName = "/hamster-18.jpg"
                },
                //id 19
                new Hamster
                {
                    Name = "Ralph",
                    Age = 2,
                    FavouriteFood = "Carrots",
                    Loves = "Food",
                    ImageName = "/hamster-19.jpg"
                },
                //id 20
                new Hamster
                {
                    Name = "Jock",
                    Age = 4,
                    FavouriteFood = "Crackers",
                    Loves = "Hamsterwheels",
                    ImageName = "/hamster-20.jpg"
                },
                //id 21
                new Hamster
                {
                    Name = "Yasmine",
                    Age = 3,
                    FavouriteFood = "Apples",
                    Loves = "Sleeping",
                    ImageName = "/hamster-21.jpg"
                },
                //id 22
                new Hamster
                {
                    Name = "Uma",
                    Age = 5,
                    FavouriteFood = "Carrots",
                    Loves = "His owners",
                    ImageName = "/hamster-22.jpg"
                },
                //id 23
                new Hamster
                {
                    Name = "Herbie",
                    Age = 2,
                    FavouriteFood = "Hard boiled eggs",
                    Loves = "Food",
                    ImageName = "/hamster-23.jpg"
                },
                //id 24
                new Hamster
                {
                    Name = "Hana",
                    Age = 3,
                    FavouriteFood = "Cucumbers",
                    Loves = "Sleeping",
                    ImageName = "/hamster-24.jpg"
                },
                //id 25
                new Hamster
                {
                    Name = "Zia",
                    Age = 4,
                    FavouriteFood = "Apples",
                    Loves = "Hamsterwheels",
                    ImageName = "/hamster-25.jpg"
                },
                //id 26
                new Hamster
                {
                    Name = "Remi",
                    Age = 5,
                    FavouriteFood = "Carrots",
                    Loves = "Food",
                    ImageName = "/hamster-26.jpg"
                },
                //id 27
                new Hamster
                {
                    Name = "Genevieve",
                    Age = 7,
                    FavouriteFood = "Apples",
                    Loves = "Sleeping",
                    ImageName = "/hamster-27.jpg"
                },
                //id 28
                new Hamster
                {
                    Name = "Queen",
                    Age = 1,
                    FavouriteFood = "Hard boiled eggs",
                    Loves = "Hamsterwheels",
                    ImageName = "/hamster-28.jpg"
                },
                //id 29
                new Hamster
                {
                    Name = "Freddy",
                    Age = 2,
                    FavouriteFood = "Apples",
                    Loves = "His owners",
                    ImageName = "/hamster-29.jpg"
                },
                //id 30
                new Hamster
                {
                    Name = "Galina",
                    Age = 5,
                    FavouriteFood = "Cucumbers",
                    Loves = "Food",
                    ImageName = "/hamster-30.jpg"
                },
                //id 31
                new Hamster
                {
                    Name = "Yogi",
                    Age = 3,
                    FavouriteFood = "Carrots",
                    Loves = "Sleeping",
                    ImageName = "/hamster-31.jpg"
                },
                //id 32
                new Hamster
                {
                    Name = "Inet",
                    Age = 4,
                    FavouriteFood = "Crackers",
                    Loves = "Hamsterwheels",
                    ImageName = "/hamster-32.jpg"
                },
                //id 33
                new Hamster
                {
                    Name = "Fawn",
                    Age = 1,
                    FavouriteFood = "Carrots",
                    Loves = "His owners",
                    ImageName = "/hamster-33.jpg"
                },
                //id 34
                new Hamster
                {
                    Name = "Dixie",
                    Age = 7,
                    FavouriteFood = "Apples",
                    Loves = "Food",
                    ImageName = "/hamster-34.jpg"
                },
                //id 35
                new Hamster
                {
                    Name = "Bonita",
                    Age = 6,
                    FavouriteFood = "Hard boiled eggs",
                    Loves = "Sleeping",
                    ImageName = "/hamster-35.jpg"
                }
        };
        context.AddRange(hamsters);
        context.SaveChanges();
    }
}