//HintName: G.Models.SamlSettingsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for updating SAML settings (POST requests).
    /// </summary>
    public sealed partial class SamlSettingsUpdateRequest
    {
        /// <summary>
        /// Organization web domain or domains; use comma separated list with no spaces for multiple. Example:labelstud.io,humansignal.comIMPORTANT: DO NOT PUT COMMON DOMAINS LIKE GMAIL.COM, YAHOO.COM, ETC. IN THIS FIELD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Identity Provider preset key (e.g. okta, azure, google, custom)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idp_provider")]
        public string? IdpProvider { get; set; }

        /// <summary>
        /// Mapping attributes: user email from SAML request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mapping_email")]
        public string? MappingEmail { get; set; }

        /// <summary>
        /// Mapping attributes: user first name from SAML request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mapping_first_name")]
        public string? MappingFirstName { get; set; }

        /// <summary>
        /// Mapping attributes: groups attribute for user mapping to workspaces and roles
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mapping_groups")]
        public string? MappingGroups { get; set; }

        /// <summary>
        /// Mapping attributes: user last name from SAML request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mapping_last_name")]
        public string? MappingLastName { get; set; }

        /// <summary>
        /// URL SAML metadata from IdP
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// Metadata XML file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_groups")]
        public global::System.Collections.Generic.IList<global::G.ProjectGroupRequest>? ProjectsGroups { get; set; }

        /// <summary>
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? RolesGroups { get; set; }

        /// <summary>
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? WorkspacesGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamlSettingsUpdateRequest" /> class.
        /// </summary>
        /// <param name="domain">
        /// Organization web domain or domains; use comma separated list with no spaces for multiple. Example:labelstud.io,humansignal.comIMPORTANT: DO NOT PUT COMMON DOMAINS LIKE GMAIL.COM, YAHOO.COM, ETC. IN THIS FIELD
        /// </param>
        /// <param name="idpProvider">
        /// Identity Provider preset key (e.g. okta, azure, google, custom)
        /// </param>
        /// <param name="mappingEmail">
        /// Mapping attributes: user email from SAML request
        /// </param>
        /// <param name="mappingFirstName">
        /// Mapping attributes: user first name from SAML request
        /// </param>
        /// <param name="mappingGroups">
        /// Mapping attributes: groups attribute for user mapping to workspaces and roles
        /// </param>
        /// <param name="mappingLastName">
        /// Mapping attributes: user last name from SAML request
        /// </param>
        /// <param name="metadataUrl">
        /// URL SAML metadata from IdP
        /// </param>
        /// <param name="metadataXml">
        /// Metadata XML file
        /// </param>
        /// <param name="projectsGroups">
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </param>
        /// <param name="rolesGroups">
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </param>
        /// <param name="workspacesGroups">
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </param>
        public SamlSettingsUpdateRequest(
            string? domain,
            string? idpProvider,
            string? mappingEmail,
            string? mappingFirstName,
            string? mappingGroups,
            string? mappingLastName,
            string? metadataUrl,
            string? metadataXml,
            global::System.Collections.Generic.IList<global::G.ProjectGroupRequest>? projectsGroups,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? rolesGroups,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? workspacesGroups)
        {
            this.Domain = domain;
            this.IdpProvider = idpProvider;
            this.MappingEmail = mappingEmail;
            this.MappingFirstName = mappingFirstName;
            this.MappingGroups = mappingGroups;
            this.MappingLastName = mappingLastName;
            this.MetadataUrl = metadataUrl;
            this.MetadataXml = metadataXml;
            this.ProjectsGroups = projectsGroups;
            this.RolesGroups = rolesGroups;
            this.WorkspacesGroups = workspacesGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamlSettingsUpdateRequest" /> class.
        /// </summary>
        public SamlSettingsUpdateRequest()
        {
        }
    }
}