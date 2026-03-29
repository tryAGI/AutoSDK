//HintName: G.Models.CostPurgeReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostPurgeReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Query Query { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostPurgeReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        public CostPurgeReq(
            string projectId,
            global::G.Query query)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostPurgeReq" /> class.
        /// </summary>
        public CostPurgeReq()
        {
        }
    }
}