//HintName: G.Models.EvaluationRunFinishBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for finishing an evaluation run via REST API.<br/>
    /// This model excludes project_id and evaluation_run_id since they come from the URL path in RESTful endpoints.
    /// </summary>
    public sealed partial class EvaluationRunFinishBody
    {
        /// <summary>
        /// Optional summary dictionary for the evaluation run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public object? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunFinishBody" /> class.
        /// </summary>
        /// <param name="summary">
        /// Optional summary dictionary for the evaluation run
        /// </param>
        public EvaluationRunFinishBody(
            object? summary)
        {
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunFinishBody" /> class.
        /// </summary>
        public EvaluationRunFinishBody()
        {
        }
    }
}