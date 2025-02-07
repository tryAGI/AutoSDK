//HintName: G.Models.ChatToolCallsChunkEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallsChunkEventVariant2
    {
        /// <summary>
        /// Contains the chunk of the tool call generation in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolCallDelta ToolCallDelta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsChunkEventVariant2" /> class.
        /// </summary>
        /// <param name="toolCallDelta">
        /// Contains the chunk of the tool call generation in the stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatToolCallsChunkEventVariant2(
            global::G.ToolCallDelta toolCallDelta)
        {
            this.ToolCallDelta = toolCallDelta ?? throw new global::System.ArgumentNullException(nameof(toolCallDelta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsChunkEventVariant2" /> class.
        /// </summary>
        public ChatToolCallsChunkEventVariant2()
        {
        }
    }
}