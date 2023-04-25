namespace Practice_inheritance
{
    public class Helicopter:Air
    {
        public int NumberOfPropellers { get; set; }

        public Helicopter(string color, int numberOfPropellers) : base(color)
        {
            NumberOfPropellers = numberOfPropellers;
        }//Constructor

        public override string ToString()
        {
            return base.ToString() + $" - Number of Propellers: {NumberOfPropellers}";

        }//ToString

    }//Class

}//NameSpace