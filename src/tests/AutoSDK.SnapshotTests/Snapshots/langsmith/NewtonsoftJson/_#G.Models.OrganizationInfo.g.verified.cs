//HintName: G.Models.OrganizationInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about an organization.
    /// </summary>
    public sealed partial class OrganizationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_personal", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPersonal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier")]
        public global::G.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sso_only")]
        public bool? SsoOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sso_login_slug")]
        public string? SsoLoginSlug { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_sharing_disabled")]
        public bool? PublicSharingDisabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("marketplace_payouts_enabled")]
        public bool? MarketplacePayoutsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wallet")]
        public global::G.Wallet? Wallet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfo" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="config">
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </param>
        /// <param name="isPersonal"></param>
        /// <param name="tier"></param>
        /// <param name="reachedMaxWorkspaces">
        /// Default Value: false
        /// </param>
        /// <param name="permissions">
        /// Default Value: []
        /// </param>
        /// <param name="disabled">
        /// Default Value: false
        /// </param>
        /// <param name="ssoOnly">
        /// Default Value: false
        /// </param>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="publicSharingDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="marketplacePayoutsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="wallet"></param>
        public OrganizationInfo(
            global::G.OrganizationConfig config,
            bool isPersonal,
            global::System.Guid? id,
            string? displayName,
            global::G.PaymentPlanTier? tier,
            bool? reachedMaxWorkspaces,
            global::System.Collections.Generic.IList<string>? permissions,
            bool? disabled,
            bool? ssoOnly,
            string? ssoLoginSlug,
            bool? publicSharingDisabled,
            bool? marketplacePayoutsEnabled,
            global::G.Wallet? wallet)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.IsPersonal = isPersonal;
            this.Id = id;
            this.DisplayName = displayName;
            this.Tier = tier;
            this.ReachedMaxWorkspaces = reachedMaxWorkspaces;
            this.Permissions = permissions;
            this.Disabled = disabled;
            this.SsoOnly = ssoOnly;
            this.SsoLoginSlug = ssoLoginSlug;
            this.PublicSharingDisabled = publicSharingDisabled;
            this.MarketplacePayoutsEnabled = marketplacePayoutsEnabled;
            this.Wallet = wallet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfo" /> class.
        /// </summary>
        public OrganizationInfo()
        {
        }
    }
}