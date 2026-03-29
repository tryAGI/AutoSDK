//HintName: G.Models.RerankResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponse200
    {
        /// <summary>
        /// Unique ID for the rerank response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (list).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the rerank response was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The rerank model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of rankings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.RerankPostResponsesContentApplicationJsonSchemaResultsItems>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the rerank response.
        /// </param>
        /// <param name="object">
        /// Type of object (list).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the rerank response was created.
        /// </param>
        /// <param name="model">
        /// The rerank model used.
        /// </param>
        /// <param name="results">
        /// The set of rankings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResponse200(
            string? id,
            string? @object,
            int? created,
            string? model,
            global::System.Collections.Generic.IList<global::G.RerankPostResponsesContentApplicationJsonSchemaResultsItems>? results)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse200" /> class.
        /// </summary>
        public RerankResponse200()
        {
        }
    }
}