//HintName: G.Models.SearchParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Echo of the search parameters used for the request.
    /// </summary>
    public sealed partial class SearchParameters
    {
        /// <summary>
        /// The query string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// Country code used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gl")]
        public string? Gl { get; set; }

        /// <summary>
        /// Language code used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hl")]
        public string? Hl { get; set; }

        /// <summary>
        /// Number of results requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        public int? Num { get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Whether autocorrect was enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autocorrect")]
        public bool? Autocorrect { get; set; }

        /// <summary>
        /// The type of search performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParameters" /> class.
        /// </summary>
        /// <param name="q">
        /// The query string.
        /// </param>
        /// <param name="gl">
        /// Country code used.
        /// </param>
        /// <param name="hl">
        /// Language code used.
        /// </param>
        /// <param name="num">
        /// Number of results requested.
        /// </param>
        /// <param name="page">
        /// Page number.
        /// </param>
        /// <param name="autocorrect">
        /// Whether autocorrect was enabled.
        /// </param>
        /// <param name="type">
        /// The type of search performed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchParameters(
            string? q,
            string? gl,
            string? hl,
            int? num,
            int? page,
            bool? autocorrect,
            string? type)
        {
            this.Q = q;
            this.Gl = gl;
            this.Hl = hl;
            this.Num = num;
            this.Page = page;
            this.Autocorrect = autocorrect;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParameters" /> class.
        /// </summary>
        public SearchParameters()
        {
        }
    }
}