namespace LabInterfaces
{
    internal interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        int Age { get; set; }
        int Height { get; set; }

        void Eat();

        void Cry();
    }
}