//HintName: G.Models.SongSourceContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SongSourceContext
    {
        /// <summary>
        /// Default Value: song
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("song_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SongId { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_explicit")]
        public bool? IsExplicit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_settings")]
        public object? GenerationSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SongSourceContext" /> class.
        /// </summary>
        /// <param name="songId"></param>
        /// <param name="sourceType">
        /// Default Value: song
        /// </param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="genres"></param>
        /// <param name="languages"></param>
        /// <param name="isExplicit"></param>
        /// <param name="bpm"></param>
        /// <param name="generationSettings"></param>
        public SongSourceContext(
            string songId,
            string? sourceType,
            string? title,
            string? description,
            global::System.Collections.Generic.IList<string>? genres,
            global::System.Collections.Generic.IList<string>? languages,
            bool? isExplicit,
            int? bpm,
            object? generationSettings)
        {
            this.SourceType = sourceType;
            this.SongId = songId ?? throw new global::System.ArgumentNullException(nameof(songId));
            this.Title = title;
            this.Description = description;
            this.Genres = genres;
            this.Languages = languages;
            this.IsExplicit = isExplicit;
            this.Bpm = bpm;
            this.GenerationSettings = generationSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SongSourceContext" /> class.
        /// </summary>
        public SongSourceContext()
        {
        }
    }
}