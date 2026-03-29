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
        [global::Newtonsoft.Json.JsonProperty("node", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PageScreenshotMetadata Node { get; set; } = default!;

        /// <summary>
        /// The score of the screenshot node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Default Value: NodeWithScore
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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