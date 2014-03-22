function Class_Phyxel_Player::onRemove(%this)
{

if (%this==%this.Sprite_Phyxel_Player)
{

Window_Phyxel.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

%this.SimSet_Connected_Phyxels.delete();

}

}
