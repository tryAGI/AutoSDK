//HintName: G.Models.SearchTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Different types of search that can be enabled on the GoogleSearch tool.
    /// </summary>
    public sealed partial class SearchTypes
    {
        /// <summary>
        /// Standard web search for grounding and related configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webSearch")]
        public global::G.WebSearch? WebSearch { get; set; }

        /// <summary>
        /// Image search for grounding and related configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageSearch")]
        public global::G.ImageSearch? ImageSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTypes" /> class.
        /// </summary>
        /// <param name="webSearch">
        /// Standard web search for grounding and related configurations.
        /// </param>
        /// <param name="imageSearch">
        /// Image search for grounding and related configurations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTypes(
            global::G.WebSearch? webSearch,
            global::G.ImageSearch? imageSearch)
        {
            this.WebSearch = webSearch;
            this.ImageSearch = imageSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTypes" /> class.
        /// </summary>
        public SearchTypes()
        {
        }
    }
}