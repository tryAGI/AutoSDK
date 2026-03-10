//HintName: G.Models.SectionSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SectionSource
    {
        /// <summary>
        /// The ID of the song to source the section from. You can find the song ID in the response headers when you generate a song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SongId { get; set; }

        /// <summary>
        /// The range to extract from the source song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimeRange Range { get; set; }

        /// <summary>
        /// The ranges to exclude from the 'range'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_ranges")]
        public global::System.Collections.Generic.IList<global::G.TimeRange>? NegativeRanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionSource" /> class.
        /// </summary>
        /// <param name="songId">
        /// The ID of the song to source the section from. You can find the song ID in the response headers when you generate a song.
        /// </param>
        /// <param name="range">
        /// The range to extract from the source song.
        /// </param>
        /// <param name="negativeRanges">
        /// The ranges to exclude from the 'range'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SectionSource(
            string songId,
            global::G.TimeRange range,
            global::System.Collections.Generic.IList<global::G.TimeRange>? negativeRanges)
        {
            this.SongId = songId ?? throw new global::System.ArgumentNullException(nameof(songId));
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
            this.NegativeRanges = negativeRanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionSource" /> class.
        /// </summary>
        public SectionSource()
        {
        }
    }
}