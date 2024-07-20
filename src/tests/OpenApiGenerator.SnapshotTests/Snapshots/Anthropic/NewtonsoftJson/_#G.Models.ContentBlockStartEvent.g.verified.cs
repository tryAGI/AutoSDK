//HintName: G.Models.ContentBlockStartEvent.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A start event in a streaming content block.
    /// </summary>
    public sealed partial class ContentBlockStartEvent
    {
        /// <summary>
        /// A block of content in a message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_block", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.OneOf<global::G.TextBlock?, global::G.ImageBlock?, global::G.ToolUseBlock?, global::G.ToolResultBlock?> ContentBlock { get; set; } = default!;

        /// <summary>
        /// The index of the content block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageStreamEventType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}