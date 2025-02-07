//HintName: G.Models.AssistantStreamEventVariant23.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when parts of a [Message](/docs/api-reference/messages/object) are being streamed.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant23
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantStreamEventVariant23EventJsonConverter))]
        public global::G.AssistantStreamEventVariant23Event Event { get; set; }

        /// <summary>
        /// Represents a message delta i.e. any changed fields on a message during streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageDeltaObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant23" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a message delta i.e. any changed fields on a message during streaming.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantStreamEventVariant23(
            global::G.MessageDeltaObject data,
            global::G.AssistantStreamEventVariant23Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant23" /> class.
        /// </summary>
        public AssistantStreamEventVariant23()
        {
        }
    }
}