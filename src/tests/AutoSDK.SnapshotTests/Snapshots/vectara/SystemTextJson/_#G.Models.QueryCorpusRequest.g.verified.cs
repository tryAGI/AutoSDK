//HintName: G.Models.QueryCorpusRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryCorpusRequest
    {
        /// <summary>
        /// The search query string, which is the question the user is asking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The parameters to search one corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory2))]
        public global::G.AllOf<global::G.SearchCorpus, global::G.SearchParameters>? Search { get; set; }

        /// <summary>
        /// The parameters to control generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::G.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCorpusRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.
        /// </param>
        /// <param name="search">
        /// The parameters to search one corpus.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public QueryCorpusRequest(
            string query,
            global::G.AllOf<global::G.SearchCorpus, global::G.SearchParameters>? search,
            global::G.GenerationParameters? generation,
            bool? streamResponse)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Search = search;
            this.Generation = generation;
            this.StreamResponse = streamResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCorpusRequest" /> class.
        /// </summary>
        public QueryCorpusRequest()
        {
        }
    }
}