//HintName: G.Models.TTLSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TTL settings model.
    /// </summary>
    public sealed partial class TTLSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_trace_tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TraceTier DefaultTraceTier { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_to_all_projects")]
        public bool? ApplyToAllProjects { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configured_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConfiguredBy ConfiguredBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTLSettings" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="defaultTraceTier"></param>
        /// <param name="applyToAllProjects">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="configuredBy"></param>
        public TTLSettings(
            global::G.TraceTier defaultTraceTier,
            global::System.Guid id,
            global::System.Guid organizationId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.ConfiguredBy configuredBy,
            global::System.Guid? tenantId,
            bool? applyToAllProjects)
        {
            this.DefaultTraceTier = defaultTraceTier;
            this.Id = id;
            this.OrganizationId = organizationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ConfiguredBy = configuredBy;
            this.TenantId = tenantId;
            this.ApplyToAllProjects = applyToAllProjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTLSettings" /> class.
        /// </summary>
        public TTLSettings()
        {
        }
    }
}