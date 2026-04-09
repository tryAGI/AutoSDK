//HintName: G.Models.BaseMessagesResultContentItemsOneOf10Content0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf10Content0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf10Content0" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf10Content0(
            global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode errorCode,
            string? errorMessage,
            global::G.BaseMessagesResultContentItemsOneOf10ContentOneOf0Type type)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf10Content0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf10Content0()
        {
        }
    }
}