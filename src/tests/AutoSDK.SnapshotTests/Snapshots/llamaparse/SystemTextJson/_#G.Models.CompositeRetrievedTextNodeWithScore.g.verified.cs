//HintName: G.Models.CompositeRetrievedTextNodeWithScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositeRetrievedTextNodeWithScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CompositeRetrievedTextNode Node { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Default Value: CompositeRetrievedTextNodeWithScore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievedTextNodeWithScore" /> class.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="score"></param>
        /// <param name="className">
        /// Default Value: CompositeRetrievedTextNodeWithScore
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeRetrievedTextNodeWithScore(
            global::G.CompositeRetrievedTextNode node,
            double? score,
            string? className)
        {
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
            this.Score = score;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievedTextNodeWithScore" /> class.
        /// </summary>
        public CompositeRetrievedTextNodeWithScore()
        {
        }
    }
}