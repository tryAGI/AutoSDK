//HintName: G.Models.ToolMessageV2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A message with Tool outputs.
    /// </summary>
    public sealed partial class ToolMessageV2
    {
        /// <summary>
        /// Outputs from a tool. The content should formatted as a JSON object string, or a list of tool content blocks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ToolContent>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ToolMessageV2Role Role { get; set; }

        /// <summary>
        /// The id of the associated tool call that has provided the given content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageV2" /> class.
        /// </summary>
        /// <param name="content">
        /// Outputs from a tool. The content should formatted as a JSON object string, or a list of tool content blocks
        /// </param>
        /// <param name="role"></param>
        /// <param name="toolCallId">
        /// The id of the associated tool call that has provided the given content
        /// </param>
        public ToolMessageV2(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ToolContent>> content,
            string toolCallId,
            global::G.ToolMessageV2Role role)
        {
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageV2" /> class.
        /// </summary>
        public ToolMessageV2()
        {
        }
    }
}