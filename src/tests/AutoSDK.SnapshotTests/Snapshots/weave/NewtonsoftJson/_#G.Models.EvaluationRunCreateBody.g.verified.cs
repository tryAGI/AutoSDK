//HintName: G.Models.EvaluationRunCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRunCreateBody
    {
        /// <summary>
        /// Reference to the evaluation (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation", Required = global::Newtonsoft.Json.Required.Always)]
        public string Evaluation { get; set; } = default!;

        /// <summary>
        /// Reference to the model (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunCreateBody" /> class.
        /// </summary>
        /// <param name="evaluation">
        /// Reference to the evaluation (weave:// URI)
        /// </param>
        /// <param name="model">
        /// Reference to the model (weave:// URI)
        /// </param>
        public EvaluationRunCreateBody(
            string evaluation,
            string model)
        {
            this.Evaluation = evaluation ?? throw new global::System.ArgumentNullException(nameof(evaluation));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunCreateBody" /> class.
        /// </summary>
        public EvaluationRunCreateBody()
        {
        }
    }
}