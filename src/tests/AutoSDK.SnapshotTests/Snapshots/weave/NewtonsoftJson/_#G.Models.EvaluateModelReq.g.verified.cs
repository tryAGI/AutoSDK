//HintName: G.Models.EvaluateModelReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluateModelReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvaluationRef { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelRef { get; set; } = default!;

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateModelReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="evaluationRef"></param>
        /// <param name="modelRef"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        public EvaluateModelReq(
            string projectId,
            string evaluationRef,
            string modelRef,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.EvaluationRef = evaluationRef ?? throw new global::System.ArgumentNullException(nameof(evaluationRef));
            this.ModelRef = modelRef ?? throw new global::System.ArgumentNullException(nameof(modelRef));
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateModelReq" /> class.
        /// </summary>
        public EvaluateModelReq()
        {
        }
    }
}