//HintName: G.Models.ResponseCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseCompletedEvent
    {
        /// <summary>
        /// The completed response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseObject Response { get; set; }

        /// <summary>
        /// Event type<br/>
        /// Default Value: response.completed
        /// </summary>
        /// <default>global::G.ResponseCompletedEventType.ResponseCompleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCompletedEventTypeJsonConverter))]
        public global::G.ResponseCompletedEventType Type { get; set; } = global::G.ResponseCompletedEventType.ResponseCompleted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCompletedEvent" /> class.
        /// </summary>
        /// <param name="response">
        /// The completed response
        /// </param>
        /// <param name="type">
        /// Event type<br/>
        /// Default Value: response.completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCompletedEvent(
            global::G.ResponseObject response,
            global::G.ResponseCompletedEventType type = global::G.ResponseCompletedEventType.ResponseCompleted)
        {
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCompletedEvent" /> class.
        /// </summary>
        public ResponseCompletedEvent()
        {
        }
    }
}