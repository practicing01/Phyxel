function Class_Phyxel_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Phyxel.setCameraZoom(Window_Phyxel.getCameraZoom()+$pref::Phyxel::cameraMouseZoomRate);

}

function Class_Phyxel_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Phyxel.setCameraZoom(Window_Phyxel.getCameraZoom()-$pref::Phyxel::cameraMouseZoomRate);

}
