// See https://aka.ms/new-console-template for more information
using Garage;

Vehicle vehicle=new Vehicle();
Tesla tesla=new Tesla();
Cessna cessna=new Cessna();
Zero zero=new Zero();

tesla.MainColor="Tale";
cessna.MainColor="red";
zero.MainColor="white";

tesla.Drive();
tesla.Turn("Right");
tesla.Stop();

cessna.Drive();
cessna.Turn("Right");
cessna.Stop();

zero.Drive();
zero.Turn("Right");
zero.Stop();

