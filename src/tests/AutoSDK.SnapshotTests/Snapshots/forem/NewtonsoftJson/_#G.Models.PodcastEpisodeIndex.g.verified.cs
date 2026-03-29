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
        [global::Newtonsoft.Json.JsonProperty("type_of", Required = global::Newtonsoft.Json.Required.Always)]
        public string TypeOf { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClassName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Podcast episode image url or podcast image url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageUrl { get; set; } = default!;

        /// <summary>
        /// The podcast that the resource belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("podcast", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SharedPodcast Podcast { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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