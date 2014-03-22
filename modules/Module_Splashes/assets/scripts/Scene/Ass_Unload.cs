function Splashes::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Dove_Head.getAssetId());
AssetDatabase.releaseAsset(%this.Ass_Dove_Body.getAssetId());
AssetDatabase.releaseAsset(%this.Ass_Dove_Leftleg.getAssetId());
AssetDatabase.releaseAsset(%this.Ass_Dove_Leftwing.getAssetId());
AssetDatabase.releaseAsset(%this.Ass_Dove_Rightleg.getAssetId());
AssetDatabase.releaseAsset(%this.Ass_Dove_Rightwing.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Tree.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Name.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Logo_Torque.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Splash_OGA.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Audio_MourningDoveSoft.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Audio_Torque_Wrench.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Audio_Splash_OGA.getAssetId());

}
