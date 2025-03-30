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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PodcastURLSourceTypeJsonConverter))]
        public global::G.PodcastURLSourceType Type { get; set; }

        /// <summary>
        /// The URL to create the podcast from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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