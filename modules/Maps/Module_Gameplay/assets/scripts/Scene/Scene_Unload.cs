function Module_Gameplay::Scene_Unload(%this)
{

%this.Bool_Is_Playing=false;

%this.Gui_Text_Score.delete();

Canvas.popDialog(Gui_Gameplay);

%this.Ass_Unload();

}
