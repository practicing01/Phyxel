function Splashes::Main_Menu_Load(%this)
{

ModuleDatabase.LoadExplicit("Module_Gui_Main_Menu");

Module_Gui_Main_Menu.Scene_Load();

}

function Splashes::Splash_Logo_Torque(%this)
{

Scene_Phyxel.clear();

alxPlay("Splashes:audio_torquewrench");

%Sprite_Logo_Torque=new Sprite()
{
Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Logo_Torque);
Image="Splashes:Image_Logo_Torque";
BodyType="static";
};

Scene_Phyxel.add(%Sprite_Logo_Torque);

%this.Scene_Unload();

schedule(3000,0,"Splashes::Main_Menu_Load",%this);

}
