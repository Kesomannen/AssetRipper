﻿using AssetRipper.Core.Parser.Files;
using AssetRipper.Core.IO.Asset;
using System;
using Object = AssetRipper.Core.Classes.Object.Object;
using Version = AssetRipper.Core.Parser.Files.Version;

namespace AssetRipper.Core.Project
{
	public sealed class ExportOptions
	{
		public ExportOptions(Version version, Platform platform, TransferInstructionFlags flags)
		{
			Version = version;
			Platform = platform;
			Flags = flags;
		}

		private static bool DefaultFilter(Object asset)
		{
			return true;
		}

		public Version Version { get; }
		public Platform Platform { get; }
		public TransferInstructionFlags Flags { get; }

		/// <summary>
		/// Should objects get exported with dependencies or without
		/// </summary>
		public bool ExportDependencies { get; set; }
		/// <summary>
		/// Export asset bundle content to its original path instead of AssetBundle directory
		/// </summary>
		public bool KeepAssetBundleContentPath { get; set; }
		public Func<Object, bool> Filter { get; set; } = DefaultFilter;
	}
}
