function Module_Gameplay::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Panel.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Cannon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Panel_Enemy.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Cannon_Enemy.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Projectile.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Star_Field.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Goal.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Wall.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Radar.getAssetId());

}
