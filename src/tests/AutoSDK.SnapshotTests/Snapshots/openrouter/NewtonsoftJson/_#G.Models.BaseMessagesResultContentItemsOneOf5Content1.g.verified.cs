//HintName: G.Models.BaseMessagesResultContentItemsOneOf5Content1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf5Content1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5Content1" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf5Content1(
            global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode errorCode,
            global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf1Type type)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5Content1" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Content1()
        {
        }
    }
}