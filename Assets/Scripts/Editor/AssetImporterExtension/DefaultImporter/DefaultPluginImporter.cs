﻿using UnityEngine;
using UnityEditor;

namespace AssetImportTool
{
	public class DefaultPluginImporter : IAssetImporterExtension
	{
		private bool isPreloaded;
		private string userData;
		private string assetBundleName;
		private string assetBundleVariant;
		private string name;
		private HideFlags hideFlags;
		
		public System.Type GetTargetImporterType ()
		{
			return typeof(PluginImporter);
		}
		
		
		public void OnPostprocess (string assetPath, Property[] properties)
		{
		}
		
		
		public void OnRemoveprocess (string assetPath, Property[] properties)
		{
		}
		
		public void Apply (AssetImporter originalImporter, string assetPath, Property[] properties)
		{
			PluginImporter importer = (PluginImporter)originalImporter;
			
			for (int i = 0; i < properties.Length; i++){
				var property = properties [i];
				
				switch (property.name) {
					case "isPreloaded":
						importer.isPreloaded = bool.Parse (property.value);
						break;
						
					case "userData":
						importer.userData = property.value;
						break;
						
					case "assetBundleName":
						importer.assetBundleName = property.value;
						break;
						
					case "assetBundleVariant":
						importer.assetBundleVariant = property.value;
						break;
						
					case "name":
						importer.name = property.value;
						break;
						
					case "hideFlags":
						importer.hideFlags = (HideFlags)System.Enum.Parse(typeof(HideFlags), property.value, true);
						break;
						
				}
			}
		}
	}
}
