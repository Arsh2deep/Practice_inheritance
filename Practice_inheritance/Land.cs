namespace Practice_inheritance
{
    public class Land : Vehicle
    {
        public int Wheels { get; set; }

        public Land(string color, int wheels) : base(color)
        {
            Wheels = wheels;

        }//Constructor

        public override string ToString()
        {
            return base.ToString() + $" - Number of Wheels: {Wheels}";

        }//ToString

    }//Class

}//NameSpace