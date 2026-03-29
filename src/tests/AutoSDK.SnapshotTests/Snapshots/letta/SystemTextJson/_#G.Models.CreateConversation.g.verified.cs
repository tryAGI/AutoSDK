//HintName: G.Models.CreateConversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for creating a new conversation.
    /// </summary>
    public sealed partial class CreateConversation
    {
        /// <summary>
        /// A summary of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// List of block labels that should be isolated (conversation-specific) rather than shared across conversations. New blocks will be created as copies of the agent's blocks with these labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isolated_block_labels")]
        public global::System.Collections.Generic.IList<string>? IsolatedBlockLabels { get; set; }

        /// <summary>
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The model settings for this conversation (overrides agent's model settings).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_settings")]
        public global::G.ModelSettingsVariant16? ModelSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversation" /> class.
        /// </summary>
        /// <param name="summary">
        /// A summary of the conversation.
        /// </param>
        /// <param name="isolatedBlockLabels">
        /// List of block labels that should be isolated (conversation-specific) rather than shared across conversations. New blocks will be created as copies of the agent's blocks with these labels.
        /// </param>
        /// <param name="model">
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for this conversation (overrides agent's model settings).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversation(
            string? summary,
            global::System.Collections.Generic.IList<string>? isolatedBlockLabels,
            string? model,
            global::G.ModelSettingsVariant16? modelSettings)
        {
            this.Summary = summary;
            this.IsolatedBlockLabels = isolatedBlockLabels;
            this.Model = model;
            this.ModelSettings = modelSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversation" /> class.
        /// </summary>
        public CreateConversation()
        {
        }
    }
}