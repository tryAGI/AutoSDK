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
        [global::Newtonsoft.Json.JsonProperty("fusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Fusion Fusion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionQuery" /> class.
        /// </summary>
        /// <param name="fusion">
        /// Fusion algorithm allows to combine results of multiple prefetches.<br/>
        /// Available fusion algorithms:<br/>
        /// * `rrf` - Reciprocal Rank Fusion (with default parameters) * `dbsf` - Distribution-Based Score Fusion
        /// </param>
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