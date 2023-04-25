namespace Practice_inheritance
{
    public class Plane:Air
    {
        public int NumberOfJets { get; set; }

        public Plane(string color, int numberOfJets) : base(color)
        {
            NumberOfJets = numberOfJets;

        }//Constructor

        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets: {NumberOfJets}";

        }//ToString

    }//Class

}//NameSpace