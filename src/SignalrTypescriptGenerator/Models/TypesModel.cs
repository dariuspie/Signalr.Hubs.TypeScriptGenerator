using System;
using System.Collections.Generic;

namespace SignalrTypescriptGenerator.Models
{
	public class TypesModel
	{
		public List<TypeInfo> Hubs { get; set; }
		public List<ServiceInfo> ServiceContracts { get; set; }
		public List<ClientInfo> Clients { get; set; }
		public List<DataContractInfo> DataContracts { get; set; }
		public List<EnumInfo> Enums { get; set; }

		public string LastGenerated
		{
			get
			{
				return $"// Autogenerated by SignalrTypescriptGenerator.exe at {DateTime.Now}";
			}
		}

		public TypesModel()
		{
			Hubs = new List<TypeInfo>();
			ServiceContracts = new List<ServiceInfo>();
		}
	}
}