//HintName: G.Models.PageFigureNodeWithScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Page figure metadata with score
    /// </summary>
    public sealed partial class PageFigureNodeWithScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PageFigureMetadata Node { get; set; }

        /// <summary>
        /// The score of the figure node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Default Value: PageFigureNodeWithScore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageFigureNodeWithScore" /> class.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="score">
        /// The score of the figure node
        /// </param>
        /// <param name="className">
        /// Default Value: PageFigureNodeWithScore
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageFigureNodeWithScore(
            global::G.PageFigureMetadata node,
            double score,
            string? className)
        {
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
            this.Score = score;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageFigureNodeWithScore" /> class.
        /// </summary>
        public PageFigureNodeWithScore()
        {
        }
    }
}