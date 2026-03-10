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
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The description of the song
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The genres of the song
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("genres", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Genres { get; set; } = default!;

        /// <summary>
        /// The languages of the song
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Languages { get; set; } = default!;

        /// <summary>
        /// Whether the song is explicit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_explicit")]
        public bool? IsExplicit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SongMetadata" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the song
        /// </param>
        /// <param name="description">
        /// The description of the song
        /// </param>
        /// <param name="genres">
        /// The genres of the song
        /// </param>
        /// <param name="languages">
        /// The languages of the song
        /// </param>
        /// <param name="isExplicit">
        /// Whether the song is explicit
        /// </param>
        public SongMetadata(
            global::System.Collections.Generic.IList<string> genres,
            global::System.Collections.Generic.IList<string> languages,
            string? title,
            string? description,
            bool? isExplicit)
        {
            this.Genres = genres ?? throw new global::System.ArgumentNullException(nameof(genres));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Title = title;
            this.Description = description;
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