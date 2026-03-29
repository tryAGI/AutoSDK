//HintName: G.Models.SearchMatrixPairsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMatrixPairsResponse
    {
        /// <summary>
        /// List of pairs of points with scores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pairs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SearchMatrixPair> Pairs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixPairsResponse" /> class.
        /// </summary>
        /// <param name="pairs">
        /// List of pairs of points with scores
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMatrixPairsResponse(
            global::System.Collections.Generic.IList<global::G.SearchMatrixPair> pairs)
        {
            this.Pairs = pairs ?? throw new global::System.ArgumentNullException(nameof(pairs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixPairsResponse" /> class.
        /// </summary>
        public SearchMatrixPairsResponse()
        {
        }
    }
}