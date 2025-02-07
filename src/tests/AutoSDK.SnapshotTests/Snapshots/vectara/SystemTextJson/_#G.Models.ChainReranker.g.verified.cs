//HintName: G.Models.ChainReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChainReranker
    {
        /// <summary>
        /// When the type is `chain`, you can then chain re-rankers together.<br/>
        /// Default Value: chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Specify an array of rerankers to apply to search results consecutively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerankers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SearchReranker> Rerankers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainReranker" /> class.
        /// </summary>
        /// <param name="type">
        /// When the type is `chain`, you can then chain re-rankers together.<br/>
        /// Default Value: chain
        /// </param>
        /// <param name="rerankers">
        /// Specify an array of rerankers to apply to search results consecutively.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainReranker(
            global::System.Collections.Generic.IList<global::G.SearchReranker> rerankers,
            string? type)
        {
            this.Rerankers = rerankers ?? throw new global::System.ArgumentNullException(nameof(rerankers));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainReranker" /> class.
        /// </summary>
        public ChainReranker()
        {
        }
    }
}