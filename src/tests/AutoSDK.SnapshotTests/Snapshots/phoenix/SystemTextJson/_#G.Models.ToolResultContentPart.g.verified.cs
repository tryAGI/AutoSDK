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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_result";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object> ToolResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultContentPart" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="toolResult"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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