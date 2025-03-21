//HintName: G.Models.MessageStreamEventVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when parts of a [Message](/docs/api-reference/messages/object) are being streamed.
    /// </summary>
    public sealed partial class MessageStreamEventVariant3
    {
        /// <summary>
        /// Represents a message delta i.e. any changed fields on a message during streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageDeltaObject Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageStreamEventVariant3EventJsonConverter))]
        public global::G.MessageStreamEventVariant3Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a message delta i.e. any changed fields on a message during streaming.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageStreamEventVariant3(
            global::G.MessageDeltaObject data,
            global::G.MessageStreamEventVariant3Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant3" /> class.
        /// </summary>
        public MessageStreamEventVariant3()
        {
        }
    }
}