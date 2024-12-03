//HintName: G.Models.AuditLogOrganizationUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to update the organization settings.
    /// </summary>
    public sealed partial class AuditLogOrganizationUpdatedChangesRequested
    {
        /// <summary>
        /// The organization title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The organization description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The organization name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::G.AuditLogOrganizationUpdatedChangesRequestedSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="title">
        /// The organization title.
        /// </param>
        /// <param name="description">
        /// The organization description.
        /// </param>
        /// <param name="name">
        /// The organization name.
        /// </param>
        /// <param name="settings"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogOrganizationUpdatedChangesRequested(
            string? title,
            string? description,
            string? name,
            global::G.AuditLogOrganizationUpdatedChangesRequestedSettings? settings)
        {
            this.Title = title;
            this.Description = description;
            this.Name = name;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogOrganizationUpdatedChangesRequested()
        {
        }
    }
}