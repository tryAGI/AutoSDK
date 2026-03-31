//HintName: G.Models.UpdateAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentRequest
    {
        /// <summary>
        /// The name of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_voice")]
        public string? TtsVoice { get; set; }

        /// <summary>
        /// The language to use for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_language")]
        public string? TtsLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the agent.
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="ttsVoice">
        /// The ID of the voice.
        /// </param>
        /// <param name="ttsLanguage">
        /// The language to use for text-to-speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRequest(
            string? name,
            string? description,
            string? ttsVoice,
            string? ttsLanguage)
        {
            this.Name = name;
            this.Description = description;
            this.TtsVoice = ttsVoice;
            this.TtsLanguage = ttsLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        public UpdateAgentRequest()
        {
        }
    }
}