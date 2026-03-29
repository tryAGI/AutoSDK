//HintName: G.Models.ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse
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
        /// Initializes a new instance of the <see cref="ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse" /> class.
        /// </summary>
        /// <param name="agreement"></param>
        public ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse(
            double? agreement)
        {
            this.Agreement = agreement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse()
        {
        }
    }
}