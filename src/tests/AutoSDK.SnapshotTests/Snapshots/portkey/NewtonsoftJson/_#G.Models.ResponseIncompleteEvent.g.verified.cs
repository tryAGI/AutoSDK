//HintName: G.Models.ResponseIncompleteEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An event that is emitted when a response finishes as incomplete.
    /// </summary>
    public sealed partial class ResponseIncompleteEvent
    {
        /// <summary>
        /// The type of the event. Always `response.incomplete`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseIncompleteEventTypeJsonConverter))]
        public global::G.ResponseIncompleteEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Response Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteEvent" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="type">
        /// The type of the event. Always `response.incomplete`.
        /// </param>
        public ResponseIncompleteEvent(
            global::G.Response response,
            global::G.ResponseIncompleteEventType type)
        {
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteEvent" /> class.
        /// </summary>
        public ResponseIncompleteEvent()
        {
        }
    }
}