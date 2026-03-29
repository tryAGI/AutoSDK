//HintName: G.Models.QueryVectorStoreResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryVectorStoreResponse
    {
        /// <summary>
        /// Time taken to execute the query (in milliseconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeTaken")]
        public double? TimeTaken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        public global::System.Collections.Generic.IList<global::G.Document>? Docs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryVectorStoreResponse" /> class.
        /// </summary>
        /// <param name="timeTaken">
        /// Time taken to execute the query (in milliseconds)
        /// </param>
        /// <param name="docs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryVectorStoreResponse(
            double? timeTaken,
            global::System.Collections.Generic.IList<global::G.Document>? docs)
        {
            this.TimeTaken = timeTaken;
            this.Docs = docs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryVectorStoreResponse" /> class.
        /// </summary>
        public QueryVectorStoreResponse()
        {
        }
    }
}