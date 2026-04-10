//HintName: G.Models.BaseMessagesResultContentItemsOneOf6Content0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf6Content0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf0Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCodeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6Content0" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf6Content0(
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode errorCode,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf0Type type)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6Content0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Content0()
        {
        }
    }
}