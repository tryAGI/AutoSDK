//HintName: G.Models.MessagesMessageParamContentOneOf1Items8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf8CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items8" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl"></param>
        public MessagesMessageParamContentOneOf1Items8(
            string toolUseId,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content content,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Type type,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf8CacheControl? cacheControl)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items8" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items8()
        {
        }
    }
}