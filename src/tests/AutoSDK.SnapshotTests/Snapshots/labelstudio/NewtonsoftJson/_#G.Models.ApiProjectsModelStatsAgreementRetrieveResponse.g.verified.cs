//HintName: G.Models.ApiProjectsModelStatsAgreementRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsModelStatsAgreementRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agreement")]
        public double? Agreement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsModelStatsAgreementRetrieveResponse" /> class.
        /// </summary>
        /// <param name="agreement"></param>
        public ApiProjectsModelStatsAgreementRetrieveResponse(
            double? agreement)
        {
            this.Agreement = agreement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsModelStatsAgreementRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsModelStatsAgreementRetrieveResponse()
        {
        }
    }
}