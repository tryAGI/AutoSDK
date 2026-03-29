//HintName: G.Models.TranscriptionDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionDataItems
    {
        /// <summary>
        /// The start of the time range, expressed in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end of the time range, expressed in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Text representing the spoken words within this time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionDataItems" /> class.
        /// </summary>
        /// <param name="start">
        /// The start of the time range, expressed in seconds.
        /// </param>
        /// <param name="end">
        /// The end of the time range, expressed in seconds.
        /// </param>
        /// <param name="value">
        /// Text representing the spoken words within this time range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionDataItems(
            double? start,
            double? end,
            string? value)
        {
            this.Start = start;
            this.End = end;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionDataItems" /> class.
        /// </summary>
        public TranscriptionDataItems()
        {
        }
    }
}