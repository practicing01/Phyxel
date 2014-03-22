function Module_Gameplay::Variables_Initialize(%this)
{

%this.Vector_2D_Player_Size="8 8";

%this.Vector_2D_Phyxel_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Panel);

%this.Joint_Distance_Frequency=0;

%this.Joint_Distance_Damping_Ratio=1;

%this.Float_Phyxel_Density=0;//0.1;

%this.Float_Phyxel_Restitution=0;//0.5;

%this.Vector_2D_World_Limits=Phyxel.Resolution.X*0.5 SPC Phyxel.Resolution.Y*0.5;

%this.Sprite_Phyxel_Player=0;

%this.Float_Player_Speed=25;

%this.Float_Player_Move_Magnitude=10;

%this.Int_Player_Move_Schedule_Interval=500;

%this.Int_Player_Rotate_Speed=1;

%this.Int_Player_Swipe_Dampener=2;

%this.Int_Player_Cannon_Fire_Schedule_Interval=1000;

%this.Float_Player_Cannon_Fire_Speed=50;

%this.Float_Player_Cannon_Radius_Multiplier=40;

%this.Scroller_Star_Field=0;

%this.Float_Star_Field_Speed=10;

%this.Sprite_Goal=0;

%this.Int_Enemy_Count=1;

%this.GuiSpriteCtrl_Radar=0;

%this.Int_Radar_Rotate_Schedule_Interval=500;

%this.Gui_Text_Score=0;

%this.Int_Score=0;

%this.Float_Enemy_Lifetime=1;

%this.Bool_Is_Playing=true;

%this.Char_Previous_Swipe_Direction=0;//0=left 1=right

}
