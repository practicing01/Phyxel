function Gui_Pause_Menu::Go_Main_Menu(%this)
{

Module_Player_Class.Player_Data_Clear();

if (isObject($Simset_Players_Information))
{

$Simset_Players_Information.deleteObjects();

}

if (isObject($Simset_ModuleID_Player_Sprites))
{

$Simset_ModuleID_Player_Sprites.deleteObjects();

}

$Module_ID_Map_Loaded.Scene_Unload();

$Module_ID_Map_Loaded=0;

for (%x=0;%x<$Simset_Cards_To_Load.getCount();%x++)
{

%Object=$Simset_Cards_To_Load.getObject(%x);

ModuleDatabase.unloadExplicit(%Object.Module_ID_Card);

}

if (isObject($Simset_Deck_To_Load))
{

$Simset_Deck_To_Load.deleteObjects();

}

/***********************************************/
/************ Delete Gui's **********************/

for (%x=0;%x<Gui_Phyxel_Overlay.getCount();%x++)
{

%Gui_Child=Gui_Phyxel_Overlay.getObject(%x);

if (%Gui_Child.Bool_Delete_Me==true)
{

Gui_Phyxel_Overlay.remove(%Gui_Child);

%Gui_Child.deleteObjects();

%Gui_Child.delete();

%x=-1;//Restart loop because we just modified the count.

}

}

/***********************************************/

$Bool_Is_Playing=false;

Module_Gui_Chat_Box.Scene_Unload();

Canvas.popDialog(Gui_Pause_Menu);

Module_Gui_Main_Menu.Scene_Load();

}
