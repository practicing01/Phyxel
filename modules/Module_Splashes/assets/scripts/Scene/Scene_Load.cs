exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");

function Splashes::Scene_Load(%this)
{

if ($platform$="Android")
{

hideSplashScreen();//Android specific.

}

%this.Ass_Load();

Scene_Phyxel.clear();

%this.Scene_Current=TamlRead("./../../scenes/Splashes.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
