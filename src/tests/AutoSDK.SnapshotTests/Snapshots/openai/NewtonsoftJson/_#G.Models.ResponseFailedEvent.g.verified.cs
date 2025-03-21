//HintName: G.Models.ResponseFailedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An event that is emitted when a response fails.
    /// </summary>
    public sealed partial class ResponseFailedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.failed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFailedEventType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseFailedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.failed`.
        /// </param>
        /// <param name="response"></param>
        public ResponseFailedEvent(
            global::G.Response response,
            global::G.ResponseFailedEventType type)
        {
            this.Response = response;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFailedEvent" /> class.
        /// </summary>
        public ResponseFailedEvent()
        {
        }
    }
}