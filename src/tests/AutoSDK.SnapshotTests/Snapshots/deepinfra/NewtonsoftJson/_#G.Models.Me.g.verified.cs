//HintName: G.Models.Me.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Me
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email_verified", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EmailVerified { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_email_verified")]
        public bool? RequireEmailVerified { get; set; }

        /// <summary>
        /// Name that is used to identifythe account on the website
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Authentication provider, e.g. 'github'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("picture", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Picture { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_admin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAdmin { get; set; } = default!;

        /// <summary>
        /// Personal name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_business_account", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsBusinessAccount { get; set; } = default!;

        /// <summary>
        /// Company name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company", Required = global::Newtonsoft.Json.Required.Always)]
        public string Company { get; set; } = default!;

        /// <summary>
        /// Company website address
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website", Required = global::Newtonsoft.Json.Required.Always)]
        public string Website { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_team_account")]
        public bool? IsTeamAccount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_team_owner")]
        public bool? IsTeamOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_role")]
        public string? TeamRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_display_name")]
        public string? TeamDisplayName { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_team_upgrade_enabled")]
        public bool? IsTeamUpgradeEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vercel_connection")]
        public global::G.MeVercelConnection? VercelConnection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Me" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="requireEmailVerified">
        /// Default Value: false
        /// </param>
        /// <param name="displayName">
        /// Name that is used to identifythe account on the website
        /// </param>
        /// <param name="provider">
        /// Authentication provider, e.g. 'github'
        /// </param>
        /// <param name="picture"></param>
        /// <param name="isAdmin"></param>
        /// <param name="name">
        /// Personal name
        /// </param>
        /// <param name="isBusinessAccount"></param>
        /// <param name="company">
        /// Company name
        /// </param>
        /// <param name="website">
        /// Company website address
        /// </param>
        /// <param name="isTeamAccount">
        /// Default Value: false
        /// </param>
        /// <param name="isTeamOwner">
        /// Default Value: false
        /// </param>
        /// <param name="teamRole"></param>
        /// <param name="teamDisplayName"></param>
        /// <param name="isTeamUpgradeEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="vercelConnection"></param>
        public Me(
            string uid,
            string? email,
            bool emailVerified,
            string displayName,
            string provider,
            string? picture,
            bool isAdmin,
            string name,
            bool isBusinessAccount,
            string company,
            string website,
            bool? requireEmailVerified,
            bool? isTeamAccount,
            bool? isTeamOwner,
            string? teamRole,
            string? teamDisplayName,
            bool? isTeamUpgradeEnabled,
            global::G.MeVercelConnection? vercelConnection)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.EmailVerified = emailVerified;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Picture = picture ?? throw new global::System.ArgumentNullException(nameof(picture));
            this.IsAdmin = isAdmin;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsBusinessAccount = isBusinessAccount;
            this.Company = company ?? throw new global::System.ArgumentNullException(nameof(company));
            this.Website = website ?? throw new global::System.ArgumentNullException(nameof(website));
            this.RequireEmailVerified = requireEmailVerified;
            this.IsTeamAccount = isTeamAccount;
            this.IsTeamOwner = isTeamOwner;
            this.TeamRole = teamRole;
            this.TeamDisplayName = teamDisplayName;
            this.IsTeamUpgradeEnabled = isTeamUpgradeEnabled;
            this.VercelConnection = vercelConnection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me" /> class.
        /// </summary>
        public Me()
        {
        }
    }
}