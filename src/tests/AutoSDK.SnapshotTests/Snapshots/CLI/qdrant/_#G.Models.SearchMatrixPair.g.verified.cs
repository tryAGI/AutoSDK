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
        [global::System.Text.Json.Serialization.JsonPropertyName("a")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtendedPointIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtendedPointId A { get; set; }

        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtendedPointIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtendedPointId B { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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