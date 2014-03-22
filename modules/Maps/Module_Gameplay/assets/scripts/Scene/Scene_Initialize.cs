function Module_Gameplay::Scene_Initialize(%this)
{

exec("./Initialize/Initialize.cs");

%this.Ship_Initialize();

%this.World_Limits_Initialize();

%this.Movement_Initialize();

%this.Star_Field_Initialize();

%this.Goal_Initialize();

%this.Enemies_Initialize();

%this.Radar_Initialize();

%this.Score_Initialize();

}
