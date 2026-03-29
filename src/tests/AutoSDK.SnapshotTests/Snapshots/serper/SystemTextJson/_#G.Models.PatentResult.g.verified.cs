//HintName: G.Models.PatentResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single patent search result.
    /// </summary>
    public sealed partial class PatentResult
    {
        /// <summary>
        /// Title of the patent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the patent page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Abstract or snippet from the patent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Patent identifier (e.g., "US10123456B2").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patentId")]
        public string? PatentId { get; set; }

        /// <summary>
        /// Filing date of the patent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filingDate")]
        public string? FilingDate { get; set; }

        /// <summary>
        /// Grant date of the patent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantDate")]
        public string? GrantDate { get; set; }

        /// <summary>
        /// Inventor name(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inventor")]
        public string? Inventor { get; set; }

        /// <summary>
        /// Patent assignee/owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public string? Assignee { get; set; }

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
        /// Initializes a new instance of the <see cref="PatentResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the patent.
        /// </param>
        /// <param name="link">
        /// URL of the patent page.
        /// </param>
        /// <param name="snippet">
        /// Abstract or snippet from the patent.
        /// </param>
        /// <param name="patentId">
        /// Patent identifier (e.g., "US10123456B2").
        /// </param>
        /// <param name="filingDate">
        /// Filing date of the patent.
        /// </param>
        /// <param name="grantDate">
        /// Grant date of the patent.
        /// </param>
        /// <param name="inventor">
        /// Inventor name(s).
        /// </param>
        /// <param name="assignee">
        /// Patent assignee/owner.
        /// </param>
        /// <param name="position">
        /// Position of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatentResult(
            string? title,
            string? link,
            string? snippet,
            string? patentId,
            string? filingDate,
            string? grantDate,
            string? inventor,
            string? assignee,
            int? position)
        {
            this.Title = title;
            this.Link = link;
            this.Snippet = snippet;
            this.PatentId = patentId;
            this.FilingDate = filingDate;
            this.GrantDate = grantDate;
            this.Inventor = inventor;
            this.Assignee = assignee;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatentResult" /> class.
        /// </summary>
        public PatentResult()
        {
        }
    }
}