using System;
using commapare.cs;
class Menu

{   
	public Menu(){}
    public  string[] DoorParam ;
    public  string[] WDParam;
    public void Start(string A)
    {
        
     Console.WriteLine("-----------------------------------------------------");     
     Console.WriteLine("- {0}, if you want exit type 'E'                    -",A);
     Console.WriteLine("-----------------------------------------------------");
     string input;
     
     input=Console.ReadLine();
     if(input.ToUpper()!="E"){
     Console.WriteLine("-----------------------------------------------------");
     Console.WriteLine("- Enter door Param                                  -");
     Console.WriteLine("-----------------------------------------------------");
     
     input=Console.ReadLine();
     DoorParam=input.Split(' ');
     
     Console.WriteLine("-----------------------------------------------------");
     Console.WriteLine("- Enter WDParam                                     -");
     Console.WriteLine("-----------------------------------------------------");
     
     input=Console.ReadLine();
     WDParam=input.Split(' ');
		
	 Compare inp(WDParam,DoorParam);
		 
     //Compare inp(WDParam,DoorParam);
     string output;
     output=inp.IsPossible? "can":"can't";
     Console.WriteLine("WD {0} throw Door", output);
     //Start("Continue or");
	}
    }



}