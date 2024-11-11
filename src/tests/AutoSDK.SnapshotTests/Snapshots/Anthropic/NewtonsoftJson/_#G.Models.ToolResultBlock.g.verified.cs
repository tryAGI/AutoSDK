//HintName: G.Models.ToolResultBlock.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The result of using a tool.
    /// </summary>
    public sealed partial class ToolResultBlock
    {
        /// <summary>
        /// The `id` of the tool use request this is a result for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// The result of the tool, as a string (e.g. `"content": "15 degrees"`) <br/>
        /// or list of nested content blocks (e.g. `"content": [{"type": "text", "text": "15 degrees"}]`). <br/>
        /// These content blocks can use the text or image types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.Block>> Content { get; set; } = default!;

        /// <summary>
        /// Set to `true` if the tool execution resulted in an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: tool_result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultBlock" /> class.
        /// </summary>
        /// <param name="toolUseId">
        /// The `id` of the tool use request this is a result for.
        /// </param>
        /// <param name="content">
        /// The result of the tool, as a string (e.g. `"content": "15 degrees"`) <br/>
        /// or list of nested content blocks (e.g. `"content": [{"type": "text", "text": "15 degrees"}]`). <br/>
        /// These content blocks can use the text or image types.
        /// </param>
        /// <param name="isError">
        /// Set to `true` if the tool execution resulted in an error.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: tool_result
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        public ToolResultBlock(
            string toolUseId,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.Block>> content,
            bool? isError,
            string? type,
            global::G.CacheControlEphemeral? cacheControl)
        {
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
            this.IsError = isError;
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultBlock" /> class.
        /// </summary>
        public ToolResultBlock()
        {
        }
    }
}