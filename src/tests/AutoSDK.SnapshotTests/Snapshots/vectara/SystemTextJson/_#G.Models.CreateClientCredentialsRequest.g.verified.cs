//HintName: G.Models.CreateClientCredentialsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create an App Client which allows you to call Vectara APIs using OAuth 2.0 client credentials.
    /// </summary>
    public sealed partial class CreateClientCredentialsRequest
    {
        /// <summary>
        /// Name of the client credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the client credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This will always be the value `client_credentials`.<br/>
        /// Default Value: client_credentials
        /// </summary>
        /// <default>"client_credentials"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "client_credentials";

        /// <summary>
        /// API roles that the client credentials will have.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// Corpus-specific role assignments for this App Client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_roles")]
        public global::System.Collections.Generic.IList<global::G.CorpusRole>? CorpusRoles { get; set; }

        /// <summary>
        /// Agent-specific role assignments for this App Client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_roles")]
        public global::System.Collections.Generic.IList<global::G.AgentRole>? AgentRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientCredentialsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the client credentials.
        /// </param>
        /// <param name="description">
        /// Description of the client credentials.
        /// </param>
        /// <param name="type">
        /// This will always be the value `client_credentials`.<br/>
        /// Default Value: client_credentials
        /// </param>
        /// <param name="apiRoles">
        /// API roles that the client credentials will have.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific role assignments for this App Client.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific role assignments for this App Client.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClientCredentialsRequest(
            string name,
            string type,
            string? description,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles,
            global::System.Collections.Generic.IList<global::G.CorpusRole>? corpusRoles,
            global::System.Collections.Generic.IList<global::G.AgentRole>? agentRoles)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description;
            this.ApiRoles = apiRoles;
            this.CorpusRoles = corpusRoles;
            this.AgentRoles = agentRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientCredentialsRequest" /> class.
        /// </summary>
        public CreateClientCredentialsRequest()
        {
        }
    }
}