//HintName: G.Models.GetPublicApiMediaAssetMetadataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPublicApiMediaAssetMetadataResponse
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detectedLanguage")]
        public global::G.LanguageBCP47? DetectedLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicApiMediaAssetMetadataResponse" /> class.
        /// </summary>
        /// <param name="detectedLanguage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public GetPublicApiMediaAssetMetadataResponse(
            global::G.LanguageBCP47? detectedLanguage)
        {
            this.DetectedLanguage = detectedLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicApiMediaAssetMetadataResponse" /> class.
        /// </summary>
        public GetPublicApiMediaAssetMetadataResponse()
        {
        }
    }
}