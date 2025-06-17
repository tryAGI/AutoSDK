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
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_characters_per_line")]
        public int? MaxCharactersPerLine { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_speakers")]
        public bool? IncludeSpeakers { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_timestamps")]
        public bool? IncludeTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.SrtExportOptionsFormat Format { get; set; }

        /// <summary>
        /// Default Value: 0.6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment_on_silence_longer_than_s")]
        public double? SegmentOnSilenceLongerThanS { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_segment_duration_s")]
        public double? MaxSegmentDurationS { get; set; }

        /// <summary>
        /// Default Value: 90
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_segment_chars")]
        public int? MaxSegmentChars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SrtExportOptions" /> class.
        /// </summary>
        /// <param name="maxCharactersPerLine">
        /// Default Value: 50
        /// </param>
        /// <param name="includeSpeakers">
        /// Default Value: false
        /// </param>
        /// <param name="includeTimestamps">
        /// Default Value: true
        /// </param>
        /// <param name="format"></param>
        /// <param name="segmentOnSilenceLongerThanS">
        /// Default Value: 0.6
        /// </param>
        /// <param name="maxSegmentDurationS">
        /// Default Value: 5
        /// </param>
        /// <param name="maxSegmentChars">
        /// Default Value: 90
        /// </param>
        public SrtExportOptions(
            int? maxCharactersPerLine,
            bool? includeSpeakers,
            bool? includeTimestamps,
            global::G.SrtExportOptionsFormat format,
            double? segmentOnSilenceLongerThanS,
            double? maxSegmentDurationS,
            int? maxSegmentChars)
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