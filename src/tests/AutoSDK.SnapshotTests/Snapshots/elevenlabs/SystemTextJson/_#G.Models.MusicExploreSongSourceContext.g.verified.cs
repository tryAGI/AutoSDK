//HintName: G.Models.MusicExploreSongSourceContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicExploreSongSourceContext
    {
        /// <summary>
        /// Default Value: music_explore_song
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_explore_song_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MusicExploreSongId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vocals")]
        public string? Vocals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicExploreSongSourceContext" /> class.
        /// </summary>
        /// <param name="musicExploreSongId"></param>
        /// <param name="sourceType">
        /// Default Value: music_explore_song
        /// </param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="bpm"></param>
        /// <param name="vocals"></param>
        /// <param name="lyrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicExploreSongSourceContext(
            string musicExploreSongId,
            string? sourceType,
            string? title,
            string? description,
            int? bpm,
            string? vocals,
            string? lyrics)
        {
            this.SourceType = sourceType;
            this.MusicExploreSongId = musicExploreSongId ?? throw new global::System.ArgumentNullException(nameof(musicExploreSongId));
            this.Title = title;
            this.Description = description;
            this.Bpm = bpm;
            this.Vocals = vocals;
            this.Lyrics = lyrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicExploreSongSourceContext" /> class.
        /// </summary>
        public MusicExploreSongSourceContext()
        {
        }
    }
}