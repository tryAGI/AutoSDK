//HintName: G.Models.ChatCompletionRequestAssistantMessageAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data about a previous audio response from the model. <br/>
    /// [Learn more](/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionRequestAssistantMessageAudio
    {
        /// <summary>
        /// Unique identifier for a previous audio response from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessageAudio" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for a previous audio response from the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestAssistantMessageAudio(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessageAudio" /> class.
        /// </summary>
        public ChatCompletionRequestAssistantMessageAudio()
        {
        }
    }
}