exec("./../Torque/Splash_Logo_Torque.cs");
exec("./../OGA/Splash_OGA.cs");
exec("./../Dove/Dove_Construct.cs");
exec("./../Dove/onCollision.cs");

function Splashes::Scene_Initialize(%this)
{

%this.Bool_Company_Name_Displayed=false;

%this.Dove_Construct();

Scene_Phyxel.setGravity(0,-50);//so the dove drops

}
