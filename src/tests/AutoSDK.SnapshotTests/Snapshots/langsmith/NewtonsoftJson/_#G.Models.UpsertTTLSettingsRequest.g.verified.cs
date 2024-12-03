//HintName: G.Models.UpsertTTLSettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base TTL settings model.
    /// </summary>
    public sealed partial class UpsertTTLSettingsRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertTTLSettingsRequest" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="defaultTraceTier"></param>
        /// <param name="applyToAllProjects">
        /// Default Value: false
        /// </param>
        public UpsertTTLSettingsRequest(
            global::G.TraceTier defaultTraceTier,
            global::System.Guid? tenantId,
            bool? applyToAllProjects)
        {
            this.DefaultTraceTier = defaultTraceTier;
            this.TenantId = tenantId;
            this.ApplyToAllProjects = applyToAllProjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertTTLSettingsRequest" /> class.
        /// </summary>
        public UpsertTTLSettingsRequest()
        {
        }
    }
}