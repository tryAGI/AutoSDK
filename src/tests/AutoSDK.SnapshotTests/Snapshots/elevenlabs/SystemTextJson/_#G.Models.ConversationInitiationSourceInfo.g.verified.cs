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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::G.ConversationInitiationSource? Source { get; set; }

        /// <summary>
        /// The SDK version number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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