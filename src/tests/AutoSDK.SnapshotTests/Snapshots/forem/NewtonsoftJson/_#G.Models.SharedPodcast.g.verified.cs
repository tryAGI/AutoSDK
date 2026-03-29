//HintName: G.Models.SharedPodcast.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The podcast that the resource belongs to
    /// </summary>
    public sealed partial class SharedPodcast
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Podcast image url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedPodcast" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="slug"></param>
        /// <param name="imageUrl">
        /// Podcast image url
        /// </param>
        public SharedPodcast(
            string? title,
            string? slug,
            string? imageUrl)
        {
            this.Title = title;
            this.Slug = slug;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedPodcast" /> class.
        /// </summary>
        public SharedPodcast()
        {
        }
    }
}