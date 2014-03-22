function Gui_Main_Menu::Configure(%this)
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Gui_Config_Menu.Scene_Load();

}
