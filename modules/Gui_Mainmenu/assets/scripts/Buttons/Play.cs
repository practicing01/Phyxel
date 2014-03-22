function Gui_Main_Menu::Play(%this)
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Gameplay.Scene_Load();

}
