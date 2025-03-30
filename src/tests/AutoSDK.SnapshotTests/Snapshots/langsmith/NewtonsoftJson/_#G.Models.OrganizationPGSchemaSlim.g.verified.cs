//HintName: G.Models.OrganizationPGSchemaSlim.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for an organization in postgres for list views.
    /// </summary>
    public sealed partial class OrganizationPGSchemaSlim
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_user_id")]
        public global::System.Guid? CreatedByUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_personal", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPersonal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Disabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sso_login_slug")]
        public string? SsoLoginSlug { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sso_only")]
        public bool? SsoOnly { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_sharing_disabled")]
        public bool? PublicSharingDisabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPGSchemaSlim" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdByUserId"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="isPersonal"></param>
        /// <param name="disabled"></param>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="ssoOnly">
        /// Default Value: false
        /// </param>
        /// <param name="publicSharingDisabled">
        /// Default Value: false
        /// </param>
        public OrganizationPGSchemaSlim(
            global::System.Guid id,
            string displayName,
            bool isPersonal,
            bool disabled,
            global::System.DateTime? createdAt,
            global::System.Guid? createdByUserId,
            global::System.DateTime? modifiedAt,
            string? ssoLoginSlug,
            bool? ssoOnly,
            bool? publicSharingDisabled)
        {
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IsPersonal = isPersonal;
            this.Disabled = disabled;
            this.CreatedAt = createdAt;
            this.CreatedByUserId = createdByUserId;
            this.ModifiedAt = modifiedAt;
            this.SsoLoginSlug = ssoLoginSlug;
            this.SsoOnly = ssoOnly;
            this.PublicSharingDisabled = publicSharingDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPGSchemaSlim" /> class.
        /// </summary>
        public OrganizationPGSchemaSlim()
        {
        }
    }
}