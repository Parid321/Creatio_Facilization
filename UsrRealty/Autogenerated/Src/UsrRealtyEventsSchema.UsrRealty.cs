namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3bedcef6-5ae2-482d-b6fe-3bfb507903bc");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f9783a75-c706-47ee-ba26-1e18a00560a7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,111,219,48,12,189,7,200,127,32,140,29,108,32,16,218,107,179,22,104,130,116,24,144,117,67,147,238,50,244,160,200,76,170,66,31,134,36,187,203,134,254,247,82,150,211,36,78,14,229,197,54,249,248,248,30,65,215,94,154,13,44,209,57,238,237,58,176,169,213,218,154,241,112,48,28,24,174,209,87,92,224,81,217,172,229,166,118,60,72,107,134,131,255,195,1,80,212,45,201,98,235,3,234,241,97,234,12,239,249,162,67,54,51,65,6,137,254,51,24,54,107,208,132,29,244,79,155,222,182,185,185,36,17,6,93,190,16,207,168,249,61,121,128,107,200,30,189,123,64,174,194,54,43,158,82,83,85,175,148,20,32,20,247,30,82,237,12,13,92,193,132,123,60,83,73,44,221,2,14,8,109,67,146,101,137,208,88,89,194,79,179,224,13,25,201,237,234,5,69,0,143,166,68,55,130,68,56,193,53,185,106,105,111,221,198,3,22,123,186,3,230,24,43,82,193,62,216,118,52,88,140,143,97,137,183,243,67,198,243,148,40,82,67,15,92,162,144,154,43,168,156,20,113,75,169,139,125,195,176,220,86,88,78,173,170,181,249,205,85,141,95,59,232,77,30,55,249,43,226,179,254,104,185,134,60,49,221,192,229,197,46,138,99,80,207,85,12,100,223,253,148,27,129,10,75,18,17,92,141,227,83,148,15,46,222,3,93,164,231,27,92,162,174,8,107,240,21,230,86,112,37,255,241,149,194,69,139,201,59,27,143,30,29,157,171,161,181,211,173,178,7,244,182,118,130,64,214,17,195,232,116,68,140,253,161,164,11,203,70,144,181,118,103,127,5,98,233,231,82,203,240,35,137,96,77,92,77,86,176,165,237,38,247,87,114,42,156,68,167,4,187,179,78,243,144,31,24,162,81,151,236,98,242,229,100,179,49,194,179,179,175,173,225,168,164,138,150,118,189,125,248,219,254,179,123,165,199,91,252,163,223,1,152,83,39,182,237,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatePriceExceedsLimitMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreatePriceExceedsLimitMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0a0e8eba-f29b-b5f5-441a-29986d95a90b"),
				Name = "PriceExceedsLimitMessage",
				CreatedInPackageId = new Guid("f9783a75-c706-47ee-ba26-1e18a00560a7"),
				CreatedInSchemaUId = new Guid("3bedcef6-5ae2-482d-b6fe-3bfb507903bc"),
				ModifiedInSchemaUId = new Guid("3bedcef6-5ae2-482d-b6fe-3bfb507903bc")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3bedcef6-5ae2-482d-b6fe-3bfb507903bc"));
		}

		#endregion

	}

	#endregion

}

