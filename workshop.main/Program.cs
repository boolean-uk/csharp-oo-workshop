using workshop.main.Misc;

//overloading constructors
Dog dog1 = new Dog("Pug", "Stitch");
Dog dog2 = new Dog("Pug", "Lola", 2);


//overloading methods
Calculator calculator = new Calculator();
int result = calculator.Add(1, 1);

//dictionary
Dictionary<string, int> myPets = new Dictionary<string, int>()
{
    { "dogs", 2},
    { "cats", 2},
    { "fish", 1},
    { "mice", 2},
    { "children", 2}
};

myPets.ToList().ForEach(i => {
    Console.WriteLine($"{i.Key}:{i.Value}");
});



//List of strings
List<string> animals = new List<string>()
{
    "dog",
    "cat"
};
foreach(string animal in animals)
{
    Console.WriteLine(animal);
}


//list of dogs
List<Dog> dogs = new List<Dog>()
{
    new Dog() { Name="Stanley", Breed="Pug"}
};
dogs.Add(dog1);
dogs.Add(dog2);

dogs.ForEach(d => {
    Console.WriteLine(d.Name);
});


//Tuple
Tuple<string, string, int> me = new Tuple<string, string, int>("Nigel", "S", 33);

Console.WriteLine(me.Item1);