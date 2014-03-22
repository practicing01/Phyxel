function Window_Create_Phyxel()
{

if (!isObject(Window_Phyxel))
{

new SceneWindow(Window_Phyxel);   

Window_Phyxel.Profile=Gui_Profile_Window_Phyxel;

Canvas.setContent(Window_Phyxel);                     

}

Window_Phyxel.stopCameraMove();
Window_Phyxel.dismount();
Window_Phyxel.setViewLimitOff();
Window_Phyxel.setRenderGroups(Phyxel.All_Bits);
Window_Phyxel.setRenderLayers(Phyxel.All_Bits);
Window_Phyxel.setObjectInputEventGroupFilter(Phyxel.All_Bits);
Window_Phyxel.setObjectInputEventLayerFilter(Phyxel.All_Bits);
Window_Phyxel.setLockMouse(true);
Window_Phyxel.setCameraPosition(0,0);
Window_Phyxel.setCameraZoom(1);
Window_Phyxel.setCameraAngle(0);

Phyxel.Resolution=getRes();
%Y_Times_100=100*Phyxel.Resolution.Y;
%Cam_Y=%Y_Times_100/Phyxel.Resolution.X;

Window_Phyxel.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Phyxel_Overlay))
{

new GuiControl(Gui_Phyxel_Overlay)
{

Position="0 0";
Extent=Phyxel.Resolution;
Profile=gui_profile_modalless;

};   

Window_Phyxel.addGuiControl(Gui_Phyxel_Overlay);

Gui_Phyxel_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Phyxel()
{
    
if (isObject(Window_Phyxel))
{

Window_Phyxel.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Phyxel()
{

if (isObject(Scene_Phyxel))
{

Scene_Phyxel.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Phyxel))
{

error("Cannot set Phyxel Scene to Window as the Scene is invalid.");
return;

}
    
Window_Phyxel.setScene(Scene_Phyxel);

Window_Phyxel.stopCameraMove();
Window_Phyxel.dismount();
Window_Phyxel.setViewLimitOff();
Window_Phyxel.setRenderGroups(Phyxel.All_Bits);
Window_Phyxel.setRenderLayers(Phyxel.All_Bits);
Window_Phyxel.setObjectInputEventGroupFilter(Phyxel.All_Bits);
Window_Phyxel.setObjectInputEventLayerFilter(Phyxel.All_Bits);
Window_Phyxel.setLockMouse(true);
Window_Phyxel.setCameraPosition(0,0);
Window_Phyxel.setCameraZoom(1);
Window_Phyxel.setCameraAngle(0);

Phyxel.Resolution=getRes();
%Y_Times_100=100*Phyxel.Resolution.Y;
%Cam_Y=%Y_Times_100/Phyxel.Resolution.X;

Window_Phyxel.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Phyxel()
{

Scene_Destroy_Phyxel();

new Scene(Scene_Phyxel);

if (!isObject(Window_Phyxel))
{

error("Phyxel: Created scene but no window available.");
return;

}

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Phyxel to use an invalid Scene.");
return;

}
   
Scene_Destroy_Phyxel();

%Scene.setName("Scene_Phyxel");

//%Scene.class="Class_Scene_Phyxel";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Phyxel::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/
