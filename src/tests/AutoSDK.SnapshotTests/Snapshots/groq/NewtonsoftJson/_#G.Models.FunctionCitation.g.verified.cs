//HintName: G.Models.FunctionCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation referencing the result of a function or tool call.
    /// </summary>
    public sealed partial class FunctionCitation
    {
        /// <summary>
        /// The character index in the message content where this citation begins.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// The character index in the message content where this citation ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the tool call being cited, corresponding to a tool call made during the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCitation" /> class.
        /// </summary>
        /// <param name="startIndex">
        /// The character index in the message content where this citation begins.
        /// </param>
        /// <param name="endIndex">
        /// The character index in the message content where this citation ends.
        /// </param>
        /// <param name="toolCallId">
        /// The ID of the tool call being cited, corresponding to a tool call made during the conversation.
        /// </param>
        public FunctionCitation(
            int startIndex,
            int endIndex,
            string toolCallId)
        {
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCitation" /> class.
        /// </summary>
        public FunctionCitation()
        {
        }
    }
}