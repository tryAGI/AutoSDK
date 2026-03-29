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
        [global::Newtonsoft.Json.JsonProperty("pairs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchMatrixPair> Pairs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixPairsResponse" /> class.
        /// </summary>
        /// <param name="pairs">
        /// List of pairs of points with scores
        /// </param>
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