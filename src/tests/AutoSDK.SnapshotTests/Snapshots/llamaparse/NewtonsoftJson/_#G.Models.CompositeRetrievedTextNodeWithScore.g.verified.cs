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
        [global::Newtonsoft.Json.JsonProperty("node", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompositeRetrievedTextNode Node { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Default Value: CompositeRetrievedTextNodeWithScore
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievedTextNodeWithScore" /> class.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="score"></param>
        /// <param name="className">
        /// Default Value: CompositeRetrievedTextNodeWithScore
        /// </param>
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