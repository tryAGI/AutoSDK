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
        [global::Newtonsoft.Json.JsonProperty("tool_call_delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolCallDelta ToolCallDelta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsChunkEventVariant2" /> class.
        /// </summary>
        /// <param name="toolCallDelta">
        /// Contains the chunk of the tool call generation in the stream.
        /// </param>
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