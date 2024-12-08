//HintName: G.Models.RequestToolResultBlock.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestToolResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RequestToolResultBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item5>>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestToolResultBlock" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="toolUseId"></param>
        /// <param name="isError"></param>
        /// <param name="content"></param>
        public RequestToolResultBlock(
            string toolUseId,
            global::G.RequestToolResultBlockType type,
            bool? isError,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item5>>? content)
        {
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
            this.IsError = isError;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestToolResultBlock" /> class.
        /// </summary>
        public RequestToolResultBlock()
        {
        }
    }
}