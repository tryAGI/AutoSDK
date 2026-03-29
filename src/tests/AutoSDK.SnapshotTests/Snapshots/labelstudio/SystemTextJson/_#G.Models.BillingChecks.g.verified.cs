//HintName: G.Models.BillingChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingChecks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_storages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CountLimit ExportStorages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_storages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CountLimit ImportStorages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_license_expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLicenseExpired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_license_warning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLicenseWarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_prompts_expire")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPromptsExpire { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_prompts_warning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPromptsWarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_expires")]
        public global::System.DateTime? LicenseExpires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_issued")]
        public global::System.DateTime? LicenseIssued { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_warning")]
        public global::System.DateTime? LicenseWarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OrganizationIsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CountLimit Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_api_keys_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PromptsApiKeysEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PromptsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_expire")]
        public string? PromptsExpire { get; set; }

        /// <summary>
        /// * `Enabled` - Enabled<br/>
        /// * `Cloud license per organization disabled` - Cloud license per organization disabled<br/>
        /// * `On-premise global license disabled` - On-premise global license disabled<br/>
        /// * `Expired` - Expired<br/>
        /// * `Adala not connected` - Adala not connected<br/>
        /// * `Disabled for this organization [FF]` - Disabled for this organization [FF]<br/>
        /// * `unknown` - unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptsStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptsStatusEnum PromptsStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_warning")]
        public string? PromptsWarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CountLimit Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrialDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CountLimit Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingChecks" /> class.
        /// </summary>
        /// <param name="exportStorages"></param>
        /// <param name="importStorages"></param>
        /// <param name="isLicenseExpired"></param>
        /// <param name="isLicenseWarning"></param>
        /// <param name="isPromptsExpire"></param>
        /// <param name="isPromptsWarning"></param>
        /// <param name="organizationIsActive"></param>
        /// <param name="projects"></param>
        /// <param name="promptsApiKeysEnabled"></param>
        /// <param name="promptsEnabled"></param>
        /// <param name="promptsStatus">
        /// * `Enabled` - Enabled<br/>
        /// * `Cloud license per organization disabled` - Cloud license per organization disabled<br/>
        /// * `On-premise global license disabled` - On-premise global license disabled<br/>
        /// * `Expired` - Expired<br/>
        /// * `Adala not connected` - Adala not connected<br/>
        /// * `Disabled for this organization [FF]` - Disabled for this organization [FF]<br/>
        /// * `unknown` - unknown
        /// </param>
        /// <param name="results"></param>
        /// <param name="trialDays"></param>
        /// <param name="users"></param>
        /// <param name="licenseExpires"></param>
        /// <param name="licenseIssued"></param>
        /// <param name="licenseWarning"></param>
        /// <param name="promptsExpire"></param>
        /// <param name="promptsWarning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingChecks(
            global::G.CountLimit exportStorages,
            global::G.CountLimit importStorages,
            bool isLicenseExpired,
            bool isLicenseWarning,
            bool isPromptsExpire,
            bool isPromptsWarning,
            bool organizationIsActive,
            global::G.CountLimit projects,
            bool promptsApiKeysEnabled,
            bool promptsEnabled,
            global::G.PromptsStatusEnum promptsStatus,
            global::G.CountLimit results,
            int trialDays,
            global::G.CountLimit users,
            global::System.DateTime? licenseExpires,
            global::System.DateTime? licenseIssued,
            global::System.DateTime? licenseWarning,
            string? promptsExpire,
            string? promptsWarning)
        {
            this.ExportStorages = exportStorages ?? throw new global::System.ArgumentNullException(nameof(exportStorages));
            this.ImportStorages = importStorages ?? throw new global::System.ArgumentNullException(nameof(importStorages));
            this.IsLicenseExpired = isLicenseExpired;
            this.IsLicenseWarning = isLicenseWarning;
            this.IsPromptsExpire = isPromptsExpire;
            this.IsPromptsWarning = isPromptsWarning;
            this.LicenseExpires = licenseExpires;
            this.LicenseIssued = licenseIssued;
            this.LicenseWarning = licenseWarning;
            this.OrganizationIsActive = organizationIsActive;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.PromptsApiKeysEnabled = promptsApiKeysEnabled;
            this.PromptsEnabled = promptsEnabled;
            this.PromptsExpire = promptsExpire;
            this.PromptsStatus = promptsStatus;
            this.PromptsWarning = promptsWarning;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TrialDays = trialDays;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingChecks" /> class.
        /// </summary>
        public BillingChecks()
        {
        }
    }
}