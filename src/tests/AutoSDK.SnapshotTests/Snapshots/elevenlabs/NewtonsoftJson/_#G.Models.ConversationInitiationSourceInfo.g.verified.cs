//HintName: G.Models.ConversationInitiationSourceInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the source of conversation initiation
    /// </summary>
    public sealed partial class ConversationInitiationSourceInfo
    {
        /// <summary>
        /// Source of the conversation initiation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.ConversationInitiationSource? Source { get; set; }

        /// <summary>
        /// The SDK version number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationSourceInfo" /> class.
        /// </summary>
        /// <param name="source">
        /// Source of the conversation initiation
        /// </param>
        /// <param name="version">
        /// The SDK version number
        /// </param>
        public ConversationInitiationSourceInfo(
            global::G.ConversationInitiationSource? source,
            string? version)
        {
            this.Source = source;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationSourceInfo" /> class.
        /// </summary>
        public ConversationInitiationSourceInfo()
        {
        }
    }
}