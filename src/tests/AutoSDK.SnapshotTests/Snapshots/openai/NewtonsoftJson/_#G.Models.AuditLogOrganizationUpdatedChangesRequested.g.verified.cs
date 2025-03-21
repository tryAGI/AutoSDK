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
        /// The organization description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The organization name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public global::G.AuditLogOrganizationUpdatedChangesRequestedSettings? Settings { get; set; }

        /// <summary>
        /// The organization title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="description">
        /// The organization description.
        /// </param>
        /// <param name="name">
        /// The organization name.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="title">
        /// The organization title.
        /// </param>
        public AuditLogOrganizationUpdatedChangesRequested(
            string? description,
            string? name,
            global::G.AuditLogOrganizationUpdatedChangesRequestedSettings? settings,
            string? title)
        {
            this.Description = description;
            this.Name = name;
            this.Settings = settings;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogOrganizationUpdatedChangesRequested()
        {
        }
    }
}