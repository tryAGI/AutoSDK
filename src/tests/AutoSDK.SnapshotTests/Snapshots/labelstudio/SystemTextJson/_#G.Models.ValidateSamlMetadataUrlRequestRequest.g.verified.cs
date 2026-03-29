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
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetadataUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateSamlMetadataUrlRequestRequest" /> class.
        /// </summary>
        /// <param name="metadataUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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