//HintName: G.Models.RankAPIInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the API for text embedding. OpenAI compatible
    /// </summary>
    public sealed partial class RankAPIInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-reranker-v2-base-multilingual`,	278M<br/>
        /// - `jina-reranker-v1-base-en`,	137M<br/>
        /// - `jina-reranker-v1-tiny-en`,	33M<br/>
        /// - `jina-reranker-v1-turbo-en`,	38M<br/>
        /// - `jina-colbert-v1-en`,	137M
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::G.ApiSchemasRankTextDoc> Query { get; set; }

        /// <summary>
        /// A list of text documents or strings to rerank. If a document is provided the text fields is required and all other fields will be preserved in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.ApiSchemasRankTextDoc>> Documents { get; set; }

        /// <summary>
        /// The number of most relevant documents or indices to return, defaults to the length of `documents`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request. If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request. Defaults to true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankAPIInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-reranker-v2-base-multilingual`,	278M<br/>
        /// - `jina-reranker-v1-base-en`,	137M<br/>
        /// - `jina-reranker-v1-tiny-en`,	33M<br/>
        /// - `jina-reranker-v1-turbo-en`,	38M<br/>
        /// - `jina-colbert-v1-en`,	137M
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="documents">
        /// A list of text documents or strings to rerank. If a document is provided the text fields is required and all other fields will be preserved in the response.
        /// </param>
        /// <param name="topN">
        /// The number of most relevant documents or indices to return, defaults to the length of `documents`
        /// </param>
        /// <param name="returnDocuments">
        /// If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request. If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request. Defaults to true<br/>
        /// Default Value: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RankAPIInput(
            string model,
            global::G.AnyOf<string, global::G.ApiSchemasRankTextDoc> query,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.ApiSchemasRankTextDoc>> documents,
            int? topN,
            bool? returnDocuments)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query;
            this.Documents = documents;
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankAPIInput" /> class.
        /// </summary>
        public RankAPIInput()
        {
        }
    }
}