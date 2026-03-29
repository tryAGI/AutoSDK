//HintName: G.Models.LLMResponseBodyToolDetailsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyToolDetailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LLMResponseBodyToolDetailsResponseTypeJsonConverter))]
        public global::G.LLMResponseBodyToolDetailsResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LLMResponseBodyToolDetailsResponseMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tips { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyToolDetailsResponse" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="metadata"></param>
        /// <param name="tips"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMResponseBodyToolDetailsResponse(
            string toolName,
            global::G.LLMResponseBodyToolDetailsResponseMetadata metadata,
            global::System.Collections.Generic.IList<string> tips,
            string message,
            string status,
            global::G.LLMResponseBodyToolDetailsResponseType type)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Tips = tips ?? throw new global::System.ArgumentNullException(nameof(tips));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyToolDetailsResponse" /> class.
        /// </summary>
        public LLMResponseBodyToolDetailsResponse()
        {
        }
    }
}