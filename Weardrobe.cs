
class Weardrobe
{
    Weardrobe(double _d=0,double _h=0,double _l=0)
    {
		Diametr=_d;
		Hight=_h;
        Length=_l;
    }
    ~Weardrobe(){}
	public double Diametr {get;set;}
	public double Hight{get;set;}
    public double Length{get;set;}
}