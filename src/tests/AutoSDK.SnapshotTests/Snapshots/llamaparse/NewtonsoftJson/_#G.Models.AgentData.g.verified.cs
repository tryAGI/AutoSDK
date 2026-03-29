//HintName: G.Models.AgentData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API Result for a single agent data item
    /// </summary>
    public sealed partial class AgentData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentData" /> class.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="collection">
        /// Default Value: default
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public AgentData(
            string deploymentName,
            object data,
            string? id,
            string? projectId,
            string? collection,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.ProjectId = projectId;
            this.Collection = collection;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentData" /> class.
        /// </summary>
        public AgentData()
        {
        }
    }
}