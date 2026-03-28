//HintName: G.Models.SongMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}
    /// </summary>
    public sealed partial class SongMetadata
    {
        /// <summary>
        /// The title of the song
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The description of the song
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The genres of the song
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Genres { get; set; }

        /// <summary>
        /// The languages of the song
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Languages { get; set; }

        /// <summary>
        /// Whether the song is explicit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_explicit")]
        public bool? IsExplicit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SongMetadata" /> class.
        /// </summary>
        /// <param name="genres">
        /// The genres of the song
        /// </param>
        /// <param name="languages">
        /// The languages of the song
        /// </param>
        /// <param name="title">
        /// The title of the song
        /// </param>
        /// <param name="description">
        /// The description of the song
        /// </param>
        /// <param name="isExplicit">
        /// Whether the song is explicit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SongMetadata(
            global::System.Collections.Generic.IList<string> genres,
            global::System.Collections.Generic.IList<string> languages,
            string? title,
            string? description,
            bool? isExplicit)
        {
            this.Title = title;
            this.Description = description;
            this.Genres = genres ?? throw new global::System.ArgumentNullException(nameof(genres));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.IsExplicit = isExplicit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SongMetadata" /> class.
        /// </summary>
        public SongMetadata()
        {
        }
    }
}