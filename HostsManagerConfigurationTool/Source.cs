using System.Collections.Generic;

namespace HostsManagerConfigurationTool
{
	public class Source : Config.HasEnabled
	{
		public string name;
		public string internalName;
		public string address;
		public string description;
		public string html;
		public List<Config.Sequence> current;
		public override string ToString()
		{
			return name;
		}
		public int version;
		public Source()
		{
			enabled = true;
		}
	}
}
