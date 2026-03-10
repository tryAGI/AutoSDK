//HintName: G.Models.Authorization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authorization for an OAuth app, GitHub App, or a Personal Access Token.
    /// </summary>
    public sealed partial class Authorization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A list of scopes that this authorization is in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_last_eight")]
        public string? TokenLastEight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hashed_token")]
        public string? HashedToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorizationApp App { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note_url")]
        public string? NoteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fingerprint")]
        public string? Fingerprint { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation")]
        public global::G.NullableScopedInstallation? Installation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="scopes">
        /// A list of scopes that this authorization is in.
        /// </param>
        /// <param name="token"></param>
        /// <param name="tokenLastEight"></param>
        /// <param name="hashedToken"></param>
        /// <param name="app"></param>
        /// <param name="note"></param>
        /// <param name="noteUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="fingerprint"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="installation"></param>
        /// <param name="expiresAt"></param>
        public Authorization(
            long id,
            string url,
            string token,
            global::G.AuthorizationApp app,
            global::System.DateTime updatedAt,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<string>? scopes,
            string? tokenLastEight,
            string? hashedToken,
            string? note,
            string? noteUrl,
            string? fingerprint,
            global::G.NullableSimpleUser? user,
            global::G.NullableScopedInstallation? installation,
            global::System.DateTime? expiresAt)
        {
            this.Id = id;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Scopes = scopes;
            this.TokenLastEight = tokenLastEight;
            this.HashedToken = hashedToken;
            this.Note = note;
            this.NoteUrl = noteUrl;
            this.Fingerprint = fingerprint;
            this.User = user;
            this.Installation = installation;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization" /> class.
        /// </summary>
        public Authorization()
        {
        }
    }
}