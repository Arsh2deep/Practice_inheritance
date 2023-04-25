namespace Practice_inheritance
{
    internal class Sea : Vehicle
    {
        public string Type { get; set; }

        public Sea(string color, string type) : base(color)
        {
            Type = type;
        }

        public override string ToString()
        {
            return base.ToString() + $" - It is a {Type}";
        }
    }
}