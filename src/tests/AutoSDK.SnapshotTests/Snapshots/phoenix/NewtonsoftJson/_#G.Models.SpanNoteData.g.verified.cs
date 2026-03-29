//HintName: G.Models.SpanNoteData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanNoteData
    {
        /// <summary>
        /// OpenTelemetry Span ID (hex format w/o 0x prefix)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanId { get; set; } = default!;

        /// <summary>
        /// The note text to add to the span
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note", Required = global::Newtonsoft.Json.Required.Always)]
        public string Note { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanNoteData" /> class.
        /// </summary>
        /// <param name="spanId">
        /// OpenTelemetry Span ID (hex format w/o 0x prefix)
        /// </param>
        /// <param name="note">
        /// The note text to add to the span
        /// </param>
        public SpanNoteData(
            string spanId,
            string note)
        {
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanNoteData" /> class.
        /// </summary>
        public SpanNoteData()
        {
        }
    }
}