//HintName: G.Models.CreateChatCompletionRequestSearchSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings for web search functionality when the model uses a web search tool.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestSearchSettings
    {
        /// <summary>
        /// A list of domains to include in the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// A list of domains to exclude from the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Whether to include images in the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// Name of country to prioritize search results from (e.g., "united states", "germany", "france").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestSearchSettings" /> class.
        /// </summary>
        /// <param name="includeDomains">
        /// A list of domains to include in the search results.
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to exclude from the search results.
        /// </param>
        /// <param name="includeImages">
        /// Whether to include images in the search results.
        /// </param>
        /// <param name="country">
        /// Name of country to prioritize search results from (e.g., "united states", "germany", "france").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestSearchSettings(
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            bool? includeImages,
            string? country)
        {
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.IncludeImages = includeImages;
            this.Country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestSearchSettings" /> class.
        /// </summary>
        public CreateChatCompletionRequestSearchSettings()
        {
        }
    }
}