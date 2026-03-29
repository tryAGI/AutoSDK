//HintName: G.Models.BaseMessagesResultContentItemsOneOf7Content0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf7Content0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content0" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf7Content0(
            global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCode errorCode,
            global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf0Type type)
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7Content0()
        {
        }
    }
}