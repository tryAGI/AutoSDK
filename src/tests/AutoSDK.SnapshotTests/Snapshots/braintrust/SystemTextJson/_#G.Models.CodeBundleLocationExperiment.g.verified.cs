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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter))]
        public global::G.CodeBundleLocationExperimentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CodeBundleLocationExperimentPositionVariant1, global::G.CodeBundleLocationExperimentPositionScorer>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CodeBundleLocationExperimentPositionVariant1, global::G.CodeBundleLocationExperimentPositionScorer> Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperiment" /> class.
        /// </summary>
        /// <param name="evalName"></param>
        /// <param name="position"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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