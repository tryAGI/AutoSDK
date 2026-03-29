//HintName: G.Models.TranscriptElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptElement
    {
        /// <summary>
        /// Type of element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptElementTypeJsonConverter))]
        public global::G.TranscriptElementType? Type { get; set; }

        /// <summary>
        /// Text value of the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Start timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        public double? Ts { get; set; }

        /// <summary>
        /// End timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ts")]
        public double? EndTs { get; set; }

        /// <summary>
        /// Confidence score (null for punct and unknown types)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptElement" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of element
        /// </param>
        /// <param name="value">
        /// Text value of the element
        /// </param>
        /// <param name="ts">
        /// Start timestamp in seconds
        /// </param>
        /// <param name="endTs">
        /// End timestamp in seconds
        /// </param>
        /// <param name="confidence">
        /// Confidence score (null for punct and unknown types)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptElement(
            global::G.TranscriptElementType? type,
            string? value,
            double? ts,
            double? endTs,
            double? confidence)
        {
            this.Type = type;
            this.Value = value;
            this.Ts = ts;
            this.EndTs = endTs;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptElement" /> class.
        /// </summary>
        public TranscriptElement()
        {
        }
    }
}