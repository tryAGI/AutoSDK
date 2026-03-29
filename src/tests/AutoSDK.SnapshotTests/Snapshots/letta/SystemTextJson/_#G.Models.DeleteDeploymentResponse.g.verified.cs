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
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_blocks")]
        public global::System.Collections.Generic.IList<string>? DeletedBlocks { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_agents")]
        public global::System.Collections.Generic.IList<string>? DeletedAgents { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_groups")]
        public global::System.Collections.Generic.IList<string>? DeletedGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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