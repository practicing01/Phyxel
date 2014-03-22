function Class_Radar::Rotate(%this)
{

if (!isObject(%this)){return;}

//The proceeding code won't work cus the camera is rotating.  Need to reimplement.

%Float_Distance_X=mAbs(%this.Module_ID_Parent.Sprite_Goal.Position.X-
%this.Module_ID_Parent.Sprite_Phyxel_Player.Position.X);
%Float_Distance_Y=mAbs(%this.Module_ID_Parent.Sprite_Goal.Position.Y-
%this.Module_ID_Parent.Sprite_Phyxel_Player.Position.Y);

if (%Float_Distance_X>%Float_Distance_Y)
{

if (%this.Module_ID_Parent.Sprite_Goal.Position.X<%this.Module_ID_Parent.Sprite_Phyxel_Player.Position.X)
{

%this.Frame=1;

}
else
{

%this.Frame=0;

}

}
else
{

if (%this.Module_ID_Parent.Sprite_Goal.Position.Y<%this.Module_ID_Parent.Sprite_Phyxel_Player.Position.Y)
{

%this.Frame=2;

}
else
{

%this.Frame=3;

}

}

%this.Schedule_Rotate=schedule(%this.Module_ID_Parent.Int_Radar_Rotate_Schedule_Interval,0,"Class_Radar::Rotate",%this);

}
