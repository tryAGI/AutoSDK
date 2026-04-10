//HintName: G.Models.BaseMessagesResultContentItemsOneOf8Content0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf8Content0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCodeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf8Content0" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf8Content0(
            global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode errorCode,
            global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type type)
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf8Content0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf8Content0()
        {
        }
    }
}