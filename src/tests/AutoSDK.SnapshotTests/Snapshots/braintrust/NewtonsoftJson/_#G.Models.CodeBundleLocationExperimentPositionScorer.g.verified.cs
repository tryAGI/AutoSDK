//HintName: G.Models.CodeBundleLocationExperimentPositionScorer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleLocationExperimentPositionScorer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeBundleLocationExperimentPositionScorerType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperimentPositionScorer" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        public CodeBundleLocationExperimentPositionScorer(
            int index,
            global::G.CodeBundleLocationExperimentPositionScorerType type)
        {
            this.Type = type;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperimentPositionScorer" /> class.
        /// </summary>
        public CodeBundleLocationExperimentPositionScorer()
        {
        }
    }
}