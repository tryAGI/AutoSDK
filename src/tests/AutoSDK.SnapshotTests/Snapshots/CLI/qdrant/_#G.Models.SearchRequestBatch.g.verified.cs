//HintName: G.Models.SearchRequestBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SearchRequest> Searches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestBatch" /> class.
        /// </summary>
        /// <param name="searches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestBatch(
            global::System.Collections.Generic.IList<global::G.SearchRequest> searches)
        {
            this.Searches = searches ?? throw new global::System.ArgumentNullException(nameof(searches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestBatch" /> class.
        /// </summary>
        public SearchRequestBatch()
        {
        }
    }
}