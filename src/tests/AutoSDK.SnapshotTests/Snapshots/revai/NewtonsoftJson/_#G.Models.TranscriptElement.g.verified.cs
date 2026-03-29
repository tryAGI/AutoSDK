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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TranscriptElementType? Type { get; set; }

        /// <summary>
        /// Text value of the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Start timestamp in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ts")]
        public double? Ts { get; set; }

        /// <summary>
        /// End timestamp in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_ts")]
        public double? EndTs { get; set; }

        /// <summary>
        /// Confidence score (null for punct and unknown types)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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