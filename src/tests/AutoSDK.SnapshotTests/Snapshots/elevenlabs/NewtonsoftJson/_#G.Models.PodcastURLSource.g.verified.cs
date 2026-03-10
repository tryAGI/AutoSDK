//HintName: G.Models.PodcastURLSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"type":"url","url":"https://www.example.com"}
    /// </summary>
    public sealed partial class PodcastURLSource
    {
        /// <summary>
        /// The type of source to create.
        /// </summary>
        /// <default>"url"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "url";

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
            string type = "url")
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