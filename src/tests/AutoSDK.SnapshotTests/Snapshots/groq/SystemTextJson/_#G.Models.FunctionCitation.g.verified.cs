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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The character index in the message content where this citation ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The ID of the tool call being cited, corresponding to a tool call made during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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