//HintName: G.Models.RetentionRuleWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetentionRuleWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Set to true to create an organization-level rule<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_level")]
        public bool? OrganizationLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retention", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RetentionRuleWriteRetentionJsonConverter))]
        public global::G.RetentionRuleWriteRetention Retention { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_to_past")]
        public bool? ApplyToPast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRuleWrite" /> class.
        /// </summary>
        /// <param name="retention"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationLevel">
        /// Set to true to create an organization-level rule<br/>
        /// Included only in requests
        /// </param>
        /// <param name="applyToPast"></param>
        public RetentionRuleWrite(
            global::G.RetentionRuleWriteRetention retention,
            global::System.Guid? projectId,
            bool? organizationLevel,
            bool? applyToPast)
        {
            this.ProjectId = projectId;
            this.OrganizationLevel = organizationLevel;
            this.Retention = retention;
            this.ApplyToPast = applyToPast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRuleWrite" /> class.
        /// </summary>
        public RetentionRuleWrite()
        {
        }
    }
}