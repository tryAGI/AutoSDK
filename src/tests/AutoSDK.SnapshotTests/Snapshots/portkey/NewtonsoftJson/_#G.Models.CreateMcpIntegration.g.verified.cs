//HintName: G.Models.CreateMcpIntegration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only include optional fields (slug, description, configurations) when you have values for them. The example and code samples show required fields plus workspace_id and organisation_id when scoping.
    /// </summary>
    public sealed partial class CreateMcpIntegration
    {
        /// <summary>
        /// Organisation ID (optional; required when using org admin API key without workspace_id)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Workspace ID (optional; to create at workspace level)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Optional slug; must be unique within organisation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Display name of the MCP integration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Auth/config key-value pairs (e.g. headers, client credentials)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configurations")]
        public global::G.CreateMcpIntegrationConfigurations? Configurations { get; set; }

        /// <summary>
        /// MCP server URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateMcpIntegrationAuthType AuthType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateMcpIntegrationTransport Transport { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpIntegration" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the MCP integration
        /// </param>
        /// <param name="url">
        /// MCP server URL
        /// </param>
        /// <param name="authType"></param>
        /// <param name="transport"></param>
        /// <param name="organisationId">
        /// Organisation ID (optional; required when using org admin API key without workspace_id)
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID (optional; to create at workspace level)
        /// </param>
        /// <param name="slug">
        /// Optional slug; must be unique within organisation
        /// </param>
        /// <param name="description"></param>
        /// <param name="configurations">
        /// Auth/config key-value pairs (e.g. headers, client credentials)
        /// </param>
        public CreateMcpIntegration(
            string name,
            string url,
            global::G.CreateMcpIntegrationAuthType authType,
            global::G.CreateMcpIntegrationTransport transport,
            global::System.Guid? organisationId,
            global::System.Guid? workspaceId,
            string? slug,
            string? description,
            global::G.CreateMcpIntegrationConfigurations? configurations)
        {
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.Slug = slug;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Configurations = configurations;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AuthType = authType;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpIntegration" /> class.
        /// </summary>
        public CreateMcpIntegration()
        {
        }
    }
}