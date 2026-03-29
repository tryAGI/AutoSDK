//HintName: G.Models.BaseMessagesResultContentItemsOneOf5Caller0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf5Caller0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5Caller0" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf5Caller0(
            global::G.BaseMessagesResultContentItemsOneOf5CallerOneOf0Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5Caller0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5Caller0()
        {
        }
    }
}