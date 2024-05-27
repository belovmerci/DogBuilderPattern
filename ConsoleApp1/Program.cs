using DogBuilderApp;

DogBuilder dogBuilder = new DogBuilder();
Dog dog = dogBuilder.getDog();
dog.toConsole();

dogBuilder.setName("Джек").setBreed("Пудель").setAge(3)
    .setToys(new List<string> {"кость", "курица", "палка" });
Dog dog1 = dogBuilder.getDog();
dog1.toConsole();

dogBuilder.setName("N. Ull").setBreed("Nolla").setAge(3)
    .setToys(new List<string> { "0", "zero", "null" });
Dog dog0 = dogBuilder.getDog();
dog0.toConsole();

dogBuilder.setName("Соня").setBreed("Бессмертная").setAge(999)
    .setToys(new List<string> { "кость", "курица", "палка" });
dogBuilder.setToys(null).setToys(new List<string> { "клевер", "ромашка" });
Dog dog2 = dogBuilder.ResetAndGetDog();
dog2.toConsole();

dogBuilder.setName("Наруто").setBreed("Хокаге").setAge(18)
    .setToys(new List<string> { "кунай", "сюрикен", "джутсу" })
    .setToys(new List<string> { "клевер", "ромашка" });
Dog dog3 = dogBuilder.ResetAndGetDog();
dog3.toConsole();

dogBuilder.setName(" ").setBreed(" ").setAge(-12572342)
    .setToys(new List<string> { "кость", "курица", "палка" });
dogBuilder.setToys(null).setToys(new List<string> { "клевер", "ромашка" });

dogBuilder.ResetAndGetDog();
Dog dog4 = dogBuilder.getDog();
dog4.toConsole();