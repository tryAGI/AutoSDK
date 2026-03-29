//HintName: G.Models.CreateExperimentEvaluatorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorId", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvaluatorId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="evaluatorId"></param>
        public CreateExperimentEvaluatorRequest(
            string evaluatorId)
        {
            this.EvaluatorId = evaluatorId ?? throw new global::System.ArgumentNullException(nameof(evaluatorId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentEvaluatorRequest" /> class.
        /// </summary>
        public CreateExperimentEvaluatorRequest()
        {
        }
    }
}