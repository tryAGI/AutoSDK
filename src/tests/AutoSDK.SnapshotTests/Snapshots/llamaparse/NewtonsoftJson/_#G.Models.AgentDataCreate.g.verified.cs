//HintName: G.Models.AgentDataCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request model for creating agent data
    /// </summary>
    public sealed partial class AgentDataCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentName { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDataCreate" /> class.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="data"></param>
        /// <param name="collection">
        /// Default Value: default
        /// </param>
        public AgentDataCreate(
            string deploymentName,
            object data,
            string? collection)
        {
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.Collection = collection;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDataCreate" /> class.
        /// </summary>
        public AgentDataCreate()
        {
        }
    }
}