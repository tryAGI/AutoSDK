//HintName: G.Models.ApiProjectsStatsAgreementAnnotatorRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsAgreementAnnotatorRetrieveResponse
    {
        /// <summary>
        /// Agreement score for the annotator (0-1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Agreement_per_annotator")]
        public double? AgreementPerAnnotator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsAgreementAnnotatorRetrieveResponse" /> class.
        /// </summary>
        /// <param name="agreementPerAnnotator">
        /// Agreement score for the annotator (0-1)
        /// </param>
        public ApiProjectsStatsAgreementAnnotatorRetrieveResponse(
            double? agreementPerAnnotator)
        {
            this.AgreementPerAnnotator = agreementPerAnnotator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsAgreementAnnotatorRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsAgreementAnnotatorRetrieveResponse()
        {
        }
    }
}