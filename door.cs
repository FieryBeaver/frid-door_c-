class Door
{
    public  Door(double _d=0,double _h=0)
    {
		DoorWidth=_d;
        DoorHight=_h;

    }
    ~Door(){}
    public double DoorHight{get;set;}
    public double DoorWidth{get;set;}


}