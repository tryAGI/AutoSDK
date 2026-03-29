//HintName: G.Models.DeleteDeploymentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for delete deployment operation.
    /// </summary>
    public sealed partial class DeleteDeploymentResponse
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_blocks")]
        public global::System.Collections.Generic.IList<string>? DeletedBlocks { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_agents")]
        public global::System.Collections.Generic.IList<string>? DeletedAgents { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_groups")]
        public global::System.Collections.Generic.IList<string>? DeletedGroups { get; set; }

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
        /// Initializes a new instance of the <see cref="DeleteDeploymentResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="deletedBlocks">
        /// Default Value: []
        /// </param>
        /// <param name="deletedAgents">
        /// Default Value: []
        /// </param>
        /// <param name="deletedGroups">
        /// Default Value: []
        /// </param>
        public DeleteDeploymentResponse(
            string message,
            global::System.Collections.Generic.IList<string>? deletedBlocks,
            global::System.Collections.Generic.IList<string>? deletedAgents,
            global::System.Collections.Generic.IList<string>? deletedGroups)
        {
            this.DeletedBlocks = deletedBlocks;
            this.DeletedAgents = deletedAgents;
            this.DeletedGroups = deletedGroups;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDeploymentResponse" /> class.
        /// </summary>
        public DeleteDeploymentResponse()
        {
        }
    }
}