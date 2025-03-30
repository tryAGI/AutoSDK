//HintName: G.Models.ChatFullResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Full response to a chat question when the result is not streamed.
    /// </summary>
    public sealed partial class ChatFullResponse
    {
        /// <summary>
        /// If the chat response was stored, the ID of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// If the chat response was stored, the ID of the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// The message from the chat model for the chat message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LanguageJsonConverter))]
        public global::G.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The ranked search results that the chat model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Indicates the probability that the summary is factually consistent with the results.<br/>
        /// The system excludes this property if it encounters excessively large outputs or search<br/>
        /// results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// Non-fatal warnings that occurred during request processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::G.QueryWarning>? Warnings { get; set; }

        /// <summary>
        /// View the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rephrased_query")]
        public string? RephrasedQuery { get; set; }

        /// <summary>
        /// The rewritten queries for the corpora that were searched. Only populated when <br/>
        /// intelligent_query_rewriting is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewritten_queries")]
        public global::System.Collections.Generic.IList<global::G.RewrittenQuery>? RewrittenQueries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFullResponse" /> class.
        /// </summary>
        /// <param name="chatId">
        /// If the chat response was stored, the ID of the chat.
        /// </param>
        /// <param name="turnId">
        /// If the chat response was stored, the ID of the turn.
        /// </param>
        /// <param name="answer">
        /// The message from the chat model for the chat message.
        /// </param>
        /// <param name="responseLanguage">
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="searchResults">
        /// The ranked search results that the chat model used.
        /// </param>
        /// <param name="factualConsistencyScore">
        /// Indicates the probability that the summary is factually consistent with the results.<br/>
        /// The system excludes this property if it encounters excessively large outputs or search<br/>
        /// results.
        /// </param>
        /// <param name="renderedPrompt">
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates. 
        /// </param>
        /// <param name="warnings">
        /// Non-fatal warnings that occurred during request processing
        /// </param>
        /// <param name="rephrasedQuery">
        /// View the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </param>
        /// <param name="rewrittenQueries">
        /// The rewritten queries for the corpora that were searched. Only populated when <br/>
        /// intelligent_query_rewriting is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFullResponse(
            string? chatId,
            string? turnId,
            string? answer,
            global::G.Language? responseLanguage,
            global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? searchResults,
            float? factualConsistencyScore,
            string? renderedPrompt,
            global::System.Collections.Generic.IList<global::G.QueryWarning>? warnings,
            string? rephrasedQuery,
            global::System.Collections.Generic.IList<global::G.RewrittenQuery>? rewrittenQueries)
        {
            this.ChatId = chatId;
            this.TurnId = turnId;
            this.Answer = answer;
            this.ResponseLanguage = responseLanguage;
            this.SearchResults = searchResults;
            this.FactualConsistencyScore = factualConsistencyScore;
            this.RenderedPrompt = renderedPrompt;
            this.Warnings = warnings;
            this.RephrasedQuery = rephrasedQuery;
            this.RewrittenQueries = rewrittenQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFullResponse" /> class.
        /// </summary>
        public ChatFullResponse()
        {
        }
    }
}