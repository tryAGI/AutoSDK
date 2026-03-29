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
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ContentIndex { get; set; }

        /// <summary>
        /// Text delta being added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// ID of the output item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Index of the output item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OutputIndex { get; set; }

        /// <summary>
        /// Event type<br/>
        /// Default Value: response.output_text.delta
        /// </summary>
        /// <default>global::G.ResponseTextDeltaEventType.ResponseOutputTextDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseTextDeltaEventTypeJsonConverter))]
        public global::G.ResponseTextDeltaEventType Type { get; set; } = global::G.ResponseTextDeltaEventType.ResponseOutputTextDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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