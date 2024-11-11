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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.AuthProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ls_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid LsUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("saml_provider_id")]
        public global::System.Guid? SamlProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_user_id")]
        public global::System.Guid? ProviderUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email_confirmed_at")]
        public global::System.DateTime? EmailConfirmedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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