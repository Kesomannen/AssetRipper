using AssetRipper.Core.Project;
using AssetRipper.Core.Parser.Asset;
using AssetRipper.Core.Classes.Misc;
using AssetRipper.Core.IO.Asset;
using AssetRipper.Core.YAML;
using System.Collections.Generic;
using Object = AssetRipper.Core.Classes.Object.Object;

namespace AssetRipper.Core.Structure.Assembly.Serializable
{
	public sealed class SerializablePointer : IAsset, IDependent
	{
		public void Read(AssetReader reader)
		{
			Pointer.Read(reader);
		}

		public void Write(AssetWriter writer)
		{
			Pointer.Write(writer);
		}

		public IEnumerable<PPtr<Object>> FetchDependencies(DependencyContext context)
		{
			yield return context.FetchDependency(Pointer, string.Empty);
		}

		public YAMLNode ExportYAML(IExportContainer container)
		{
			return Pointer.ExportYAML(container);
		}

		public PPtr<Object> Pointer;
	}
}
