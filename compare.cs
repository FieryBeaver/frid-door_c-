using door.cs;
using Weardrobe.cs;
using Math;
const bool possible = true;
const bool impossible = false;


class Compare: weardrobe, door
{
 public   enum WearDState
               {
                  SPHERE,
                  BARREL,
                  PARL
                    
               }
public enum DoorState
{
    ROUND,
    SQARE
}
    public int CheckStateWD(){
        if (!Hight)
        {
             return SPHERE;
        }
        if(!Length)
        {
            return BARREL;  // S/R variant
        } 
        else
        {
            return PARL;
        }

        
    }
    public int CheckStateDoor()
    {
        if(!DoorHight)
        {
            return ROUND;
        }
        else
        {
            return SQUARE;
        }

    }
    public enum Door_WD
    { 
        RS,
        RB,
        RP,
        SS,
        SB,
        SP

    }
    public int CheckDoor_WDState()
    {
        int WDState=this->CheckStateWD(); 
        int DState=this->CheckStateDoor();
        switch (WDState)
        {
            case SPHERE:
                return DState==ROUND?RS:SS;
            case Barrel:
                return DState==ROUND?RB:SB;
            case PARL:
                return DState==ROUND?RP:SP;    
        }

    }
    public bool IsPosible()
    {   
        int Door_WDState=this->CheckDoor_WDState();
            switch(Door_WDState)
            {
                case RS:
                    return Diametr<DoorWidth;
                case SS:
                    return Diametr<=Math.Min(DoorWidh,DoorHight);
                case RB:
                  double diagonal;
                  diagonal = Math.Sqrt(Diametr*Diametr+Length*Length);
                  return DoorWidth=>diagonal;
                case SB: 
                    return Math.Max(Diametr,Length)<= Math.Max(DoorWidh,DoorHight) && Math.Min(Diametr,Length)<= Math.Min(DoorWidh,DoorHight); 
                case RP:
                    int minA=Math.Min(Diametr,Length);
                    int minB=Math.Min(Math.Max(Diametr,Length),Width);
                    double diagonal;
                    diagonal = Math.Sqrt(minA*minA+minB*minB);
                    return DoorWidth=>diagonal;
                case SP:
                    int minA=Math.Min(Diametr,Length);
                    int minB=Math.Min(Math.Max(Diametr,Length),Width);
                    return Math.Max(minA,minB)<=Math.Max(DoorWidh,DoorHight) && Math.Min(minA,minB)<=Math.Min(DoorWidh,DoorHight);
            }
                


    }
}


