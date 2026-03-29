//HintName: G.Models.MessagesRequestPluginsItems1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestPluginsItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.MessagesRequestPluginsItemsOneOf1Id Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItems1" /> class.
        /// </summary>
        /// <param name="id"></param>
        public MessagesRequestPluginsItems1(
            global::G.MessagesRequestPluginsItemsOneOf1Id id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItems1" /> class.
        /// </summary>
        public MessagesRequestPluginsItems1()
        {
        }
    }
}