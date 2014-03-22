function Module_Gameplay::World_Limits_Initialize(%this)
{

//Top wall.

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X/2 SPC "0";
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Player_Size.Y;
class="Class_Wall";
SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,24,25,26);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Phyxel.add(%Sprite_Wall);

//Bottom wall.

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X/2 SPC %this.Vector_2D_World_Limits.Y;
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Player_Size.Y;
class="Class_Wall";
SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,24,25,26);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Phyxel.add(%Sprite_Wall);

//Left wall.

%Sprite_Wall=new Sprite()
{

Position="0" SPC %this.Vector_2D_World_Limits.Y/2;
Size=%this.Vector_2D_Player_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Wall";
SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,24,25,26);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Phyxel.add(%Sprite_Wall);

//Right wall.

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_World_Limits.Y/2;
Size=%this.Vector_2D_Player_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Wall";
SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,24,25,26);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Phyxel.add(%Sprite_Wall);

}
