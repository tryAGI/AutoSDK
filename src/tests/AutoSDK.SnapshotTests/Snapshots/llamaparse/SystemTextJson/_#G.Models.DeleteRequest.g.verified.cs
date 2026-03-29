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
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// The logical agent data collection to delete from<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// Optional filters to select which items to delete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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