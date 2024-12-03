//HintName: G.Models.SSOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProviderId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_workspace_role_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DefaultWorkspaceRoleId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_workspace_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> DefaultWorkspaceIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOProvider" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="providerId"></param>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
        public SSOProvider(
            global::System.Guid id,
            global::System.Guid organizationId,
            global::System.Guid providerId,
            global::System.Guid defaultWorkspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid> defaultWorkspaceIds,
            string? metadataUrl,
            string? metadataXml)
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.ProviderId = providerId;
            this.DefaultWorkspaceRoleId = defaultWorkspaceRoleId;
            this.DefaultWorkspaceIds = defaultWorkspaceIds ?? throw new global::System.ArgumentNullException(nameof(defaultWorkspaceIds));
            this.MetadataUrl = metadataUrl;
            this.MetadataXml = metadataXml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOProvider" /> class.
        /// </summary>
        public SSOProvider()
        {
        }
    }
}