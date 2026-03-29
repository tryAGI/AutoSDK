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
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorEncodingJsonConverter))]
        public global::G.VectorEncoding? VectorEncoding { get; set; }

        /// <summary>
        /// The consistency level for a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consistency")]
        public global::G.QueryConfigConsistency? Consistency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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