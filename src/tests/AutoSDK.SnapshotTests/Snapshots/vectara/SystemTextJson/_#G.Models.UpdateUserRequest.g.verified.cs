//HintName: G.Models.UpdateUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an existing user's properties or permissions.
    /// </summary>
    public sealed partial class UpdateUserRequest
    {
        /// <summary>
        /// Indicates whether to enable or disable the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The new customer-level role names of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// New corpus-specific role assignments for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_roles")]
        public global::System.Collections.Generic.IList<global::G.CorpusRole>? CorpusRoles { get; set; }

        /// <summary>
        /// New agent-specific role assignments for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_roles")]
        public global::System.Collections.Generic.IList<global::G.AgentRole>? AgentRoles { get; set; }

        /// <summary>
        /// The description of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates whether to enable or disable the user.
        /// </param>
        /// <param name="apiRoles">
        /// The new customer-level role names of the user.
        /// </param>
        /// <param name="corpusRoles">
        /// New corpus-specific role assignments for the user.
        /// </param>
        /// <param name="agentRoles">
        /// New agent-specific role assignments for the user.
        /// </param>
        /// <param name="description">
        /// The description of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserRequest(
            bool? enabled,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles,
            global::System.Collections.Generic.IList<global::G.CorpusRole>? corpusRoles,
            global::System.Collections.Generic.IList<global::G.AgentRole>? agentRoles,
            string? description)
        {
            this.Enabled = enabled;
            this.ApiRoles = apiRoles;
            this.CorpusRoles = corpusRoles;
            this.AgentRoles = agentRoles;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest" /> class.
        /// </summary>
        public UpdateUserRequest()
        {
        }
    }
}