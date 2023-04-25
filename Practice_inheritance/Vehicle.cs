namespace Practice_inheritance
{
    public class Vehicle
    {
        public string Color { get; set; }

        public Vehicle(string color)
        {
            Color = color;

        }//Constructor

        public override string ToString()
        {
            return $"{GetType().Name} - {Color}";

        }//ToString

    }//Class

}//NameSpace