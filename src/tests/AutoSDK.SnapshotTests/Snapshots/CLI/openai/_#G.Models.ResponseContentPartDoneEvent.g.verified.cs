﻿//HintName: G.Models.ResponseContentPartDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a content part is done.
    /// </summary>
    public sealed partial class ResponseContentPartDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.content_part.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter))]
        public global::G.ResponseContentPartDoneEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the content part was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the content part was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part that is done.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OutputContent Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseContentPartDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.content_part.done`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the content part was added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the content part was added to.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that is done.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="part"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseContentPartDoneEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            int sequenceNumber,
            global::G.OutputContent part,
            global::G.ResponseContentPartDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.SequenceNumber = sequenceNumber;
            this.Part = part;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseContentPartDoneEvent" /> class.
        /// </summary>
        public ResponseContentPartDoneEvent()
        {
        }
    }
}