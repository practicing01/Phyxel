function Class_Phyxel_Enemy::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%this.getCollisionShapeIsSensor(getWord(%Collision_Details,0)))//Cannon phyxel.
{

if (%this.Sprite_Cannon_Target==0&&%Colliding_Object.class$="Class_Phyxel_Player")
{

%this.Sprite_Cannon_Target=%Colliding_Object;

%this.Schedule_Cannon_Fire=schedule(%this.Module_ID_Parent.Int_Player_Cannon_Fire_Schedule_Interval,0,"Class_Phyxel_Enemy::Schedule_Cannon_Fire",%this);

/*if (%this.Sprite_Phyxel_Player.Sprite_Move_Target==0)
{

%this.Sprite_Phyxel_Player.Sprite_Move_Target=%Colliding_Object;

%this.Sprite_Phyxel_Player.Schedule_Move=schedule(%this.Module_ID_Parent.Int_Player_Move_Schedule_Interval,0,"Class_Phyxel_Enemy::Schedule_Move",%this.Sprite_Phyxel_Player);

}*/

}

}

}
