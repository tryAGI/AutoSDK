//HintName: G.Models.Bm25ClauseParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional (optional) parameters for a single BM25 query clause.
    /// </summary>
    public sealed partial class Bm25ClauseParams
    {
        /// <summary>
        /// Whether to treat the last token in the query input as a literal prefix.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_as_prefix")]
        public bool? LastAsPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25ClauseParams" /> class.
        /// </summary>
        /// <param name="lastAsPrefix">
        /// Whether to treat the last token in the query input as a literal prefix.
        /// </param>
        public Bm25ClauseParams(
            bool? lastAsPrefix)
        {
            this.LastAsPrefix = lastAsPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25ClauseParams" /> class.
        /// </summary>
        public Bm25ClauseParams()
        {
        }
    }
}