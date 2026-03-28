//HintName: G.Models.SrtExportOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SrtExportOptions
    {
        /// <summary>
        /// Default Value: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_characters_per_line")]
        public int? MaxCharactersPerLine { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_speakers")]
        public bool? IncludeSpeakers { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_timestamps")]
        public bool? IncludeTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"srt"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string Format { get; set; } = "srt";

        /// <summary>
        /// Default Value: 0.8F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_on_silence_longer_than_s")]
        public double? SegmentOnSilenceLongerThanS { get; set; }

        /// <summary>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_duration_s")]
        public double? MaxSegmentDurationS { get; set; }

        /// <summary>
        /// Default Value: 84
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_chars")]
        public int? MaxSegmentChars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SrtExportOptions" /> class.
        /// </summary>
        /// <param name="maxCharactersPerLine">
        /// Default Value: 42
        /// </param>
        /// <param name="includeSpeakers">
        /// Default Value: false
        /// </param>
        /// <param name="includeTimestamps">
        /// Default Value: true
        /// </param>
        /// <param name="segmentOnSilenceLongerThanS">
        /// Default Value: 0.8F
        /// </param>
        /// <param name="maxSegmentDurationS">
        /// Default Value: 4
        /// </param>
        /// <param name="maxSegmentChars">
        /// Default Value: 84
        /// </param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SrtExportOptions(
            int? maxCharactersPerLine,
            bool? includeSpeakers,
            bool? includeTimestamps,
            double? segmentOnSilenceLongerThanS,
            double? maxSegmentDurationS,
            int? maxSegmentChars,
            string format = "srt")
        {
            this.MaxCharactersPerLine = maxCharactersPerLine;
            this.IncludeSpeakers = includeSpeakers;
            this.IncludeTimestamps = includeTimestamps;
            this.Format = format;
            this.SegmentOnSilenceLongerThanS = segmentOnSilenceLongerThanS;
            this.MaxSegmentDurationS = maxSegmentDurationS;
            this.MaxSegmentChars = maxSegmentChars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SrtExportOptions" /> class.
        /// </summary>
        public SrtExportOptions()
        {
        }
    }
}