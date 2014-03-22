function Gui_Main_Menu::Editor_Start(%this)
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Gui_Editor.Scene_Load();

}
