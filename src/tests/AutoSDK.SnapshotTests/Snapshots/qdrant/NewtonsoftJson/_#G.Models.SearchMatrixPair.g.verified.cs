//HintName: G.Models.SearchMatrixPair.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pair of points (a, b) with score
    /// </summary>
    public sealed partial class SearchMatrixPair
    {
        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("a", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtendedPointId A { get; set; } = default!;

        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtendedPointId B { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public float Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixPair" /> class.
        /// </summary>
        /// <param name="a">
        /// Type, used for specifying point ID in user interface
        /// </param>
        /// <param name="b">
        /// Type, used for specifying point ID in user interface
        /// </param>
        /// <param name="score"></param>
        public SearchMatrixPair(
            global::G.ExtendedPointId a,
            global::G.ExtendedPointId b,
            float score)
        {
            this.A = a;
            this.B = b;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixPair" /> class.
        /// </summary>
        public SearchMatrixPair()
        {
        }
    }
}