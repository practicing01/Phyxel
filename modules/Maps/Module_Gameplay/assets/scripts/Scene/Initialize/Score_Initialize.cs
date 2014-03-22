function Module_Gameplay::Score_Initialize(%this)
{

%this.Gui_Text_Score=new GuiMLTextCtrl()
{

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("400 0","800 480",Phyxel.Resolution);
HorizSizing="relative";
VertSizing="relative";
Text="Score: 0"; 
Extent="100 100";
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";

};

Gui_Gameplay.addGuiControl(%this.Gui_Text_Score);

}
