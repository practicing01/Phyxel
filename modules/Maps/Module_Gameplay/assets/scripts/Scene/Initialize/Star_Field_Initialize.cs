function Module_Gameplay::Star_Field_Initialize(%this)
{

%Scroller_Star_Field=new Scroller()
{

Position=%this.Sprite_Phyxel_Player.Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Star_Field);
Image="Module_Gameplay:Image_Star_Field";
class="Class_Star_Field";
BodyType="dynamic";
SceneLayer=31;

DefaultDensity=0;

DefaultRestitution=0;

};

%Scroller_Star_Field.Size.X*=2;

%Scroller_Star_Field.Size.Y*=2;

Scene_Phyxel.add(%Scroller_Star_Field);

Scene_Phyxel.createDistanceJoint(%Scroller_Star_Field,%this.Sprite_Phyxel_Player,"0 0","0 0",
0,
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

%this.Scroller_Star_Field=%Scroller_Star_Field;

}
