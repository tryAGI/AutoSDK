//HintName: G.Models.ApiProjectsStatsAgreementAnnotatorsRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsAgreementAnnotatorsRetrieveResponse
    {
        /// <summary>
        /// Mapping of annotator ID to their agreement score (0-1) or null if no data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Agreement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsAgreementAnnotatorsRetrieveResponse" /> class.
        /// </summary>
        /// <param name="agreement">
        /// Mapping of annotator ID to their agreement score (0-1) or null if no data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsStatsAgreementAnnotatorsRetrieveResponse(
            global::System.Collections.Generic.Dictionary<string, double> agreement)
        {
            this.Agreement = agreement ?? throw new global::System.ArgumentNullException(nameof(agreement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsAgreementAnnotatorsRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsAgreementAnnotatorsRetrieveResponse()
        {
        }
    }
}