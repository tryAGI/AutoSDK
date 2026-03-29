//HintName: G.Models.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsTotalAgreementRetrieveResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_agreement")]
        public double? TotalAgreement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsTotalAgreementRetrieveResponseVariant1" /> class.
        /// </summary>
        /// <param name="totalAgreement"></param>
        public ApiProjectsStatsTotalAgreementRetrieveResponseVariant1(
            double? totalAgreement)
        {
            this.TotalAgreement = totalAgreement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsTotalAgreementRetrieveResponseVariant1" /> class.
        /// </summary>
        public ApiProjectsStatsTotalAgreementRetrieveResponseVariant1()
        {
        }
    }
}