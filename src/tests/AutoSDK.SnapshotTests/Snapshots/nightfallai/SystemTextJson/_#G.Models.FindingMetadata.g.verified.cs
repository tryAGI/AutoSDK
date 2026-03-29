//HintName: G.Models.FindingMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FindingMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyMetadata")]
        public global::G.APIKeyMetadata? ApiKeyMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindingMetadata" /> class.
        /// </summary>
        /// <param name="apiKeyMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindingMetadata(
            global::G.APIKeyMetadata? apiKeyMetadata)
        {
            this.ApiKeyMetadata = apiKeyMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindingMetadata" /> class.
        /// </summary>
        public FindingMetadata()
        {
        }
    }
}