//HintName: G.Models.CreateExperimentEvaluatorOldRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentEvaluatorOldRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluatorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentEvaluatorOldRequest" /> class.
        /// </summary>
        /// <param name="evaluatorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExperimentEvaluatorOldRequest(
            string evaluatorId)
        {
            this.EvaluatorId = evaluatorId ?? throw new global::System.ArgumentNullException(nameof(evaluatorId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentEvaluatorOldRequest" /> class.
        /// </summary>
        public CreateExperimentEvaluatorOldRequest()
        {
        }
    }
}