function Class_Phyxel_Enemy::onRemove(%this)
{

if (%this==%this.Sprite_Phyxel_Player&&%this.Module_ID_Parent.Bool_Is_Playing)
{

for (%x=0;%x<%this.SimSet_Connected_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Connected_Phyxels.getObject(%x);

%Sprite_Phyxel.setLifetime(%this.Module_ID_Parent.Float_Enemy_Lifetime);

}

%this.SimSet_Connected_Phyxels.delete();

schedule(1000,0,"Module_Gameplay::Enemies_Initialize",%this.Module_ID_Parent);

}

}
