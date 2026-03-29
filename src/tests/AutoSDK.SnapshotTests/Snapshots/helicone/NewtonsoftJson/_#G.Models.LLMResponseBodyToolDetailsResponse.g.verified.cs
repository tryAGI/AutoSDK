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
        [global::Newtonsoft.Json.JsonProperty("toolName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_type")]
        public global::G.LLMResponseBodyToolDetailsResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LLMResponseBodyToolDetailsResponseMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tips", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tips { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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