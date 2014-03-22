function Class_Projectile::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.SceneGroup==30)
{

%this.safeDelete();

}
else if (%Colliding_Object.SceneGroup==25&&!%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1)))
{

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.Gui_Text_Score.setText("Score" SPC %this.Module_ID_Parent.Int_Score);

%Colliding_Object.safeDelete();

%this.safeDelete();

}

}
