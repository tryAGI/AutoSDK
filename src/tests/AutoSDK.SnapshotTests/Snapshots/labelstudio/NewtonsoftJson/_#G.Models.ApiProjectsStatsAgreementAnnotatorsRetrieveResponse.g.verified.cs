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
        [global::Newtonsoft.Json.JsonProperty("agreement", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, double> Agreement { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsAgreementAnnotatorsRetrieveResponse" /> class.
        /// </summary>
        /// <param name="agreement">
        /// Mapping of annotator ID to their agreement score (0-1) or null if no data
        /// </param>
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