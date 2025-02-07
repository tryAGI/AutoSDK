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
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_trace_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TraceTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TraceTier DefaultTraceTier { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to_all_projects")]
        public bool? ApplyToAllProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configured_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConfiguredBy ConfiguredBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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