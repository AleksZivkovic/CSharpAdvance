// See https://aka.ms/new-console-template for more information


using SEDC.Advance.Class06.Events;

Market tineks = new Market()
{
    Name = "Tineks",
    CurrentProductType = ProductType.Food
};

Market reptil = new Market()
{
    Name = "Reptil",
    CurrentProductType = ProductType.Cosmetics
};

Market market = new Market()
{
    Name = "Neptun",
    CurrentProductType = ProductType.Electronics
};

User aleksandar = new User("Aleksandar", "Zivkovic", 35, "zivkovic.aleks@gmail.com");
User aneta = new User("Aneta", "Stankovska", 18, "aneta.stank@gmail.com");
User stefan = new User("Stefan", "Ivanovski", 30, "stefan.ivanovski@hotmail.com");

tineks.SubscribeToPromotion(aleksandar.ReadPromotion, aleksandar.Email);
tineks.SubscribeToPromotion(aneta.ReadPromotion, aneta.Email);
tineks.SubscribeToPromotion(stefan.ReadPromotion, stefan.Email);
