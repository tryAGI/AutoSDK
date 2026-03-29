//HintName: G.Models.ToolResultContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResultContentPart
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool_result"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "tool_result";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object> ToolResult { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultContentPart" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="toolResult"></param>
        /// <param name="type"></param>
        public ToolResultContentPart(
            string toolCallId,
            global::G.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object> toolResult,
            string type = "tool_result")
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolResult = toolResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultContentPart" /> class.
        /// </summary>
        public ToolResultContentPart()
        {
        }
    }
}