using System;
using System.Collections.Generic;

namespace HostsManagerConfigurationTool
{
	public class Config
	{
		public class HasEnabled
		{
			public bool enabled;
		}
		public class Entry : HasEnabled
		{
			public string ip;
			public string domain;
			public Entry()
			{
				enabled = true;
			}
		}

		public class Sequence : HasEnabled
		{
			public string name;
			public List<Entry> entries;
			public Sequence()
			{
				enabled = true;
			}
		}

		public DateTime lastChecked;
		public DateTime lastChanged;
		public List<string> updateSource;
		public List<Sequence> currentCustoms;
		public long updateTimeDay;
	}
}
