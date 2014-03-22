//Hard-coded ragdoll construction, very bad :<
function Splashes::Dove_Construct(%this)
{

alxPlay("Splashes:audio_mourningdove");

%Dove_Body=0;
%Dove_Head=0;
%Dove_Leftwing=0;
%Dove_Leftleg=0;
%Dove_Rightwing=0;
%Dove_Rightleg=0;

for (%x=0;%x<Scene_Phyxel.getCount();%x++)
{

%Object=Scene_Phyxel.getObject(%x);

if (%Object.class$="Class_Dove_Bodypart")
{

%Object.Handle_Module_Parent=%this;

if (%Object.BodyPart$="Head")
{

%Dove_Head=%Object;

}
else if (%Object.BodyPart$="Body")
{

%Dove_Body=%Object;

}
else if (%Object.BodyPart$="Leftwing")
{

%Dove_Leftwing=%Object;

}
else if (%Object.BodyPart$="Leftleg")
{

%Dove_Leftleg=%Object;

}
else if (%Object.BodyPart$="Rightwing")
{

%Dove_Rightwing=%Object;

}
else if (%Object.BodyPart$="Rightleg")
{

%Dove_Rightleg=%Object;

}


}

}

Scene_Phyxel.createDistanceJoint(%Dove_Head,%Dove_Body,
%Dove_Head.getLocalPoint(%Dove_Body.Position),"0 0",0.1,3,0.0,true);

Scene_Phyxel.createDistanceJoint(%Dove_Leftwing,%Dove_Body,
%Dove_Leftwing.getLocalPoint(%Dove_Body.Position),"0 0",0.1,3,0.0,true);

Scene_Phyxel.createDistanceJoint(%Dove_Leftleg,%Dove_Body,
%Dove_Leftleg.getLocalPoint(%Dove_Body.Position),"0 0",0.1,3,0.0,true);

Scene_Phyxel.createDistanceJoint(%Dove_Rightwing,%Dove_Body,
%Dove_Rightwing.getLocalPoint(%Dove_Body.Position),"0 0",0.1,3,0.0,true);

Scene_Phyxel.createDistanceJoint(%Dove_Rightleg,%Dove_Body,
%Dove_Rightleg.getLocalPoint(%Dove_Body.Position),"0 0",0.1,3,0.0,true);

%Dove_Body.createPolygonBoxCollisionShape(%Dove_Body.Size);
%Dove_Head.createPolygonBoxCollisionShape(%Dove_Head.Size);
%Dove_Leftwing.createPolygonBoxCollisionShape(%Dove_Leftwing.Size);
%Dove_Leftleg.createPolygonBoxCollisionShape(%Dove_Leftleg.Size);
%Dove_Rightwing.createPolygonBoxCollisionShape(%Dove_Rightwing.Size);
%Dove_Rightleg.createPolygonBoxCollisionShape(%Dove_Rightleg.Size);

%Dove_Body.setBodyType("dynamic");
%Dove_Head.setBodyType("dynamic");
%Dove_Leftwing.setBodyType("dynamic");
%Dove_Leftleg.setBodyType("dynamic");
%Dove_Rightwing.setBodyType("dynamic");
%Dove_Rightleg.setBodyType("dynamic");

}
