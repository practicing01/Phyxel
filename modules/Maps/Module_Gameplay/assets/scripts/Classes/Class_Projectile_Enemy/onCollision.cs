function Class_Projectile_Enemy::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.SceneGroup==30)
{

%this.safeDelete();

}
else if (%Colliding_Object.SceneGroup==26&&!%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1)))
{

%Colliding_Object.safeDelete();

%this.safeDelete();

}

}
