//HintName: G.Models.ValidateSamlMetadataUrlRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateSamlMetadataUrlRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetadataUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateSamlMetadataUrlRequestRequest" /> class.
        /// </summary>
        /// <param name="metadataUrl"></param>
        public ValidateSamlMetadataUrlRequestRequest(
            string metadataUrl)
        {
            this.MetadataUrl = metadataUrl ?? throw new global::System.ArgumentNullException(nameof(metadataUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateSamlMetadataUrlRequestRequest" /> class.
        /// </summary>
        public ValidateSamlMetadataUrlRequestRequest()
        {
        }
    }
}