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
        [global::System.Text.Json.Serialization.JsonPropertyName("activated_at")]
        public global::System.DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_activity_log")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowActivityLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_ai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_ask_ai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowAskAi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_data_credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowDataCredentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_invite_people")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowInvitePeople { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_invite_project_experts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowInviteProjectExperts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_nda")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowNda { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_organization_webhooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowOrganizationWebhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_reviewing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowReviewing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_sso")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowSso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_storage_proxy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowStorageProxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automax_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutomaxEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automax_token_exists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutomaxTokenExists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_instance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CloudInstance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_members_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisableMembersPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_project_imports")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisableProjectImports { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("early_adopter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EarlyAdopter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_configured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EmailConfigured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_domains")]
        public global::System.Collections.Generic.IList<object>? EmbedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EmbedEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_settings")]
        public object? EmbedSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_role_management")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ManualRoleManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_workspace_management")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ManualWorkspaceManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secure_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SecureMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_persistence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool StoragePersistence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("white_label_id")]
        public string? WhiteLabelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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