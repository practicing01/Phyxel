function Module_Gameplay::Goal_Initialize(%this)
{

%Vector_2D_Randomized_Offset="0 0";

%Vector_2D_Randomized_Offset.X=getRandom(0+%this.Vector_2D_Player_Size.X,%this.Vector_2D_World_Limits.X-%this.Vector_2D_Player_Size.X);

%Vector_2D_Randomized_Offset.Y=getRandom(0+%this.Vector_2D_Player_Size.Y,%this.Vector_2D_World_Limits.Y-%this.Vector_2D_Player_Size.Y);

%Sprite_Goal=new Scroller()
{

Position=%Vector_2D_Randomized_Offset;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Goal);
Image="Module_Gameplay:Image_Goal";
Animation="Module_Gameplay:Animation_Goal";
class="Class_Goal";
BodyType="static";
SceneLayer=17;

CollisionCallback="true";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Goal.Position.X+=40;

%Sprite_Goal.setCollisionGroups(26);

%Sprite_Goal.Collision_Shape_Index=%Sprite_Goal.createPolygonBoxCollisionShape(%Sprite_Goal.Size);

%Sprite_Goal.setCollisionShapeIsSensor(%Sprite_Goal.Collision_Shape_Index,true);

Scene_Phyxel.add(%Sprite_Goal);

%this.Sprite_Goal=%Sprite_Goal;

}
