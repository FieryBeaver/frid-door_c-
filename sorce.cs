
using System;
					
public class Program
{
	public static void Main()
	{
		// string test="test";
		//Console.WriteLine(test.ToUpper());
		//if(test.ToUpper()=="TEST")Console.WriteLine(test);
		//Console.WriteLine(test);
		string door_round,round;
		int wid,len,hig,door_wid,door_hig;
		//read params----------------------------
		Console.WriteLine("if fridge have round side type R if it sphere type S if it paralelogram type p");//fridge
		while(true){
			round=Console.ReadLine();
			round=round.ToUpper();
			if(round=="R" || round=="S" || round=="P"){break;}
			Console.WriteLine("enter valid symbo");
		}
		
		Console.WriteLine("if door round type R else type p ");//Door param
		while(true){
			door_round=Console.ReadLine();
			door_round=door_round.ToUpper();			
			if(door_round=="R"|| door_round=="P"){break;}
			Console.WriteLine("enter valid symbo");
		}
		//end read params/ start case  R S/R p-------------------------
		if(door_round== "R" && (round=="S" || round=="R")){
		
		Console.WriteLine("enter door r");door_wid=Convert.ToInt16(Console.ReadLine());
		Console.WriteLine("enter fridge d");wid=Convert.ToInt16(Console.ReadLine());
		
		if(wid <= door_wid)Console.WriteLine("Can");
		else {Console.WriteLine("Can't");}
		}		
		//end case R S/ start case  R, p
		//else{
				if(round == "P" && door_round=="r"){

				Console.WriteLine("enter fridge param wid,len,hig");
				hig=Convert.ToInt16(Console.ReadLine());
				len=Convert.ToInt16(Console.ReadLine());
				wid=Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("enter door wid");door_wid=Convert.ToInt16(Console.ReadLine());	

				double diagonals=Math.Pow((Math.Pow(len,2)+Math.Pow(wid,2)),2);
				if(diagonals <= door_wid){ Console.WriteLine("Can"); return ;}
				diagonals=Math.Pow((Math.Pow(hig,2)+Math.Pow(wid,2)),2);
				if(diagonals <= door_wid){ Console.WriteLine("Can"); return ;}
				diagonals=Math.Pow((Math.Pow(len,2)+Math.Pow(hig,2)),2);
				if(diagonals <= door_wid){ Console.WriteLine("Can"); return ;}
				}
			
	
		
		//end caase R,p/start p,s---------------
		if(round == "P" && door_round=="r"){
			Console.WriteLine("eter door param wid, hig");
			door_wid=Convert.ToInt16(Console.ReadLine());
			door_hig=Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("enter fridge r");wid=Convert.ToInt16(Console.ReadLine())/2;
			if(wid<= door_wid && wid<=door_hig){Console.WriteLine("Can");}
		
		
		}
		// Start case p p /r-------------------------
	//else{
		if((round =="R" ||round == "P" )&& door_round=="P"){
			
			Console.WriteLine("enter fridge param wid,len,hig");
			hig=Convert.ToInt16(Console.ReadLine());
			len=Convert.ToInt16(Console.ReadLine());
			wid=Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("eter door param wid, hig");
			door_wid=Convert.ToInt16(Console.ReadLine());
			door_hig=Convert.ToInt16(Console.ReadLine());
			
			if(wid<=door_wid&&(hig <=door_hig || len <= door_hig) || hig<=door_wid && (wid <=door_hig || door_hig>len) || len <= door_wid && ( wid <=door_hig || door_hig > hig)){
					Console.WriteLine("Can");
														   																										}

			else{
				Console.WriteLine("Can't");
				}			
		}
	}
	//- end case  P P	
	}

