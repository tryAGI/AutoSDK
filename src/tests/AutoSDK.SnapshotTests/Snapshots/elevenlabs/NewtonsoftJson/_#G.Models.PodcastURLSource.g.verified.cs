//HintName: G.Models.PodcastURLSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastURLSource
    {
        /// <summary>
        /// The type of source to create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PodcastURLSourceType Type { get; set; }

        /// <summary>
        /// The URL to create the podcast from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastURLSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of source to create.
        /// </param>
        /// <param name="url">
        /// The URL to create the podcast from.
        /// </param>
        public PodcastURLSource(
            string url,
            global::G.PodcastURLSourceType type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastURLSource" /> class.
        /// </summary>
        public PodcastURLSource()
        {
        }
    }
}