//HintName: G.Models.ResponseTextDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseTextDeltaEvent
    {
        /// <summary>
        /// Index of the content part
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public double ContentIndex { get; set; } = default!;

        /// <summary>
        /// Text delta being added
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// ID of the output item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// Index of the output item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public double OutputIndex { get; set; } = default!;

        /// <summary>
        /// Event type<br/>
        /// Default Value: response.output_text.delta
        /// </summary>
        /// <default>global::G.ResponseTextDeltaEventType.ResponseOutputTextDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseTextDeltaEventTypeJsonConverter))]
        public global::G.ResponseTextDeltaEventType Type { get; set; } = global::G.ResponseTextDeltaEventType.ResponseOutputTextDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// Index of the content part
        /// </param>
        /// <param name="delta">
        /// Text delta being added
        /// </param>
        /// <param name="itemId">
        /// ID of the output item
        /// </param>
        /// <param name="outputIndex">
        /// Index of the output item
        /// </param>
        /// <param name="type">
        /// Event type<br/>
        /// Default Value: response.output_text.delta
        /// </param>
        public ResponseTextDeltaEvent(
            double contentIndex,
            string delta,
            string itemId,
            double outputIndex,
            global::G.ResponseTextDeltaEventType type = global::G.ResponseTextDeltaEventType.ResponseOutputTextDelta)
        {
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDeltaEvent" /> class.
        /// </summary>
        public ResponseTextDeltaEvent()
        {
        }
    }
}