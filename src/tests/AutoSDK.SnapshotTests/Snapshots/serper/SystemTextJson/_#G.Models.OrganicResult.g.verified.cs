//HintName: G.Models.OrganicResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single organic search result.
    /// </summary>
    public sealed partial class OrganicResult
    {
        /// <summary>
        /// Title of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Text snippet from the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Position of the result in the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Date associated with the result, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Sitelinks associated with the result, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sitelinks")]
        public global::System.Collections.Generic.IList<global::G.Sitelink>? Sitelinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganicResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the search result.
        /// </param>
        /// <param name="link">
        /// URL of the search result.
        /// </param>
        /// <param name="snippet">
        /// Text snippet from the page.
        /// </param>
        /// <param name="position">
        /// Position of the result in the search results.
        /// </param>
        /// <param name="date">
        /// Date associated with the result, if available.
        /// </param>
        /// <param name="sitelinks">
        /// Sitelinks associated with the result, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganicResult(
            string? title,
            string? link,
            string? snippet,
            int? position,
            string? date,
            global::System.Collections.Generic.IList<global::G.Sitelink>? sitelinks)
        {
            this.Title = title;
            this.Link = link;
            this.Snippet = snippet;
            this.Position = position;
            this.Date = date;
            this.Sitelinks = sitelinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganicResult" /> class.
        /// </summary>
        public OrganicResult()
        {
        }
    }
}