exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");
exec("./../Classes/Classes.cs");

function Module_Gameplay::Scene_Load(%this)
{

%this.Ass_Load();

Scene_Phyxel.clear();

%this.Scene_Current=TamlRead("./../../scenes/Scene_Module_Gameplay.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

if (!isObject(Gui_Gameplay))
{

Phyxel.add(TamlRead("./../../gui/Gui_Gameplay.gui.taml"));

}

Canvas.pushDialog(Gui_Gameplay);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
