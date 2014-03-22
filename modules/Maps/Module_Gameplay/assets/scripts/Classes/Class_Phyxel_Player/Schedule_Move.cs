function Class_Phyxel_Player::Schedule_Move(%this)
{

if (!isObject(%this)){return;}

%Float_Corrected_Angle=%this.Angle+90;

for (%x=0;%x<%this.SimSet_Connected_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Connected_Phyxels.getObject(%x);

%Sprite_Phyxel.setLinearVelocityPolar(%Float_Corrected_Angle,%this.Module_ID_Parent.Float_Player_Speed);

}

%this.Module_ID_Parent.Scroller_Star_Field.setScrollPolar(%Float_Corrected_Angle,%this.Module_ID_Parent.Float_Star_Field_Speed);

%this.setLinearVelocityPolar(%Float_Corrected_Angle,%this.Module_ID_Parent.Float_Player_Speed);

%this.Schedule_Move=schedule(%this.Module_ID_Parent.Int_Player_Move_Schedule_Interval,0,"Class_Phyxel_Player::Schedule_Move",%this);

}
