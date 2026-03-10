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
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("music_explore_song_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MusicExploreSongId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vocals")]
        public string? Vocals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicExploreSongSourceContext" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// Default Value: music_explore_song
        /// </param>
        /// <param name="musicExploreSongId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="bpm"></param>
        /// <param name="vocals"></param>
        /// <param name="lyrics"></param>
        public MusicExploreSongSourceContext(
            string musicExploreSongId,
            string? sourceType,
            string? title,
            string? description,
            int? bpm,
            string? vocals,
            string? lyrics)
        {
            this.MusicExploreSongId = musicExploreSongId ?? throw new global::System.ArgumentNullException(nameof(musicExploreSongId));
            this.SourceType = sourceType;
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