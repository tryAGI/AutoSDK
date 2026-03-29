//HintName: G.Models.EvaluationStatusReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationStatusReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callId"></param>
        public EvaluationStatusReq(
            string projectId,
            string callId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusReq" /> class.
        /// </summary>
        public EvaluationStatusReq()
        {
        }
    }
}