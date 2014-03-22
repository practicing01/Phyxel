function Module_Gameplay::Movement_Initialize(%this)
{

%this.Sprite_Phyxel_Player.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Phyxel_Player_Input_Controller";

Phyxel_Parent=%this.Sprite_Phyxel_Player;

Vector_2D_World_Position_Previous="0 0";

};

Window_Phyxel.addInputListener(%this.Sprite_Phyxel_Player.Script_Object_Input_Controller);

}

function Class_Phyxel_Player_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

//%this.Vector_2D_World_Position_Previous=%Vector_2D_World_Position;

}

function Class_Phyxel_Player_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{

//%this.Vector_2D_World_Position_Previous=%Vector_2D_World_Position;

}

function Class_Phyxel_Player_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

if (!isObject(%this.Phyxel_Parent)){return;}

if (%Vector_2D_World_Position.X<%this.Vector_2D_World_Position_Previous.X)//Left swipe.
{

if (%this.Char_Previous_Swipe_Direction==1&&mAbs(%Vector_2D_World_Position.X-%this.Vector_2D_World_Position_Previous.X)<%this.Phyxel_Parent.Module_ID_Parent.Int_Player_Swipe_Dampener)
{

return;

}

%this.Char_Previous_Swipe_Direction=0;

%Float_New_Angle=%this.Phyxel_Parent.Angle+%this.Phyxel_Parent.Module_ID_Parent.Int_Player_Rotate_Speed;

for (%x=0;%x<%this.Phyxel_Parent.SimSet_Connected_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.Phyxel_Parent.SimSet_Connected_Phyxels.getObject(%x);

%Float_Phyxel_Angle=%Float_New_Angle+%Sprite_Phyxel.Vector_2D_Original_Offset.X;

%Vector_2D_New_Position=Vector2Direction(%Float_Phyxel_Angle,%Sprite_Phyxel.Vector_2D_Original_Offset.Y);

%Vector_2D_New_Position=Vector2Add(%this.Phyxel_Parent.Position,%Vector_2D_New_Position);

%Sprite_Phyxel.Angle=%Float_New_Angle;

%Sprite_Phyxel.Position=%Vector_2D_New_Position;

}

%this.Phyxel_Parent.Angle=%Float_New_Angle;

%this.Vector_2D_World_Position_Previous=%Vector_2D_World_Position;

}
else if (%Vector_2D_World_Position.X>%this.Vector_2D_World_Position_Previous.X)//Right swipe.
{

if (%this.Char_Previous_Swipe_Direction==0&&mAbs(%Vector_2D_World_Position.X-%this.Vector_2D_World_Position_Previous.X)<%this.Phyxel_Parent.Module_ID_Parent.Int_Player_Swipe_Dampener)
{

return;

}

%this.Char_Previous_Swipe_Direction=1;

%Float_New_Angle=%this.Phyxel_Parent.Angle-%this.Phyxel_Parent.Module_ID_Parent.Int_Player_Rotate_Speed;

for (%x=0;%x<%this.Phyxel_Parent.SimSet_Connected_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.Phyxel_Parent.SimSet_Connected_Phyxels.getObject(%x);

%Float_Phyxel_Angle=%Float_New_Angle+%Sprite_Phyxel.Vector_2D_Original_Offset.X;

%Vector_2D_New_Position=Vector2Direction(%Float_Phyxel_Angle,%Sprite_Phyxel.Vector_2D_Original_Offset.Y);

%Vector_2D_New_Position=Vector2Add(%this.Phyxel_Parent.Position,%Vector_2D_New_Position);

%Sprite_Phyxel.Angle=%Float_New_Angle;

%Sprite_Phyxel.Position=%Vector_2D_New_Position;

}

%this.Phyxel_Parent.Angle=%Float_New_Angle;

%this.Vector_2D_World_Position_Previous=%Vector_2D_World_Position;

}

}
