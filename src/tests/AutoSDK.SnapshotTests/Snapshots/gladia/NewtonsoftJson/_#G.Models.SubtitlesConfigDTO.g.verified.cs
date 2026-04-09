//HintName: G.Models.SubtitlesConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubtitlesConfigDTO
    {
        /// <summary>
        /// Subtitles formats you want your transcription to be formatted to<br/>
        /// Default Value: [srt]<br/>
        /// Example: [srt]
        /// </summary>
        /// <example>[srt]</example>
        [global::Newtonsoft.Json.JsonProperty("formats")]
        public global::System.Collections.Generic.IList<global::G.SubtitlesFormatEnum>? Formats { get; set; }

        /// <summary>
        /// Minimum duration of a subtitle in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimum_duration")]
        public double? MinimumDuration { get; set; }

        /// <summary>
        /// Maximum duration of a subtitle in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_duration")]
        public double? MaximumDuration { get; set; }

        /// <summary>
        /// Maximum number of characters per row in a subtitle
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_characters_per_row")]
        public int? MaximumCharactersPerRow { get; set; }

        /// <summary>
        /// Maximum number of rows per caption
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_rows_per_caption")]
        public int? MaximumRowsPerCaption { get; set; }

        /// <summary>
        /// Style of the subtitles. Compliance mode refers to : https://loc.gov/preservation/digital/formats//fdd/fdd000569.shtml#:~:text=SRT%20files%20are%20basic%20text,alongside%2C%20example%3A%20%22MyVideo123<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SubtitlesStyleEnumJsonConverter))]
        public global::G.SubtitlesStyleEnum? Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitlesConfigDTO" /> class.
        /// </summary>
        /// <param name="formats">
        /// Subtitles formats you want your transcription to be formatted to<br/>
        /// Default Value: [srt]<br/>
        /// Example: [srt]
        /// </param>
        /// <param name="minimumDuration">
        /// Minimum duration of a subtitle in seconds
        /// </param>
        /// <param name="maximumDuration">
        /// Maximum duration of a subtitle in seconds
        /// </param>
        /// <param name="maximumCharactersPerRow">
        /// Maximum number of characters per row in a subtitle
        /// </param>
        /// <param name="maximumRowsPerCaption">
        /// Maximum number of rows per caption
        /// </param>
        /// <param name="style">
        /// Style of the subtitles. Compliance mode refers to : https://loc.gov/preservation/digital/formats//fdd/fdd000569.shtml#:~:text=SRT%20files%20are%20basic%20text,alongside%2C%20example%3A%20%22MyVideo123<br/>
        /// Default Value: default
        /// </param>
        public SubtitlesConfigDTO(
            global::System.Collections.Generic.IList<global::G.SubtitlesFormatEnum>? formats,
            double? minimumDuration,
            double? maximumDuration,
            int? maximumCharactersPerRow,
            int? maximumRowsPerCaption,
            global::G.SubtitlesStyleEnum? style)
        {
            this.Formats = formats;
            this.MinimumDuration = minimumDuration;
            this.MaximumDuration = maximumDuration;
            this.MaximumCharactersPerRow = maximumCharactersPerRow;
            this.MaximumRowsPerCaption = maximumRowsPerCaption;
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitlesConfigDTO" /> class.
        /// </summary>
        public SubtitlesConfigDTO()
        {
        }
    }
}