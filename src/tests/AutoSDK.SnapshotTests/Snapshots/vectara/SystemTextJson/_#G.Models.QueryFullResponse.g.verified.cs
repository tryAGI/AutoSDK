//HintName: G.Models.QueryFullResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The full response to a RAG query when the result is not streamed.
    /// </summary>
    public sealed partial class QueryFullResponse
    {
        /// <summary>
        /// The summary of the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LanguageJsonConverter))]
        public global::G.Language? ResponseLanguage { get; set; } = global::G.Language.Auto;

        /// <summary>
        /// The ranked search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// The probability that the summary is factually consistent with the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}