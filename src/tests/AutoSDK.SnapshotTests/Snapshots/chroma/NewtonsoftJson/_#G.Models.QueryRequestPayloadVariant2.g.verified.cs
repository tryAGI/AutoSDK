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
        [global::Newtonsoft.Json.JsonProperty("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public global::System.Collections.Generic.IList<global::G.Include>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_results")]
        public int? NResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_embeddings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> QueryEmbeddings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequestPayloadVariant2" /> class.
        /// </summary>
        /// <param name="queryEmbeddings"></param>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="nResults"></param>
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