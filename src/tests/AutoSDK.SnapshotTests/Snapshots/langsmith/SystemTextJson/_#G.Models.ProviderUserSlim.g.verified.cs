//HintName: G.Models.ProviderUserSlim.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderUserSlim
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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthProviderJsonConverter))]
        public global::G.AuthProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_provider_id")]
        public global::System.Guid? SamlProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_user_id")]
        public global::System.Guid? ProviderUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_confirmed_at")]
        public global::System.DateTime? EmailConfirmedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUserSlim" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <param name="lsUserId"></param>
        /// <param name="samlProviderId"></param>
        /// <param name="providerUserId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="email"></param>
        /// <param name="fullName"></param>
        /// <param name="emailConfirmedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProviderUserSlim(
            global::System.Guid id,
            global::System.Guid lsUserId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.AuthProvider? provider,
            global::System.Guid? samlProviderId,
            global::System.Guid? providerUserId,
            string? email,
            string? fullName,
            global::System.DateTime? emailConfirmedAt)
        {
            this.Id = id;
            this.LsUserId = lsUserId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Provider = provider;
            this.SamlProviderId = samlProviderId;
            this.ProviderUserId = providerUserId;
            this.Email = email;
            this.FullName = fullName;
            this.EmailConfirmedAt = emailConfirmedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUserSlim" /> class.
        /// </summary>
        public ProviderUserSlim()
        {
        }
    }
}