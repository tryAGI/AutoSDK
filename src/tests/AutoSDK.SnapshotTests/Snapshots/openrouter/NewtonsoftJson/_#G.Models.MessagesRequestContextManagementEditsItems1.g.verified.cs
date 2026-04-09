//HintName: G.Models.MessagesRequestContextManagementEditsItems1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keep")]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep? Keep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="keep"></param>
        public MessagesRequestContextManagementEditsItems1(
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Type type,
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep? keep)
        {
            this.Type = type;
            this.Keep = keep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems1" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItems1()
        {
        }
    }
}