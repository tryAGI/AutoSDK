//HintName: G.Models.FineTuneReinforcementMethod.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the reinforcement fine-tuning method.
    /// </summary>
    public sealed partial class FineTuneReinforcementMethod
    {
        /// <summary>
        /// The grader used for the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grader", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> Grader { get; set; } = default!;

        /// <summary>
        /// The hyperparameters used for the reinforcement fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters")]
        public global::G.FineTuneReinforcementHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneReinforcementMethod" /> class.
        /// </summary>
        /// <param name="grader">
        /// The grader used for the fine-tuning job.
        /// </param>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the reinforcement fine-tuning job.
        /// </param>
        public FineTuneReinforcementMethod(
            global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> grader,
            global::G.FineTuneReinforcementHyperparameters? hyperparameters)
        {
            this.Grader = grader;
            this.Hyperparameters = hyperparameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneReinforcementMethod" /> class.
        /// </summary>
        public FineTuneReinforcementMethod()
        {
        }
    }
}