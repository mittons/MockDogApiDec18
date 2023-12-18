public class BreedService
{
    public List<Breed> GetBreeds()
    {
        return new List<Breed>
        {
            new Breed
            {
                Weight = new Dimension { Imperial = "6 - 13", Metric = "3 - 6" },
                Height = new Dimension { Imperial = "9 - 11.5", Metric = "23 - 29" },
                Id = 1,
                Name = "Affenpinscher",
                BredFor = "Small rodent hunting, lapdog",
                BreedGroup = "Toy",
                LifeSpan = "10 - 12 years",
                Temperament = "Stubborn, Curious, Playful, Adventurous, Active, Fun-loving",
                Origin = "Germany, France",
                ReferenceImageId = "BJa4kxc4X"
            },
            new Breed
            {
                Weight = new Dimension { Imperial = "50 - 60", Metric = "23 - 27" },
                Height = new Dimension { Imperial = "25 - 27", Metric = "64 - 69" },
                Id = 2,
                Name = "Afghan Hound",
                CountryCode = "AG",
                BredFor = "Coursing and hunting",
                BreedGroup = "Hound",
                LifeSpan = "10 - 13 years",
                Temperament = "Aloof, Clownish, Dignified, Independent, Happy",
                Origin = "Afghanistan, Iran, Pakistan",
                ReferenceImageId = "hMyT4CDXR"
            },
            new Breed
            {
                Weight = new Dimension { Imperial = "44 - 66", Metric = "20 - 30" },
                Height = new Dimension { Imperial = "30", Metric = "76" },
                Id = 3,
                Name = "African Hunting Dog",
                BredFor = "A wild pack animal",
                LifeSpan = "11 years",
                Temperament = "Wild, Hardworking, Dutiful",
                ReferenceImageId = "rkiByec47"
            }
        };
    }
}
