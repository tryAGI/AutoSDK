//HintName: G.Models.DynamicManager.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicManager
    {
        /// <summary>
        /// Default Value: dynamic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManagerAgentId { get; set; }

        /// <summary>
        /// Default Value: DONE!
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_token")]
        public string? TerminationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicManager" /> class.
        /// </summary>
        /// <param name="managerAgentId"></param>
        /// <param name="managerType">
        /// Default Value: dynamic
        /// </param>
        /// <param name="terminationToken">
        /// Default Value: DONE!
        /// </param>
        /// <param name="maxTurns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicManager(
            string managerAgentId,
            string? managerType,
            string? terminationToken,
            int? maxTurns)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId ?? throw new global::System.ArgumentNullException(nameof(managerAgentId));
            this.TerminationToken = terminationToken;
            this.MaxTurns = maxTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicManager" /> class.
        /// </summary>
        public DynamicManager()
        {
        }
    }
}