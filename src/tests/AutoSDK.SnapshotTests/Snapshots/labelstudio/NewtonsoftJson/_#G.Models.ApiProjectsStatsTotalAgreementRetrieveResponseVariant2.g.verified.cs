//HintName: G.Models.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsTotalAgreementRetrieveResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_agreement")]
        public global::System.Collections.Generic.Dictionary<string, double>? TotalAgreement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsTotalAgreementRetrieveResponseVariant2" /> class.
        /// </summary>
        /// <param name="totalAgreement"></param>
        public ApiProjectsStatsTotalAgreementRetrieveResponseVariant2(
            global::System.Collections.Generic.Dictionary<string, double>? totalAgreement)
        {
            this.TotalAgreement = totalAgreement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsTotalAgreementRetrieveResponseVariant2" /> class.
        /// </summary>
        public ApiProjectsStatsTotalAgreementRetrieveResponseVariant2()
        {
        }
    }
}