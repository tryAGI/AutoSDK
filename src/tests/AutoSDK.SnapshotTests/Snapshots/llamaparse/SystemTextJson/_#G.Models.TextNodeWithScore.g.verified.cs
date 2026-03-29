//HintName: G.Models.TextNodeWithScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Same as NodeWithScore but type for node is a TextNode instead of BaseNode.<br/>
    /// FastAPI doesn't accept abstract classes like BaseNode.
    /// </summary>
    public sealed partial class TextNodeWithScore
    {
        /// <summary>
        /// Provided for backward compatibility.<br/>
        /// Note: we keep the field with the typo "seperator" to maintain backward compatibility for<br/>
        /// serialized objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TextNode Node { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Default Value: TextNodeWithScore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextNodeWithScore" /> class.
        /// </summary>
        /// <param name="node">
        /// Provided for backward compatibility.<br/>
        /// Note: we keep the field with the typo "seperator" to maintain backward compatibility for<br/>
        /// serialized objects.
        /// </param>
        /// <param name="score"></param>
        /// <param name="className">
        /// Default Value: TextNodeWithScore
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextNodeWithScore(
            global::G.TextNode node,
            double? score,
            string? className)
        {
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
            this.Score = score;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextNodeWithScore" /> class.
        /// </summary>
        public TextNodeWithScore()
        {
        }
    }
}