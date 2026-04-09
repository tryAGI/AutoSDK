//HintName: G.Models.CodeBundleLocationExperiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleLocationExperiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter))]
        public global::G.CodeBundleLocationExperimentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvalName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CodeBundleLocationExperimentPositionVariant1, global::G.CodeBundleLocationExperimentPositionScorer> Position { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperiment" /> class.
        /// </summary>
        /// <param name="evalName"></param>
        /// <param name="position"></param>
        /// <param name="type"></param>
        public CodeBundleLocationExperiment(
            string evalName,
            global::G.AnyOf<global::G.CodeBundleLocationExperimentPositionVariant1, global::G.CodeBundleLocationExperimentPositionScorer> position,
            global::G.CodeBundleLocationExperimentType type)
        {
            this.Type = type;
            this.EvalName = evalName ?? throw new global::System.ArgumentNullException(nameof(evalName));
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperiment" /> class.
        /// </summary>
        public CodeBundleLocationExperiment()
        {
        }
    }
}