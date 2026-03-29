//HintName: G.Models.NearestQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NearestQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nearest")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorInput Nearest { get; set; }

        /// <summary>
        /// Perform MMR (Maximal Marginal Relevance) reranking after search, using the same vector in this query to calculate relevance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mmr")]
        public global::G.Mmr? Mmr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NearestQuery" /> class.
        /// </summary>
        /// <param name="nearest"></param>
        /// <param name="mmr">
        /// Perform MMR (Maximal Marginal Relevance) reranking after search, using the same vector in this query to calculate relevance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NearestQuery(
            global::G.VectorInput nearest,
            global::G.Mmr? mmr)
        {
            this.Nearest = nearest;
            this.Mmr = mmr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NearestQuery" /> class.
        /// </summary>
        public NearestQuery()
        {
        }
    }
}