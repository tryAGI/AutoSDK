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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptEntityMetadataTypeJsonConverter))]
        public global::G.PromptEntityMetadataType? Type { get; set; }

        /// <summary>
        /// The latest version number of the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version_number")]
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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