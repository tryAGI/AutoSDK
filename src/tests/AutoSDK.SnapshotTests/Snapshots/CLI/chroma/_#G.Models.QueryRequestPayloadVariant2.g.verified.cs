//HintName: G.Models.QueryRequestPayloadVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRequestPayloadVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::G.Include>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_results")]
        public int? NResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_embeddings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> QueryEmbeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequestPayloadVariant2" /> class.
        /// </summary>
        /// <param name="queryEmbeddings"></param>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="nResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRequestPayloadVariant2(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> queryEmbeddings,
            global::System.Collections.Generic.IList<string>? ids,
            global::System.Collections.Generic.IList<global::G.Include>? include,
            int? nResults)
        {
            this.Ids = ids;
            this.Include = include;
            this.NResults = nResults;
            this.QueryEmbeddings = queryEmbeddings ?? throw new global::System.ArgumentNullException(nameof(queryEmbeddings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequestPayloadVariant2" /> class.
        /// </summary>
        public QueryRequestPayloadVariant2()
        {
        }
    }
}