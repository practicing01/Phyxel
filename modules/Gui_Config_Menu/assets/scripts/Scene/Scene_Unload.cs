function Module_Gui_Config_Menu::Scene_Unload(%this)
{

Canvas.popDialog(Gui_Config_Menu);

%this.Ass_Unload();

}
