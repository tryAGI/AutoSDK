//HintName: G.Models.QueryConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for a query.
    /// </summary>
    public sealed partial class QueryConfig
    {
        /// <summary>
        /// The encoding to use for vectors in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_encoding")]
        public global::G.VectorEncoding? VectorEncoding { get; set; }

        /// <summary>
        /// The consistency level for a query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consistency")]
        public global::G.QueryConfigConsistency? Consistency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryConfig" /> class.
        /// </summary>
        /// <param name="vectorEncoding">
        /// The encoding to use for vectors in the response.
        /// </param>
        /// <param name="consistency">
        /// The consistency level for a query.
        /// </param>
        public QueryConfig(
            global::G.VectorEncoding? vectorEncoding,
            global::G.QueryConfigConsistency? consistency)
        {
            this.VectorEncoding = vectorEncoding;
            this.Consistency = consistency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryConfig" /> class.
        /// </summary>
        public QueryConfig()
        {
        }
    }
}