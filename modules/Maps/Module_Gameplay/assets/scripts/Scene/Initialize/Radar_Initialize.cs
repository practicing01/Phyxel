function Module_Gameplay::Radar_Initialize(%this)
{return;
/*//The proceeding code won't work cus T2D is gimped.
%GuiSpriteCtrl_Radar=new GuiSpriteCtrl()
{

HorizSizing="relative";
VertSizing="relative";
Extent="32 32";
Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("0 448","800 480",Phyxel.Resolution);
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Gameplay:Image_Radar";

class="Class_Radar";

Schedule_Rotate=0;

Module_ID_Parent=%this;

};

Gui_Gameplay.addGuiControl(%GuiSpriteCtrl_Radar);

%GuiSpriteCtrl_Radar.Frame=0;

%this.GuiSprite_Radar=%GuiSpriteCtrl_Radar;

%GuiSpriteCtrl_Radar.Schedule_Rotate=schedule(0,0,"Class_Radar::Rotate",%GuiSpriteCtrl_Radar);
*/

%this.GuiSprite_Radar=Gui_Gameplay_Radar;

Gui_Gameplay_Radar.Schedule_Rotate=schedule(0,0,"Class_Radar::Rotate",Gui_Gameplay_Radar);

}
