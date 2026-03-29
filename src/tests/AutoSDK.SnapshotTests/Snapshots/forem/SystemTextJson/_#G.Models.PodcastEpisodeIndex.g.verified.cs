//HintName: G.Models.PodcastEpisodeIndex.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a podcast episode returned in a list
    /// </summary>
    public sealed partial class PodcastEpisodeIndex
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Podcast episode image url or podcast image url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// The podcast that the resource belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podcast")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SharedPodcast Podcast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisodeIndex" /> class.
        /// </summary>
        /// <param name="typeOf"></param>
        /// <param name="id"></param>
        /// <param name="className"></param>
        /// <param name="path"></param>
        /// <param name="title"></param>
        /// <param name="imageUrl">
        /// Podcast episode image url or podcast image url
        /// </param>
        /// <param name="podcast">
        /// The podcast that the resource belongs to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PodcastEpisodeIndex(
            string typeOf,
            int id,
            string className,
            string path,
            string title,
            string imageUrl,
            global::G.SharedPodcast podcast)
        {
            this.TypeOf = typeOf ?? throw new global::System.ArgumentNullException(nameof(typeOf));
            this.Id = id;
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Podcast = podcast ?? throw new global::System.ArgumentNullException(nameof(podcast));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisodeIndex" /> class.
        /// </summary>
        public PodcastEpisodeIndex()
        {
        }
    }
}