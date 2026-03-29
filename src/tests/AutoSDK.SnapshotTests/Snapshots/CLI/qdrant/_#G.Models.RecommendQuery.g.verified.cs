//HintName: G.Models.RecommendQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecommendInput Recommend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendQuery" /> class.
        /// </summary>
        /// <param name="recommend"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendQuery(
            global::G.RecommendInput recommend)
        {
            this.Recommend = recommend ?? throw new global::System.ArgumentNullException(nameof(recommend));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendQuery" /> class.
        /// </summary>
        public RecommendQuery()
        {
        }
    }
}