function Gui_Main_Menu::Instructions(%this)
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Gui_Instructions_Menu.Scene_Load();

}
