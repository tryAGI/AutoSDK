//HintName: G.Models.GetActiveCrawlsResponseCrawl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActiveCrawlsResponseCrawl
    {
        /// <summary>
        /// The unique identifier of the crawl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The ID of the team that owns the crawl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// The origin URL of the crawl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The crawler options used for this crawl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetActiveCrawlsResponseCrawlOptions Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveCrawlsResponseCrawl" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the crawl
        /// </param>
        /// <param name="teamId">
        /// The ID of the team that owns the crawl
        /// </param>
        /// <param name="url">
        /// The origin URL of the crawl
        /// </param>
        /// <param name="options">
        /// The crawler options used for this crawl
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetActiveCrawlsResponseCrawl(
            global::System.Guid id,
            string teamId,
            string url,
            global::G.GetActiveCrawlsResponseCrawlOptions options)
        {
            this.Id = id;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveCrawlsResponseCrawl" /> class.
        /// </summary>
        public GetActiveCrawlsResponseCrawl()
        {
        }
    }
}