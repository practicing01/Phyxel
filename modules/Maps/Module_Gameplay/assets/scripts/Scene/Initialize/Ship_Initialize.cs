function Module_Gameplay::Ship_Initialize(%this)
{

/*****************************************************************/

%Vector_2D_Randomized_Offset="0 0";

%Vector_2D_Randomized_Offset.X=getRandom(0+%this.Vector_2D_Player_Size.X,%this.Vector_2D_World_Limits.X-%this.Vector_2D_Player_Size.X);

%Vector_2D_Randomized_Offset.Y=getRandom(0+%this.Vector_2D_Player_Size.Y,%this.Vector_2D_World_Limits.Y-%this.Vector_2D_Player_Size.Y);

//Central player phyxel, all other phyxels are connected to it.

%Sprite_Phyxel_Player=new Sprite()
{

Position=(%this.Vector_2D_Player_Size.X/2)*%this.Vector_2D_Phyxel_Size.X SPC (%this.Vector_2D_Player_Size.Y/2)*%this.Vector_2D_Phyxel_Size.Y;
Size=%this.Vector_2D_Phyxel_Size;
Image="Module_Gameplay:Image_Panel";
class="Class_Phyxel_Player";
CollisionCallback="true";
SceneLayer=16;

BlendColor="1.0 1.0 1.0 1.0";

FixedAngle=false;

AngularDamping=10;

DefaultDensity=1000;

DefaultRestitution=0;

SceneGroup=26;

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Script_Object_Input_Controller=0;

Sprite_Phyxel_Player=0;

Schedule_Move=0;

SimSet_Connected_Phyxels=0;

};

%Sprite_Phyxel_Player.SimSet_Connected_Phyxels=new SimSet();

%Sprite_Phyxel_Player.Sprite_Phyxel_Player=%Sprite_Phyxel_Player;

%Sprite_Phyxel_Player.Position.X+=%Vector_2D_Randomized_Offset.X;

%Sprite_Phyxel_Player.Position.Y+=%Vector_2D_Randomized_Offset.Y;

%Sprite_Phyxel_Player.setCollisionGroups(0,25,30);

%Sprite_Phyxel_Player.Collision_Shape_Index=%Sprite_Phyxel_Player.createPolygonBoxCollisionShape(%Sprite_Phyxel_Player.Size);

Scene_Phyxel.add(%Sprite_Phyxel_Player);

Window_Phyxel.mount(%Sprite_Phyxel_Player,"0 0",0,true,true);

%this.Sprite_Phyxel_Player=%Sprite_Phyxel_Player;

/*****************************************************************/

//Randomly generate phyxels for the ship shape.

%SimSet_Y=new SimSet();

for (%y=0;%y<%this.Vector_2D_Player_Size.Y;%y++)
{

%SimSet_X=new SimSet();

%SimSet_Y.add(%SimSet_X);

%Bool_Skip_X=getRandom(0,1);

for (%x=0;%x<%this.Vector_2D_Player_Size.X;%x++)
{

%ScriptObject_Phyxel=new ScriptObject()
{

Sprite_Phyxel=0;

};

%SimSet_X.add(%ScriptObject_Phyxel);

}

//if (%Bool_Skip_X){continue;}

%Int_Start_X=getRandom(0,%this.Vector_2D_Player_Size.X-2);
//%Int_Start_X=getRandom(0,%this.Vector_2D_Player_Size.X/2);

%Int_End_X=getRandom(%Int_Start_X+1,%this.Vector_2D_Player_Size.X-1);
//%Int_End_X=getRandom((%this.Vector_2D_Player_Size.X/2)+1,%this.Vector_2D_Player_Size.X-1);

for (%x=%Int_Start_X;%x<=%Int_End_X;%x++)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

%Sprite_Phyxel=new Sprite()
{

Position=%x*%this.Vector_2D_Phyxel_Size.X SPC %y*%this.Vector_2D_Phyxel_Size.Y;
Size=%this.Vector_2D_Phyxel_Size;
Image="Module_Gameplay:Image_Panel";
class="Class_Phyxel_Player";
CollisionCallback="true";
SceneLayer=16;

BlendColor="1.0 1.0 1.0 1.0";

FixedAngle=false;

AngularDamping=10;

DefaultDensity=%this.Float_Phyxel_Density;//getRandomF(0,1);

DefaultRestitution=%this.Float_Phyxel_Restitution;//getRandomF(0,1);

SceneGroup=26;

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Collision_Shape_Index_Cannon=-1;

Sprite_Phyxel_Player=%Sprite_Phyxel_Player;

Vector_2D_Original_Offset="0 0";//Angle, Distance

Bool_Is_Cannon=false;

Sprite_Cannon_Target=0;

Schedule_Cannon_Fire=0;

};

%Sprite_Phyxel.Bool_Is_Cannon=getRandom(0,1);

if (%Sprite_Phyxel.Bool_Is_Cannon)
{

%Sprite_Phyxel.Image="Module_Gameplay:Image_Cannon";

%Radius=0;

if (%Sprite_Phyxel.Size.X>%Sprite_Phyxel.Size.Y){%Radius=%Sprite_Phyxel.Size.X*%this.Float_Player_Cannon_Radius_Multiplier;}else{%Radius=%Sprite_Phyxel.Size.Y*%this.Float_Player_Cannon_Radius_Multiplier;}

%Sprite_Phyxel.Collision_Shape_Index_Cannon=%Sprite_Phyxel.createCircleCollisionShape(%Radius);

%Sprite_Phyxel.setCollisionShapeIsSensor(%Sprite_Phyxel.Collision_Shape_Index_Cannon,true);

}

%Sprite_Phyxel.Position.X+=%Vector_2D_Randomized_Offset.X;

%Sprite_Phyxel.Position.Y+=%Vector_2D_Randomized_Offset.Y;

%Sprite_Phyxel.Vector_2D_Original_Offset.X=Vector2AngleToPoint(%Sprite_Phyxel_Player.Position,%Sprite_Phyxel.Position);

%Sprite_Phyxel.Vector_2D_Original_Offset.Y=Vector2Distance(%Sprite_Phyxel_Player.Position,%Sprite_Phyxel.Position);

%Sprite_Phyxel.setCollisionGroups(0,25,30);

%Sprite_Phyxel.Collision_Shape_Index=%Sprite_Phyxel.createPolygonBoxCollisionShape(%Sprite_Phyxel.Size);

Scene_Phyxel.add(%Sprite_Phyxel);

%ScriptObject_Phyxel.Sprite_Phyxel=%Sprite_Phyxel;

Scene_Phyxel.createDistanceJoint(%Sprite_Phyxel,%Sprite_Phyxel_Player,"0 0","0 0",
Vector2Distance(%Sprite_Phyxel.Position,%Sprite_Phyxel_Player.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

/*Scene_Phyxel.createWeldJoint(%Sprite_Phyxel,%Sprite_Phyxel_Player,
%Sprite_Phyxel.getLocalVector(%Sprite_Phyxel_Player.Position),
%Sprite_Phyxel_Player.getLocalVector(%Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);*/

/*Scene_Phyxel.createRevoluteJoint(%Sprite_Phyxel,%Sprite_Phyxel_Player,
%Sprite_Phyxel.getLocalVector(%Sprite_Phyxel_Player.Position),
%Sprite_Phyxel_Player.getLocalVector(%Sprite_Phyxel.Position),
false);*/

/*Scene_Phyxel.createRopeJoint(%Sprite_Phyxel,%Sprite_Phyxel_Player,"0 0","0 0",
Vector2Distance(%Sprite_Phyxel.Position,%Sprite_Phyxel_Player.Position),
false);*/

%Sprite_Phyxel_Player.SimSet_Connected_Phyxels.add(%Sprite_Phyxel);

}

}

/*****************************************************************/

//Join the phyxels.

/*for (%y=0;%y<%SimSet_Y.getCount();%y++)
{

%SimSet_X=%SimSet_Y.getObject(%y);

for (%x=0;%x<%SimSet_X.getCount();%x++)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

for (%y_Next=0;%y_Next<%SimSet_Y.getCount();%y_Next++)
{

%SimSet_X_Next=%SimSet_Y.getObject(%y_Next);

for (%x_Next=0;%x_Next<%SimSet_X_Next.getCount();%x_Next++)
{

%ScriptObject_Phyxel_Next=%SimSet_X_Next.getObject(%x_Next);

if (%y_Next==%y&&%x_Next==%x){continue;}

if (isObject(%ScriptObject_Phyxel_Next.Sprite_Phyxel))
{

Scene_Phyxel.createDistanceJoint(%ScriptObject_Phyxel.Sprite_Phyxel,%ScriptObject_Phyxel_Next.Sprite_Phyxel,"0 0","0 0",
Vector2Distance(%ScriptObject_Phyxel.Sprite_Phyxel.Position,%ScriptObject_Phyxel_Next.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

}

}

}

}

}

}*/

//Left perimeter.

for (%y=0;%y<%SimSet_Y.getCount()-1;%y++)
{

%Bool_Break=false;

%SimSet_X=%SimSet_Y.getObject(%y);

for (%x=0;%x<%SimSet_X.getCount();%x++)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

for (%y_Next=%y+1;%y_Next<%SimSet_Y.getCount();%y_Next++)
{

%SimSet_X_Next_Y=%SimSet_Y.getObject(%y_Next);

for (%x_Next=0;%x_Next<%SimSet_X_Next_Y.getCount();%x_Next++)
{

%ScriptObject_Phyxel_Next=%SimSet_X_Next_Y.getObject(%x_Next);

if (isObject(%ScriptObject_Phyxel_Next.Sprite_Phyxel))
{

Scene_Phyxel.createDistanceJoint(%ScriptObject_Phyxel.Sprite_Phyxel,%ScriptObject_Phyxel_Next.Sprite_Phyxel,"0 0","0 0",
Vector2Distance(%ScriptObject_Phyxel.Sprite_Phyxel.Position,%ScriptObject_Phyxel_Next.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

%Bool_Break=true;

break;

}

}

if (%Bool_Break)
{

break;

}

}

if (%Bool_Break)
{

break;

}

}

}

}

/*****************************************************************/

//Right perimeter.

for (%y=0;%y<%SimSet_Y.getCount()-1;%y++)
{

%Bool_Break=false;

%SimSet_X=%SimSet_Y.getObject(%y);

for (%x=%SimSet_X.getCount()-1;%x>0;%x--)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

for (%y_Next=%y+1;%y_Next<%SimSet_Y.getCount();%y_Next++)
{

%SimSet_X_Next_Y=%SimSet_Y.getObject(%y_Next);

for (%x_Next=%SimSet_X_Next_Y.getCount()-1;%x_Next>0;%x_Next--)
{

%ScriptObject_Phyxel_Next=%SimSet_X_Next_Y.getObject(%x_Next);

if (isObject(%ScriptObject_Phyxel_Next.Sprite_Phyxel))
{

Scene_Phyxel.createDistanceJoint(%ScriptObject_Phyxel.Sprite_Phyxel,%ScriptObject_Phyxel_Next.Sprite_Phyxel,"0 0","0 0",
Vector2Distance(%ScriptObject_Phyxel.Sprite_Phyxel.Position,%ScriptObject_Phyxel_Next.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

%Bool_Break=true;

break;

}

}

if (%Bool_Break)
{

break;

}

}

if (%Bool_Break)
{

break;

}

}

}

}

/*****************************************************************/

//Horizontal connections.

for (%y=0;%y<%SimSet_Y.getCount();%y++)
{

%Bool_Break=false;

%SimSet_X=%SimSet_Y.getObject(%y);

for (%x=0;%x<%SimSet_X.getCount()-1;%x++)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

for (%x_Next=%x+1;%x_Next<%SimSet_X.getCount();%x_Next++)
{

%ScriptObject_Phyxel_Next=%SimSet_X.getObject(%x_Next);

if (isObject(%ScriptObject_Phyxel_Next.Sprite_Phyxel))
{

Scene_Phyxel.createDistanceJoint(%ScriptObject_Phyxel.Sprite_Phyxel,%ScriptObject_Phyxel_Next.Sprite_Phyxel,"0 0","0 0",
Vector2Distance(%ScriptObject_Phyxel.Sprite_Phyxel.Position,%ScriptObject_Phyxel_Next.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

break;

}

}

}

}

}

/*****************************************************************/

//Cross-brace connections.

%ScriptObject_Phyxel_Top_Left=0;

%SimSet_X=%SimSet_Y.getObject(0);

for (%x=0;%x<%SimSet_X.getCount();%x++)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

%ScriptObject_Phyxel_Top_Left=%ScriptObject_Phyxel;

}

}

%ScriptObject_Phyxel_Top_Right=0;

%SimSet_X=%SimSet_Y.getObject(0);

for (%x=%SimSet_X.getCount()-1;%x>=0;%x--)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

%ScriptObject_Phyxel_Top_Right=%ScriptObject_Phyxel;

}

}

%ScriptObject_Phyxel_Bottom_Left=0;

%SimSet_X=%SimSet_Y.getObject(%SimSet_Y.getCount()-1);

for (%x=0;%x<%SimSet_X.getCount();%x++)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

%ScriptObject_Phyxel_Bottom_Left=%ScriptObject_Phyxel;

}

}

%ScriptObject_Phyxel_Bottom_Right=0;

%SimSet_X=%SimSet_Y.getObject(%SimSet_Y.getCount()-1);

for (%x=%SimSet_X.getCount()-1;%x>=0;%x--)
{

%ScriptObject_Phyxel=%SimSet_X.getObject(%x);

if (isObject(%ScriptObject_Phyxel.Sprite_Phyxel))
{

%ScriptObject_Phyxel_Bottom_Right=%ScriptObject_Phyxel;

}

}

Scene_Phyxel.createDistanceJoint(%ScriptObject_Phyxel_Top_Left.Sprite_Phyxel,%ScriptObject_Phyxel_Bottom_Right.Sprite_Phyxel,"0 0","0 0",
Vector2Distance(%ScriptObject_Phyxel_Top_Left.Sprite_Phyxel.Position,%ScriptObject_Phyxel_Bottom_Right.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

Scene_Phyxel.createDistanceJoint(%ScriptObject_Phyxel_Top_Right.Sprite_Phyxel,%ScriptObject_Phyxel_Bottom_Left.Sprite_Phyxel,"0 0","0 0",
Vector2Distance(%ScriptObject_Phyxel_Top_Right.Sprite_Phyxel.Position,%ScriptObject_Phyxel_Bottom_Left.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);
/*
Scene_Phyxel.createWeldJoint(%ScriptObject_Phyxel_Top_Left.Sprite_Phyxel,%ScriptObject_Phyxel_Bottom_Right.Sprite_Phyxel,
%ScriptObject_Phyxel_Top_Left.Sprite_Phyxel.getLocalVector(%ScriptObject_Phyxel_Bottom_Right.Sprite_Phyxel.Position),
%ScriptObject_Phyxel_Bottom_Right.Sprite_Phyxel.getLocalVector(%ScriptObject_Phyxel_Top_Left.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);

Scene_Phyxel.createWeldJoint(%ScriptObject_Phyxel_Top_Right.Sprite_Phyxel,%ScriptObject_Phyxel_Bottom_Left.Sprite_Phyxel,
%ScriptObject_Phyxel_Top_Right.Sprite_Phyxel.getLocalVector(%ScriptObject_Phyxel_Bottom_Left.Sprite_Phyxel.Position),
%ScriptObject_Phyxel_Bottom_Left.Sprite_Phyxel.getLocalVector(%ScriptObject_Phyxel_Top_Right.Sprite_Phyxel.Position),
%this.Joint_Distance_Frequency,
%this.Joint_Distance_Damping_Ratio,
false);
*/
/*****************************************************************/

//Start constant movement.

%Sprite_Phyxel_Player.Schedule_Move=schedule(%this.Int_Player_Move_Schedule_Interval,0,"Class_Phyxel_Player::Schedule_Move",%Sprite_Phyxel_Player);

}
