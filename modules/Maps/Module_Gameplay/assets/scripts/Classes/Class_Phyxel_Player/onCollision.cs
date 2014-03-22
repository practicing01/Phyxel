function Class_Phyxel_Player::onCollision(%this,%Colliding_Object,%Collision_Details)
{

/*if (%Colliding_Object.class$="Class_Wall"&&%this==%this.Sprite_Phyxel_Player)
{

%Float_Corrected_Angle=%this.Angle+180;

if (%Float_Corrected_Angle>180)
{

%Float_Corrected_Angle=-179+(%Float_Corrected_Angle-180);

}

for (%x=0;%x<%this.SimSet_Connected_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Connected_Phyxels.getObject(%x);

%Float_Phyxel_Angle=%Float_Corrected_Angle+%Sprite_Phyxel.Vector_2D_Original_Offset.X;

%Vector_2D_New_Position=Vector2Direction(%Float_Phyxel_Angle,%Sprite_Phyxel.Vector_2D_Original_Offset.Y);

%Vector_2D_New_Position=Vector2Add(%this.Position,%Vector_2D_New_Position);

%Sprite_Phyxel.Angle=%Float_Corrected_Angle;

%Sprite_Phyxel.Position=%Vector_2D_New_Position;

}

%this.Angle=%Float_Corrected_Angle;

}
else */if (%this.getCollisionShapeIsSensor(getWord(%Collision_Details,0)))//Cannon phyxel.
{

if (%this.Sprite_Cannon_Target==0&&%Colliding_Object.class$="Class_Phyxel_Enemy")
{

%this.Sprite_Cannon_Target=%Colliding_Object;

%this.Schedule_Cannon_Fire=schedule(%this.Module_ID_Parent.Int_Player_Cannon_Fire_Schedule_Interval,0,"Class_Phyxel_Player::Schedule_Cannon_Fire",%this);

}

}

}
