//HintName: G.Models.Sitelink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A sitelink associated with a search result.
    /// </summary>
    public sealed partial class Sitelink
    {
        /// <summary>
        /// Title of the sitelink.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the sitelink.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sitelink" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the sitelink.
        /// </param>
        /// <param name="link">
        /// URL of the sitelink.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sitelink(
            string? title,
            string? link)
        {
            this.Title = title;
            this.Link = link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sitelink" /> class.
        /// </summary>
        public Sitelink()
        {
        }
    }
}