//HintName: G.Models.UpdateAppClientRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an existing OAuth application client's properties.
    /// </summary>
    public sealed partial class UpdateAppClientRequest
    {
        /// <summary>
        /// The new App Client description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The new roles attached to the App Client. These roles will replace the current roles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// The new corpus role assignments. These will replace the current corpus roles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpus_roles")]
        public global::System.Collections.Generic.IList<global::G.CorpusRole>? CorpusRoles { get; set; }

        /// <summary>
        /// The new agent role assignments. These will replace the current agent roles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_roles")]
        public global::System.Collections.Generic.IList<global::G.AgentRole>? AgentRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppClientRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// The new App Client description.
        /// </param>
        /// <param name="apiRoles">
        /// The new roles attached to the App Client. These roles will replace the current roles.
        /// </param>
        /// <param name="corpusRoles">
        /// The new corpus role assignments. These will replace the current corpus roles.
        /// </param>
        /// <param name="agentRoles">
        /// The new agent role assignments. These will replace the current agent roles.
        /// </param>
        public UpdateAppClientRequest(
            string? description,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles,
            global::System.Collections.Generic.IList<global::G.CorpusRole>? corpusRoles,
            global::System.Collections.Generic.IList<global::G.AgentRole>? agentRoles)
        {
            this.Description = description;
            this.ApiRoles = apiRoles;
            this.CorpusRoles = corpusRoles;
            this.AgentRoles = agentRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppClientRequest" /> class.
        /// </summary>
        public UpdateAppClientRequest()
        {
        }
    }
}