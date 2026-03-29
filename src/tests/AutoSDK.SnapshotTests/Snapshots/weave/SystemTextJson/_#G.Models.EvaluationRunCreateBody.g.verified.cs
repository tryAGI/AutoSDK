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
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Evaluation { get; set; }

        /// <summary>
        /// Reference to the model (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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