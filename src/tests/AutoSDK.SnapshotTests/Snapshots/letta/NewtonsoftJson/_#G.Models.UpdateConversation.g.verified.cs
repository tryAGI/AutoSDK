//HintName: G.Models.UpdateConversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for updating a conversation.
    /// </summary>
    public sealed partial class UpdateConversation
    {
        /// <summary>
        /// A summary of the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The model settings for this conversation (overrides agent's model settings).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_settings")]
        public global::G.ModelSettingsVariant19? ModelSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversation" /> class.
        /// </summary>
        /// <param name="summary">
        /// A summary of the conversation.
        /// </param>
        /// <param name="model">
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for this conversation (overrides agent's model settings).
        /// </param>
        public UpdateConversation(
            string? summary,
            string? model,
            global::G.ModelSettingsVariant19? modelSettings)
        {
            this.Summary = summary;
            this.Model = model;
            this.ModelSettings = modelSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversation" /> class.
        /// </summary>
        public UpdateConversation()
        {
        }
    }
}