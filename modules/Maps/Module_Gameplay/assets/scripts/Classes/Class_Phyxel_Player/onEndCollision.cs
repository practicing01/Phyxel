function Class_Phyxel_Player::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%this.getCollisionShapeIsSensor(getWord(%Collision_Details,0)))//Cannon phyxel.
{

if (%this.Sprite_Cannon_Target==%Colliding_Object)
{

%this.Sprite_Cannon_Target=0;

%String_List_Picked_Objects=Scene_Phyxel.pickCircle(%this.Position,
%this.getCircleCollisionShapeRadius(getWord(%Collision_Details,0)),
bit(0)|bit(25),"","collision");

%Float_Closest_Distance=10000;

%Object_Closest=0;

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object.class!$="Class_Phyxel_Enemy"){continue;}

%Float_Distance=Vector2Distance(%this.Position,%Object.Position);

if (%Float_Distance<%Float_Closest_Distance)
{

%Float_Closest_Distance=%Float_Distance;

%Object_Closest=%Object;

}

}

if (%Object_Closest!=0)
{

%this.Sprite_Cannon_Target=%Object_Closest;

}

}

}

}
