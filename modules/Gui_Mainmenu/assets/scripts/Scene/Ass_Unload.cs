function Module_Gui_Main_Menu::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_BG_Render.getAssetId());

}
