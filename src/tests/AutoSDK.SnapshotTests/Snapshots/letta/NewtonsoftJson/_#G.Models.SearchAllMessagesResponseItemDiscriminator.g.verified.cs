//HintName: G.Models.SearchAllMessagesResponseItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchAllMessagesResponseItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SearchAllMessagesResponseItemDiscriminatorMessageTypeJsonConverter))]
        public global::G.SearchAllMessagesResponseItemDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAllMessagesResponseItemDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
        public SearchAllMessagesResponseItemDiscriminator(
            global::G.SearchAllMessagesResponseItemDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAllMessagesResponseItemDiscriminator" /> class.
        /// </summary>
        public SearchAllMessagesResponseItemDiscriminator()
        {
        }
    }
}