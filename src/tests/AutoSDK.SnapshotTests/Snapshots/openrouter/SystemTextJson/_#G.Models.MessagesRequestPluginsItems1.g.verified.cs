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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestPluginsItemsOneOf1IdJsonConverter))]
        public global::G.MessagesRequestPluginsItemsOneOf1Id Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItems1" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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