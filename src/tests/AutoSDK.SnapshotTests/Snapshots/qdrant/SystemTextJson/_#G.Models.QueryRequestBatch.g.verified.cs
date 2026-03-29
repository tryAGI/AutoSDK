//HintName: G.Models.QueryRequestBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRequestBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.QueryRequest> Searches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequestBatch" /> class.
        /// </summary>
        /// <param name="searches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRequestBatch(
            global::System.Collections.Generic.IList<global::G.QueryRequest> searches)
        {
            this.Searches = searches ?? throw new global::System.ArgumentNullException(nameof(searches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequestBatch" /> class.
        /// </summary>
        public QueryRequestBatch()
        {
        }
    }
}