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
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SongId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_explicit")]
        public bool? IsExplicit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_settings")]
        public object? GenerationSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SongSourceContext" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// Default Value: song
        /// </param>
        /// <param name="songId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="genres"></param>
        /// <param name="languages"></param>
        /// <param name="isExplicit"></param>
        /// <param name="bpm"></param>
        /// <param name="generationSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.SongId = songId ?? throw new global::System.ArgumentNullException(nameof(songId));
            this.SourceType = sourceType;
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