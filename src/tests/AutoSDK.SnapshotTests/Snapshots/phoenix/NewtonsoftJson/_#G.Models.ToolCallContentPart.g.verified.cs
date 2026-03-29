//HintName: G.Models.ToolCallContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallContentPart
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool_call"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "tool_call";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolCallFunction ToolCall { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallContentPart" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="toolCall"></param>
        /// <param name="type"></param>
        public ToolCallContentPart(
            string toolCallId,
            global::G.ToolCallFunction toolCall,
            string type = "tool_call")
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolCall = toolCall ?? throw new global::System.ArgumentNullException(nameof(toolCall));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallContentPart" /> class.
        /// </summary>
        public ToolCallContentPart()
        {
        }
    }
}