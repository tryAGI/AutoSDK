//HintName: G.Models.PageScreenshotNodeWithScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Page screenshot metadata with score
    /// </summary>
    public sealed partial class PageScreenshotNodeWithScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PageScreenshotMetadata Node { get; set; }

        /// <summary>
        /// The score of the screenshot node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Default Value: NodeWithScore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageScreenshotNodeWithScore" /> class.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="score">
        /// The score of the screenshot node
        /// </param>
        /// <param name="className">
        /// Default Value: NodeWithScore
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageScreenshotNodeWithScore(
            global::G.PageScreenshotMetadata node,
            double score,
            string? className)
        {
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
            this.Score = score;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageScreenshotNodeWithScore" /> class.
        /// </summary>
        public PageScreenshotNodeWithScore()
        {
        }
    }
}