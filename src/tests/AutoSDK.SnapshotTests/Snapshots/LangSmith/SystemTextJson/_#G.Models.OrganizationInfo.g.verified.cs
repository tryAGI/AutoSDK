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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PaymentPlanTierJsonConverter))]
        public global::G.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_only")]
        public bool? SsoOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_login_slug")]
        public string? SsoLoginSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
            string? ssoLoginSlug)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfo" /> class.
        /// </summary>
        public OrganizationInfo()
        {
        }
    }
}