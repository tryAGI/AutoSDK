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
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement")]
        public double? Agreement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsModelStatsAgreementGroundtruthRetrieveResponse" /> class.
        /// </summary>
        /// <param name="agreement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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