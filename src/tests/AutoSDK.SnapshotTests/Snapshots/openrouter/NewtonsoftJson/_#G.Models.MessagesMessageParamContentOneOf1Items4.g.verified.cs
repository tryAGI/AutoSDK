//HintName: G.Models.MessagesMessageParamContentOneOf1Items4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4Content? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items4" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="isError"></param>
        /// <param name="cacheControl"></param>
        public MessagesMessageParamContentOneOf1Items4(
            string toolUseId,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4Type type,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4Content? content,
            bool? isError,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4CacheControl? cacheControl)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
            this.IsError = isError;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items4" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items4()
        {
        }
    }
}