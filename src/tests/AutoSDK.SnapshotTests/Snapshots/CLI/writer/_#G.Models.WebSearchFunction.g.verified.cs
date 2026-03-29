//HintName: G.Models.WebSearchFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses web search to find information.
    /// </summary>
    public sealed partial class WebSearchFunction
    {
        /// <summary>
        /// An array of domains to exclude from the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExcludeDomains { get; set; }

        /// <summary>
        /// An array of domains to include in the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IncludeDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchFunction" /> class.
        /// </summary>
        /// <param name="excludeDomains">
        /// An array of domains to exclude from the search results.
        /// </param>
        /// <param name="includeDomains">
        /// An array of domains to include in the search results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchFunction(
            global::System.Collections.Generic.IList<string> excludeDomains,
            global::System.Collections.Generic.IList<string> includeDomains)
        {
            this.ExcludeDomains = excludeDomains ?? throw new global::System.ArgumentNullException(nameof(excludeDomains));
            this.IncludeDomains = includeDomains ?? throw new global::System.ArgumentNullException(nameof(includeDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchFunction" /> class.
        /// </summary>
        public WebSearchFunction()
        {
        }
    }
}