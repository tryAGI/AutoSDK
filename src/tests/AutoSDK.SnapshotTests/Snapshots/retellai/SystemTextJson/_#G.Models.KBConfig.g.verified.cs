//HintName: G.Models.KBConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KBConfig
    {
        /// <summary>
        /// Max number of knowledge base chunks to retrieve<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Similarity threshold for filtering search results<br/>
        /// Example: 0.6
        /// </summary>
        /// <example>0.6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_score")]
        public double? FilterScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KBConfig" /> class.
        /// </summary>
        /// <param name="topK">
        /// Max number of knowledge base chunks to retrieve<br/>
        /// Example: 3
        /// </param>
        /// <param name="filterScore">
        /// Similarity threshold for filtering search results<br/>
        /// Example: 0.6
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KBConfig(
            int? topK,
            double? filterScore)
        {
            this.TopK = topK;
            this.FilterScore = filterScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KBConfig" /> class.
        /// </summary>
        public KBConfig()
        {
        }
    }
}