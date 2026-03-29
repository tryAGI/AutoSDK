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
        [global::Newtonsoft.Json.JsonProperty("export_storages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CountLimit ExportStorages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("import_storages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CountLimit ImportStorages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_license_expired", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLicenseExpired { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_license_warning", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLicenseWarning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_prompts_expire", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPromptsExpire { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_prompts_warning", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPromptsWarning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_expires")]
        public global::System.DateTime? LicenseExpires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_issued")]
        public global::System.DateTime? LicenseIssued { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_warning")]
        public global::System.DateTime? LicenseWarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_is_active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OrganizationIsActive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CountLimit Projects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts_api_keys_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PromptsApiKeysEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PromptsEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts_expire")]
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
        [global::Newtonsoft.Json.JsonProperty("prompts_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptsStatusEnum PromptsStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts_warning")]
        public string? PromptsWarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CountLimit Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trial_days", Required = global::Newtonsoft.Json.Required.Always)]
        public int TrialDays { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CountLimit Users { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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