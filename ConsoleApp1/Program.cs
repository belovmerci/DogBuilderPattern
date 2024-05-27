using DogBuilderApp;

DogBuilder dogBuilder = new DogBuilder();
Dog dog = dogBuilder.getDog();
dog.toConsole();

dogBuilder.setName("Джек");
dogBuilder.setBreed("Пудель");
dogBuilder.setAge(3);
dogBuilder.setToys(new List<string> {"кость", "курица", "палка" });
Dog dog1 = dogBuilder.getDog();
dog1.toConsole();

dogBuilder.setName("Соня");
dogBuilder.setBreed("Бессмертная");
dogBuilder.setAge(999);
dogBuilder.setToys(new List<string> { "кость", "курица", "палка" });
dogBuilder.setToys(null);
dogBuilder.setToys(new List<string> { "клевер", "ромашка" });
Dog dog2 = dogBuilder.getDog();
dog2.toConsole();

dogBuilder.setName("Наруто");
dogBuilder.setBreed("Хокаге");
dogBuilder.setAge(18);
dogBuilder.setToys(new List<string> { "кунай", "сюрикен", "джутсу" });
dogBuilder.setToys(new List<string> { "клевер", "ромашка" });
Dog dog3 = dogBuilder.getDog();
dog3.toConsole();