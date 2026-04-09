//HintName: G.Models.BaseMessagesResultContentItemsOneOf6Caller0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf6Caller0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf0TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf6CallerOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6Caller0" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf6Caller0(
            global::G.BaseMessagesResultContentItemsOneOf6CallerOneOf0Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6Caller0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Caller0()
        {
        }
    }
}