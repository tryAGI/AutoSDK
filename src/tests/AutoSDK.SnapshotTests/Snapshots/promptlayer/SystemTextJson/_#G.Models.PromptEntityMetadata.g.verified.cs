//HintName: G.Models.PromptEntityMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptEntityMetadata
    {
        /// <summary>
        /// The prompt template type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptEntityMetadataTypeJsonConverter))]
        public global::G.PromptEntityMetadataType? Type { get; set; }

        /// <summary>
        /// The latest version number of the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_number")]
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEntityMetadata" /> class.
        /// </summary>
        /// <param name="type">
        /// The prompt template type.
        /// </param>
        /// <param name="latestVersionNumber">
        /// The latest version number of the prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptEntityMetadata(
            global::G.PromptEntityMetadataType? type,
            int? latestVersionNumber)
        {
            this.Type = type;
            this.LatestVersionNumber = latestVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEntityMetadata" /> class.
        /// </summary>
        public PromptEntityMetadata()
        {
        }
    }
}