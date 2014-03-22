function Class_Phyxel_Enemy::Schedule_Move(%this)
{

if (!isObject(%this)){return;}

if (!isObject(%this.Sprite_Move_Target))
{

%this.Schedule_Move=0;

%this.setLinearVelocity("0 0");

for (%x=0;%x<%this.SimSet_Connected_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Connected_Phyxels.getObject(%x);

%Sprite_Phyxel.setLinearVelocity("0 0");

}

return;

}

%Float_New_Angle=Vector2AngleToPoint(%this.Position,%this.Sprite_Move_Target.Position);

for (%x=0;%x<%this.SimSet_Connected_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Connected_Phyxels.getObject(%x);

%Float_Phyxel_Angle=%Float_New_Angle+%Sprite_Phyxel.Vector_2D_Original_Offset.X;

%Vector_2D_New_Position=Vector2Direction(%Float_Phyxel_Angle,%Sprite_Phyxel.Vector_2D_Original_Offset.Y);

%Vector_2D_New_Position=Vector2Add(%this.Position,%Vector_2D_New_Position);

%Sprite_Phyxel.Angle=%Float_New_Angle;

%Sprite_Phyxel.Position=%Vector_2D_New_Position;

%Sprite_Phyxel.setLinearVelocityPolar(%Float_New_Angle,%this.Module_ID_Parent.Float_Player_Speed*0.9);

}

%this.Angle=%Float_New_Angle;

%this.setLinearVelocityPolar(%Float_New_Angle,%this.Module_ID_Parent.Float_Player_Speed);

%this.Schedule_Move=schedule(%this.Module_ID_Parent.Int_Player_Move_Schedule_Interval*4,0,"Class_Phyxel_Enemy::Schedule_Move",%this);

}
