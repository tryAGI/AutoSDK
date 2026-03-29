//HintName: G.Models.BillingFlags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingFlags
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("activated_at")]
        public global::System.DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_activity_log", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowActivityLog { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_ai", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowAi { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_ask_ai", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowAskAi { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_data_credentials", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowDataCredentials { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_invite_people", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowInvitePeople { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_invite_project_experts", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowInviteProjectExperts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_nda", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowNda { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_organization_webhooks", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowOrganizationWebhooks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_reviewing", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowReviewing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_sso", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowSso { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_storage_proxy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowStorageProxy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("automax_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutomaxEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("automax_token_exists", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutomaxTokenExists { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloud_instance", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CloudInstance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_members_page", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DisableMembersPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_project_imports", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DisableProjectImports { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("early_adopter", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EarlyAdopter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email_configured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EmailConfigured { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_domains")]
        public global::System.Collections.Generic.IList<object>? EmbedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EmbedEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_settings")]
        public object? EmbedSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manual_role_management", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ManualRoleManagement { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manual_workspace_management", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ManualWorkspaceManagement { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secure_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SecureMode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_persistence", Required = global::Newtonsoft.Json.Required.Always)]
        public bool StoragePersistence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("white_label_id")]
        public string? WhiteLabelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingFlags" /> class.
        /// </summary>
        /// <param name="allowActivityLog"></param>
        /// <param name="allowAi"></param>
        /// <param name="allowAskAi"></param>
        /// <param name="allowDataCredentials"></param>
        /// <param name="allowInvitePeople"></param>
        /// <param name="allowInviteProjectExperts"></param>
        /// <param name="allowNda"></param>
        /// <param name="allowOrganizationWebhooks"></param>
        /// <param name="allowReviewing"></param>
        /// <param name="allowSso"></param>
        /// <param name="allowStorageProxy"></param>
        /// <param name="automaxEnabled"></param>
        /// <param name="automaxTokenExists"></param>
        /// <param name="cloudInstance"></param>
        /// <param name="disableMembersPage"></param>
        /// <param name="disableProjectImports"></param>
        /// <param name="earlyAdopter"></param>
        /// <param name="emailConfigured"></param>
        /// <param name="embedEnabled"></param>
        /// <param name="manualRoleManagement"></param>
        /// <param name="manualWorkspaceManagement"></param>
        /// <param name="secureMode"></param>
        /// <param name="storagePersistence"></param>
        /// <param name="activatedAt"></param>
        /// <param name="embedDomains"></param>
        /// <param name="embedSettings"></param>
        /// <param name="whiteLabelId"></param>
        public BillingFlags(
            bool allowActivityLog,
            bool allowAi,
            bool allowAskAi,
            bool allowDataCredentials,
            bool allowInvitePeople,
            bool allowInviteProjectExperts,
            bool allowNda,
            bool allowOrganizationWebhooks,
            bool allowReviewing,
            bool allowSso,
            bool allowStorageProxy,
            bool automaxEnabled,
            bool automaxTokenExists,
            bool cloudInstance,
            bool disableMembersPage,
            bool disableProjectImports,
            bool earlyAdopter,
            bool emailConfigured,
            bool embedEnabled,
            bool manualRoleManagement,
            bool manualWorkspaceManagement,
            bool secureMode,
            bool storagePersistence,
            global::System.DateTime? activatedAt,
            global::System.Collections.Generic.IList<object>? embedDomains,
            object? embedSettings,
            string? whiteLabelId)
        {
            this.ActivatedAt = activatedAt;
            this.AllowActivityLog = allowActivityLog;
            this.AllowAi = allowAi;
            this.AllowAskAi = allowAskAi;
            this.AllowDataCredentials = allowDataCredentials;
            this.AllowInvitePeople = allowInvitePeople;
            this.AllowInviteProjectExperts = allowInviteProjectExperts;
            this.AllowNda = allowNda;
            this.AllowOrganizationWebhooks = allowOrganizationWebhooks;
            this.AllowReviewing = allowReviewing;
            this.AllowSso = allowSso;
            this.AllowStorageProxy = allowStorageProxy;
            this.AutomaxEnabled = automaxEnabled;
            this.AutomaxTokenExists = automaxTokenExists;
            this.CloudInstance = cloudInstance;
            this.DisableMembersPage = disableMembersPage;
            this.DisableProjectImports = disableProjectImports;
            this.EarlyAdopter = earlyAdopter;
            this.EmailConfigured = emailConfigured;
            this.EmbedDomains = embedDomains;
            this.EmbedEnabled = embedEnabled;
            this.EmbedSettings = embedSettings;
            this.ManualRoleManagement = manualRoleManagement;
            this.ManualWorkspaceManagement = manualWorkspaceManagement;
            this.SecureMode = secureMode;
            this.StoragePersistence = storagePersistence;
            this.WhiteLabelId = whiteLabelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingFlags" /> class.
        /// </summary>
        public BillingFlags()
        {
        }
    }
}