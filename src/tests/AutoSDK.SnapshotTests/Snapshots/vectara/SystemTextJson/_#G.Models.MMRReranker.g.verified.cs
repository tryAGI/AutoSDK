//HintName: G.Models.MMRReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MMRReranker
    {
        /// <summary>
        /// When the type is `mmr`, you can specify the `diversity_bias`, and the<br/>
        /// the retrieval engine will use the MMR reranker.<br/>
        /// Default Value: mmr
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "mmr";

        /// <summary>
        /// The diversity bias. Higher values indicate more diversity.<br/>
        /// Example: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diversity_bias")]
        public float? DiversityBias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}