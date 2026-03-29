//HintName: G.Models.FusionQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FusionQuery
    {
        /// <summary>
        /// Fusion algorithm allows to combine results of multiple prefetches.<br/>
        /// Available fusion algorithms:<br/>
        /// * `rrf` - Reciprocal Rank Fusion (with default parameters) * `dbsf` - Distribution-Based Score Fusion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Fusion Fusion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionQuery" /> class.
        /// </summary>
        /// <param name="fusion">
        /// Fusion algorithm allows to combine results of multiple prefetches.<br/>
        /// Available fusion algorithms:<br/>
        /// * `rrf` - Reciprocal Rank Fusion (with default parameters) * `dbsf` - Distribution-Based Score Fusion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionQuery(
            global::G.Fusion fusion)
        {
            this.Fusion = fusion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionQuery" /> class.
        /// </summary>
        public FusionQuery()
        {
        }
    }
}