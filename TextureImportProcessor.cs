using UnityEditor;
using UnityEngine;

public class TextureImportProcessor : AssetPostprocessor {
    // インポート設定のデフォルト値をインポート前に変更可能
    public void OnPreprocessTexture(){
        // assetImporterがインポート設定を持っている
        var importer = assetImporter as TextureImporter;

        // GenerateMipMapsをオフにする
        importer.mipmapEnabled = false;
    }
}
