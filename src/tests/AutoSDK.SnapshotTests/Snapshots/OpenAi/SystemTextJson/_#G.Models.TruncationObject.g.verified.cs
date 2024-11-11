//HintName: G.Models.TruncationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls for how a thread will be truncated prior to the run. Use this to control the intial context window of the run.
    /// </summary>
    public sealed partial class TruncationObject
    {
        /// <summary>
        /// The truncation strategy to use for the thread. The default is `auto`. If set to `last_messages`, the thread will be truncated to the n most recent messages in the thread. When set to `auto`, messages in the middle of the thread will be dropped to fit the context length of the model, `max_prompt_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TruncationObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TruncationObjectType Type { get; set; }

        /// <summary>
        /// The number of most recent messages from the thread when constructing the context for the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_messages")]
        public int? LastMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TruncationObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The truncation strategy to use for the thread. The default is `auto`. If set to `last_messages`, the thread will be truncated to the n most recent messages in the thread. When set to `auto`, messages in the middle of the thread will be dropped to fit the context length of the model, `max_prompt_tokens`.
        /// </param>
        /// <param name="lastMessages">
        /// The number of most recent messages from the thread when constructing the context for the run.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TruncationObject(
            global::G.TruncationObjectType type,
            int? lastMessages)
        {
            this.Type = type;
            this.LastMessages = lastMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TruncationObject" /> class.
        /// </summary>
        public TruncationObject()
        {
        }
    }
}