//HintName: G.Models.LocalRunnerPairRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerPairRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerPairRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        public LocalRunnerPairRequest(
            global::System.Guid projectId)
        {
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerPairRequest" /> class.
        /// </summary>
        public LocalRunnerPairRequest()
        {
        }
    }
}