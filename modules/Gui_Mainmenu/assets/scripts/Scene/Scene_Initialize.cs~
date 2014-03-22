function Module_Gui_Main_Menu::Scene_Initialize(%this)
{

/*Splashes explicitly loaded Module_Gui_Main_Menu*/

ModuleDatabase.LoadExplicit("Module_Gui_Config_Menu");
ModuleDatabase.LoadExplicit("Module_Gui_Deck_Builder");
ModuleDatabase.LoadExplicit("Module_Gui_Server_Menu");
ModuleDatabase.LoadExplicit("Module_Gui_Chat_Box");
ModuleDatabase.LoadExplicit("Module_Master_Server");
ModuleDatabase.LoadExplicit("Module_Server");
ModuleDatabase.LoadExplicit("Module_Player_Class");

Module_Player_Class.Player_Class_Load();

/*Search for Player Sprites.*/

Gui_List_Main_Menu_Player_Sprites.clearItems();

%Player_Sprite_Modules=ModuleDatabase.findModuleTypes("Player_Sprite",false);

if (isObject($Simset_ModuleID_Player_Sprites))
{

$Simset_ModuleID_Player_Sprites.deleteObjects();

$Simset_ModuleID_Player_Sprites.delete();

}

$Simset_ModuleID_Player_Sprites=new SimSet();

%Player_Sprite_Count=getWordCount(%Player_Sprite_Modules);

for (%x=0;%x<%Player_Sprite_Count;%x++)
{

%Module_ID_Player_Sprite=getWord(%Player_Sprite_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite.ModuleId);

%Script_Object_Player_Sprite=new ScriptObject()
{
Module_ID_Player_Sprite=%Module_ID_Player_Sprite.ModuleId;
String_Description=%Module_ID_Player_Sprite.Description;
};

$Simset_ModuleID_Player_Sprites.add(%Script_Object_Player_Sprite);

Gui_List_Main_Menu_Player_Sprites.addItem(%Module_ID_Player_Sprite.Description);

}

/*Clear cards.*/

if (isObject($Simset_Cards_To_Load))
{

$Simset_Cards_To_Load.deleteObjects();
$Simset_Cards_To_Load.delete();

}

$Simset_Already_Loaded_Card_Modules.deleteObjects();

$Simset_Cards_To_Load=new SimSet();

$Bool_Is_Local_Connection=false;

/*No prototype for Gui_List_Servers, naughty code :y */
Gui_List_Servers.clearItems();

Dots_and_Crits.Client_Load();

}
