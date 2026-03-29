//HintName: G.Models.SearchAndScrapeRequestScrapeOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for scraping search results<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class SearchAndScrapeRequestScrapeOptions
    {
        /// <summary>
        /// Formats to include in the output<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        public global::System.Collections.Generic.IList<global::G.SearchAndScrapeRequestScrapeOptionsFormat>? Formats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeRequestScrapeOptions" /> class.
        /// </summary>
        /// <param name="formats">
        /// Formats to include in the output<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchAndScrapeRequestScrapeOptions(
            global::System.Collections.Generic.IList<global::G.SearchAndScrapeRequestScrapeOptionsFormat>? formats)
        {
            this.Formats = formats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeRequestScrapeOptions" /> class.
        /// </summary>
        public SearchAndScrapeRequestScrapeOptions()
        {
        }
    }
}