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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelRef { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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