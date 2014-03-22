function Vector_2D_Ass_Size_To_Camera_Scale(%Ass)
{

%Size="0 0";

if (%Ass.getCellWidth()==0)
{

%Size=%Ass.getImageSize();

}
else
{

%Size.X=%Ass.getCellWidth();

%Size.Y=%Ass.getCellHeight();

}

if (%Ass.Optimal_Resolution)
{

%Size.X=(%Size.X*Phyxel.Resolution.X)/%Ass.Optimal_Resolution.X;

%Size.Y=(%Size.Y*Phyxel.Resolution.Y)/%Ass.Optimal_Resolution.Y;

}
else
{

echo("Warning: Optimal_Resolution Asset Field Not Found.");

}

%Size.X=(%Size.X*Phyxel.Camera_Size.X)/Phyxel.Resolution.X;

%Size.Y=(%Size.Y*Phyxel.Camera_Size.Y)/Phyxel.Resolution.Y;

return %Size;

}

function Vector_2D_Position_To_Camera_Scale(%Vector_2D)//assumes that x=0=left, y=0=top and +y=down, -y=up
{

%Vector_2D_Scaled=%Vector_2D;

%Vector_2D_Scaled.X-=Phyxel.Resolution.X/2;//offset cus cam is from -50 to 50

%Vector_2D_Scaled.Y-=Phyxel.Resolution.Y/2;//offset cus cam is from -30 to 30

%Vector_2D_Scaled.Y=-%Vector_2D_Scaled.Y;//flip cus -y is down and +y is up

%Vector_2D_Scaled.X=(%Vector_2D_Scaled.X*Phyxel.Camera_Size.X)/Phyxel.Resolution.X;

%Vector_2D_Scaled.Y=(%Vector_2D_Scaled.Y*Phyxel.Camera_Size.Y)/Phyxel.Resolution.Y;

return %Vector_2D_Scaled;

}

function Vector_2D_Position_To_Camera_By_Resolution_Scale(%Vector_2D,%Vector_2D_Resolution)//assumes that x=0=left, y=0=top and +y=down, -y=up
{

%Vector_2D_Scaled=%Vector_2D;

%Vector_2D_Scaled.X-=%Vector_2D_Resolution.X/2;//offset cus cam is from -50 to 50

%Vector_2D_Scaled.Y-=%Vector_2D_Resolution.Y/2;//offset cus cam is from -30 to 30

%Vector_2D_Scaled.Y=-%Vector_2D_Scaled.Y;//flip cus -y is down and +y is up

%Vector_2D_Scaled.X=(%Vector_2D_Scaled.X*Phyxel.Resolution.X)/%Vector_2D_Resolution.X;

%Vector_2D_Scaled.Y=(%Vector_2D_Scaled.Y*Phyxel.Resolution.Y)/%Vector_2D_Resolution.Y;

%Vector_2D_Scaled.X=(%Vector_2D_Scaled.X*Phyxel.Camera_Size.X)/Phyxel.Resolution.X;

%Vector_2D_Scaled.Y=(%Vector_2D_Scaled.Y*Phyxel.Camera_Size.Y)/Phyxel.Resolution.Y;

return %Vector_2D_Scaled;

}

function Vector_2D_Scale_Vector_To_Camera(%Vector_2D)
{

%Vector_2D.X=(%Vector_2D.X*Phyxel.Camera_Size.X)/Phyxel.Resolution.X;

%Vector_2D.Y=(%Vector_2D.Y*Phyxel.Camera_Size.Y)/Phyxel.Resolution.Y;

return %Vector_2D;

}

function Vector_2D_Vector_To_Camera_By_Resolution_Scale(%Vector_2D,%Vector_2D_Resolution)
{

%Vector_2D.X=(%Vector_2D.X*Phyxel.Resolution.X)/%Vector_2D_Resolution.X;

%Vector_2D.Y=(%Vector_2D.Y*Phyxel.Resolution.Y)/%Vector_2D_Resolution.Y;

%Vector_2D.X=(%Vector_2D.X*Phyxel.Camera_Size.X)/Phyxel.Resolution.X;

%Vector_2D.Y=(%Vector_2D.Y*Phyxel.Camera_Size.Y)/Phyxel.Resolution.Y;

return %Vector_2D;

}

function Vector_2D_Camera_To_Resolution_Scale(%Vector_2D)
{

%Vector_2D.X=(%Vector_2D.X*Phyxel.Resolution.X)/Phyxel.Camera_Size.X;

%Vector_2D.Y=(%Vector_2D.Y*Phyxel.Resolution.Y)/Phyxel.Camera_Size.Y;

return %Vector_2D;

}

function Vector_2D_Vector_To_Resolution_By_Resolution_Scale(%Vector_2D,%Vector_2D_Source_Resolution,%Vector_2D_Destination_Resolution)
{

%Scaled_Vector_2D="0 0";

%Scaled_Vector_2D.X=(%Vector_2D.X*%Vector_2D_Destination_Resolution.X)/%Vector_2D_Source_Resolution.X;

%Scaled_Vector_2D.Y=(%Vector_2D.Y*%Vector_2D_Destination_Resolution.Y)/%Vector_2D_Source_Resolution.Y;

%Scaled_Vector_2D.X=mRound(%Scaled_Vector_2D.X);

%Scaled_Vector_2D.Y=mRound(%Scaled_Vector_2D.Y);

return %Scaled_Vector_2D;

}

