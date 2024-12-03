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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_user_id")]
        public global::System.Guid? CreatedByUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_login_slug")]
        public string? SsoLoginSlug { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_only")]
        public bool? SsoOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationPGSchemaSlim(
            global::System.Guid id,
            string displayName,
            bool isPersonal,
            bool disabled,
            global::System.DateTime? createdAt,
            global::System.Guid? createdByUserId,
            global::System.DateTime? modifiedAt,
            string? ssoLoginSlug,
            bool? ssoOnly)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPGSchemaSlim" /> class.
        /// </summary>
        public OrganizationPGSchemaSlim()
        {
        }
    }
}