﻿using UnityEngine;
using UnityEditor;
using static UnityEditor.SpeedTreeImporter;

namespace AssetImportTool
{
	public class DefaultSpeedTreeImporter : IAssetImporterExtension
	{
		private MaterialLocation materialLocation;
		private float scaleFactor;
		private float alphaTestRef;
		private bool enableSmoothLODTransition;
		private bool animateCrossFading;
		private float billboardTransitionCrossFadeWidth;
		private float fadeOutWidth;
		private string userData;
		private string assetBundleName;
		private string assetBundleVariant;
		private string name;
		private HideFlags hideFlags;
		
		public System.Type GetTargetImporterType ()
		{
			return typeof(SpeedTreeImporter);
		}
		
		
		public void OnPostprocess (string assetPath, Property[] properties)
		{
		}
		
		
		public void OnRemoveprocess (string assetPath, Property[] properties)
		{
		}
		
		public void Apply (AssetImporter originalImporter, string assetPath, Property[] properties)
		{
			SpeedTreeImporter importer = (SpeedTreeImporter)originalImporter;
			
			for (int i = 0; i < properties.Length; i++){
				var property = properties [i];
				
				switch (property.name) {
					case "materialLocation":
						importer.materialLocation = (MaterialLocation)System.Enum.Parse(typeof(MaterialLocation), property.value, true);
						break;
						
					case "scaleFactor":
						importer.scaleFactor = float.Parse (property.value);
						break;
						
					case "alphaTestRef":
						importer.alphaTestRef = float.Parse (property.value);
						break;
						
					case "enableSmoothLODTransition":
						importer.enableSmoothLODTransition = bool.Parse (property.value);
						break;
						
					case "animateCrossFading":
						importer.animateCrossFading = bool.Parse (property.value);
						break;
						
					case "billboardTransitionCrossFadeWidth":
						importer.billboardTransitionCrossFadeWidth = float.Parse (property.value);
						break;
						
					case "fadeOutWidth":
						importer.fadeOutWidth = float.Parse (property.value);
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
