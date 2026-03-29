//HintName: G.Models.DeleteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request body for bulk deleting agent data by query
    /// </summary>
    public sealed partial class DeleteRequest
    {
        /// <summary>
        /// The agent deployment's name to delete data for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentName { get; set; } = default!;

        /// <summary>
        /// The logical agent data collection to delete from<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// Optional filters to select which items to delete
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequest" /> class.
        /// </summary>
        /// <param name="deploymentName">
        /// The agent deployment's name to delete data for
        /// </param>
        /// <param name="collection">
        /// The logical agent data collection to delete from<br/>
        /// Default Value: default
        /// </param>
        /// <param name="filter">
        /// Optional filters to select which items to delete
        /// </param>
        public DeleteRequest(
            string deploymentName,
            string? collection,
            global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? filter)
        {
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.Collection = collection;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequest" /> class.
        /// </summary>
        public DeleteRequest()
        {
        }
    }
}