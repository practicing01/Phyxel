function Module_Gui_Editor::Scene_Unload(%this)
{

Canvas.popDialog(Gui_Editor);

%this.Ass_Unload();

}
