//HintName: G.Models.SSOSettingsUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOSettingsUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workspace_role_id")]
        public global::System.Guid? DefaultWorkspaceRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? DefaultWorkspaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsUpdate" /> class.
        /// </summary>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SSOSettingsUpdate(
            global::System.Guid? defaultWorkspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid>? defaultWorkspaceIds,
            string? metadataUrl,
            string? metadataXml)
        {
            this.DefaultWorkspaceRoleId = defaultWorkspaceRoleId;
            this.DefaultWorkspaceIds = defaultWorkspaceIds;
            this.MetadataUrl = metadataUrl;
            this.MetadataXml = metadataXml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsUpdate" /> class.
        /// </summary>
        public SSOSettingsUpdate()
        {
        }
    }
}