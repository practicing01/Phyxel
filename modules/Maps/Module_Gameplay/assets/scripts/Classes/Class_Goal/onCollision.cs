function Class_Goal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Phyxel_Player"&&!%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1)))
{

schedule(0,0,"Gui_Gameplay::Go_Main_Menu",Gui_Gameplay);

}

}
