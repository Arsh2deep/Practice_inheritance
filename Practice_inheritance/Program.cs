namespace Practice_inheritance;
class Program
{
    static void Main(string[] args)
    {
        
        Vehicle vehicle = new Vehicle("Red");
        Air air = new Air("Green");
        Helicopter helicopter = new Helicopter("Blue",2);
        Plane plane = new Plane("Pink",3);
        Sea sea = new Sea("Orange","Submarine");
        Land land = new Land("Purple",4);

        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(vehicle);
        vehicles.Add(land);
        vehicles.Add(air);
        vehicles.Add(sea);
        vehicles.Add(plane);
        vehicles.Add(helicopter);

        foreach (var v in vehicles)
        {
            Console.WriteLine(v.ToString());

        }//loop

    }//Main

}//Class

