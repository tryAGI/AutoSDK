//HintName: G.Models.DeleteMemoriesInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filters for bulk memory deletion. At least one field is required. Pass "*" for a field to delete all memories for that entity type. Set all four to "*" for a full project wipe.
    /// </summary>
    public sealed partial class DeleteMemoriesInput
    {
        /// <summary>
        /// User ID to delete memories for. Pass "*" for all users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Agent ID to delete memories for. Pass "*" for all agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// App ID to delete memories for. Pass "*" for all apps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// Run ID to delete memories for. Pass "*" for all runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemoriesInput" /> class.
        /// </summary>
        /// <param name="userId">
        /// User ID to delete memories for. Pass "*" for all users.
        /// </param>
        /// <param name="agentId">
        /// Agent ID to delete memories for. Pass "*" for all agents.
        /// </param>
        /// <param name="appId">
        /// App ID to delete memories for. Pass "*" for all apps.
        /// </param>
        /// <param name="runId">
        /// Run ID to delete memories for. Pass "*" for all runs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMemoriesInput(
            string? userId,
            string? agentId,
            string? appId,
            string? runId)
        {
            this.UserId = userId;
            this.AgentId = agentId;
            this.AppId = appId;
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemoriesInput" /> class.
        /// </summary>
        public DeleteMemoriesInput()
        {
        }
    }
}