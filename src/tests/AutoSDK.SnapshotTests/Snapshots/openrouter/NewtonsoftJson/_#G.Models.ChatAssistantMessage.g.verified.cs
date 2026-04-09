//HintName: G.Models.ChatAssistantMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Assistant message for requests and responses
    /// </summary>
    public sealed partial class ChatAssistantMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatAssistantMessageRoleJsonConverter))]
        public global::G.ChatAssistantMessageRole Role { get; set; }

        /// <summary>
        /// Assistant message content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.ChatAssistantMessageContent? Content { get; set; }

        /// <summary>
        /// Optional name for the assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tool calls made by the assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Refusal message if content was refused
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Reasoning output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Reasoning details for extended thinking models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_details")]
        public global::System.Collections.Generic.IList<global::G.ReasoningDetailUnion>? ReasoningDetails { get; set; }

        /// <summary>
        /// Generated images from image generation models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<global::G.ChatAssistantImagesItems>? Images { get; set; }

        /// <summary>
        /// Audio output data or reference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.ChatAudioOutput? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content">
        /// Assistant message content
        /// </param>
        /// <param name="name">
        /// Optional name for the assistant
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls made by the assistant
        /// </param>
        /// <param name="refusal">
        /// Refusal message if content was refused
        /// </param>
        /// <param name="reasoning">
        /// Reasoning output
        /// </param>
        /// <param name="reasoningDetails">
        /// Reasoning details for extended thinking models
        /// </param>
        /// <param name="images">
        /// Generated images from image generation models
        /// </param>
        /// <param name="audio">
        /// Audio output data or reference
        /// </param>
        public ChatAssistantMessage(
            global::G.ChatAssistantMessageRole role,
            global::G.ChatAssistantMessageContent? content,
            string? name,
            global::System.Collections.Generic.IList<global::G.ChatToolCall>? toolCalls,
            string? refusal,
            string? reasoning,
            global::System.Collections.Generic.IList<global::G.ReasoningDetailUnion>? reasoningDetails,
            global::System.Collections.Generic.IList<global::G.ChatAssistantImagesItems>? images,
            global::G.ChatAudioOutput? audio)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.ToolCalls = toolCalls;
            this.Refusal = refusal;
            this.Reasoning = reasoning;
            this.ReasoningDetails = reasoningDetails;
            this.Images = images;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantMessage" /> class.
        /// </summary>
        public ChatAssistantMessage()
        {
        }
    }
}