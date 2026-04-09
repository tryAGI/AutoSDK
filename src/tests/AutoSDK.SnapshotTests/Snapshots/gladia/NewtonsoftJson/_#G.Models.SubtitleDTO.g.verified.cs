//HintName: G.Models.SubtitleDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubtitleDTO
    {
        /// <summary>
        /// Format of the current subtitle<br/>
        /// Example: srt
        /// </summary>
        /// <example>srt</example>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SubtitlesFormatEnumJsonConverter))]
        public global::G.SubtitlesFormatEnum Format { get; set; } = default!;

        /// <summary>
        /// Transcription on the asked subtitle format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitles", Required = global::Newtonsoft.Json.Required.Always)]
        public string Subtitles { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitleDTO" /> class.
        /// </summary>
        /// <param name="format">
        /// Format of the current subtitle<br/>
        /// Example: srt
        /// </param>
        /// <param name="subtitles">
        /// Transcription on the asked subtitle format
        /// </param>
        public SubtitleDTO(
            global::G.SubtitlesFormatEnum format,
            string subtitles)
        {
            this.Format = format;
            this.Subtitles = subtitles ?? throw new global::System.ArgumentNullException(nameof(subtitles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitleDTO" /> class.
        /// </summary>
        public SubtitleDTO()
        {
        }
    }
}