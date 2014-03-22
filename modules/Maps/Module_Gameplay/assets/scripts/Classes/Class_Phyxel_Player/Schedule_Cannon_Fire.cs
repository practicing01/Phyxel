function Class_Phyxel_Player::Schedule_Cannon_Fire(%this)
{

if (!isObject(%this)){return;}

if (!isObject(%this.Sprite_Cannon_Target))
{

%this.Sprite_Cannon_Target=0;

%String_List_Picked_Objects=Scene_Phyxel.pickCircle(%this.Position,
%this.getCircleCollisionShapeRadius(%this.Collision_Shape_Index_Cannon),
bit(0)|bit(25),"","collision");

%Float_Closest_Distance=10000;

%Object_Closest=0;

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object.class!$="Class_Phyxel_Enemy"){continue;}

%Float_Distance=Vector2Distance(%this.Position,%Object.Position);

if (%Float_Distance<%Float_Closest_Distance)
{

%Float_Closest_Distance=%Float_Distance;

%Object_Closest=%Object;

}

}

if (%Object_Closest!=0)
{

%this.Sprite_Cannon_Target=%Object_Closest;

}
else
{

return;

}

}

%Sprite_Projectile=new Sprite()
{

Position=%this.Position;
Size=%this.Module_ID_Parent.Vector_2D_Phyxel_Size;
Image="Module_Gameplay:Image_Projectile";
class="Class_Projectile";
CollisionCallback="true";
SceneLayer=15;

BlendColor="0.0 0.5 1.0 1.0";

DefaultDensity=0;

DefaultRestitution=0;

SceneGroup=24;

Module_ID_Parent=%this.Module_ID_Parent;

Collision_Shape_Index=-1;

Sprite_Cannon_Parent=%this;

};

%Sprite_Projectile.setCollisionGroups(0,25,30);

%Sprite_Projectile.Collision_Shape_Index=%Sprite_Projectile.createPolygonBoxCollisionShape(%Sprite_Projectile.Size);

%Sprite_Projectile.setCollisionShapeIsSensor(%Sprite_Projectile.Collision_Shape_Index,true);

Scene_Phyxel.add(%Sprite_Projectile);

%Float_Angle_To_Target=Vector2AngleToPoint(%Sprite_Projectile.Position,%this.Sprite_Cannon_Target.Position);

%Sprite_Projectile.Angle=%Float_Angle_To_Target-90;

%Sprite_Projectile.setLinearVelocityPolar(%Float_Angle_To_Target,
%this.Module_ID_Parent.Float_Player_Cannon_Fire_Speed);

%this.Schedule_Cannon_Fire=schedule(%this.Module_ID_Parent.Int_Player_Cannon_Fire_Schedule_Interval,0,"Class_Phyxel_Player::Schedule_Cannon_Fire",%this);

}
