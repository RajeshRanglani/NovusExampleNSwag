using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovusExampleNSwag
{
	public partial class QuoteCreate
	{
		public string SubmissionReference { get; set; }

		public string SubmissionVersionDescription { get; set; }

		public string BrokerUserEmailAddress { get; set; }

		public string ProgrammeReference { get; set; }

		public string ProgrammeDescription { get; set; }

		public string ContractReference { get; set; }

		public string ContractDescription { get; set; }

		public string InsuredOrReinsured { get; set; }
		public string OriginalPolicyholder { get; set; }

		public string CoverTypeCode { get; set; }

		public string ClassOfBusinessCode { get; set; }

		public string RiskRegionCode { get; set; }

		public string RiskCountryCode { get; set; }

	}
}
