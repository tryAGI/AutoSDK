//HintName: G.Models.ScholarResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single Google Scholar search result.
    /// </summary>
    public sealed partial class ScholarResult
    {
        /// <summary>
        /// Title of the academic paper.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the paper.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Abstract or snippet from the paper.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Publication year.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("year")]
        public string? Year { get; set; }

        /// <summary>
        /// Publication venue and author information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicationInfo")]
        public string? PublicationInfo { get; set; }

        /// <summary>
        /// Citation information for a scholar result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citedBy")]
        public global::G.CitedBy? CitedBy { get; set; }

        /// <summary>
        /// Position of the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScholarResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the academic paper.
        /// </param>
        /// <param name="link">
        /// URL of the paper.
        /// </param>
        /// <param name="snippet">
        /// Abstract or snippet from the paper.
        /// </param>
        /// <param name="year">
        /// Publication year.
        /// </param>
        /// <param name="publicationInfo">
        /// Publication venue and author information.
        /// </param>
        /// <param name="citedBy">
        /// Citation information for a scholar result.
        /// </param>
        /// <param name="position">
        /// Position of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScholarResult(
            string? title,
            string? link,
            string? snippet,
            string? year,
            string? publicationInfo,
            global::G.CitedBy? citedBy,
            int? position)
        {
            this.Title = title;
            this.Link = link;
            this.Snippet = snippet;
            this.Year = year;
            this.PublicationInfo = publicationInfo;
            this.CitedBy = citedBy;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScholarResult" /> class.
        /// </summary>
        public ScholarResult()
        {
        }
    }
}