//HintName: G.Models.ListDeploymentEntitiesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for listing deployment entities.
    /// </summary>
    public sealed partial class ListDeploymentEntitiesResponse
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entities")]
        public global::System.Collections.Generic.IList<global::G.DeploymentEntity>? Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentEntitiesResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="deploymentId"></param>
        /// <param name="message"></param>
        /// <param name="entities">
        /// Default Value: []
        /// </param>
        public ListDeploymentEntitiesResponse(
            int totalCount,
            string deploymentId,
            string message,
            global::System.Collections.Generic.IList<global::G.DeploymentEntity>? entities)
        {
            this.Entities = entities;
            this.TotalCount = totalCount;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentEntitiesResponse" /> class.
        /// </summary>
        public ListDeploymentEntitiesResponse()
        {
        }
    }
}