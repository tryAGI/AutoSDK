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
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubtitlesFormatEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubtitlesFormatEnum Format { get; set; }

        /// <summary>
        /// Transcription on the asked subtitle format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subtitles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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