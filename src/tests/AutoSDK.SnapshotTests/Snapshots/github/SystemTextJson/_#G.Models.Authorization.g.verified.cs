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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A list of scopes that this authorization is in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_last_eight")]
        public string? TokenLastEight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashed_token")]
        public string? HashedToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthorizationApp App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note_url")]
        public string? NoteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::G.NullableScopedInstallation? Installation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="app"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="scopes">
        /// A list of scopes that this authorization is in.
        /// </param>
        /// <param name="tokenLastEight"></param>
        /// <param name="hashedToken"></param>
        /// <param name="note"></param>
        /// <param name="noteUrl"></param>
        /// <param name="fingerprint"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="installation"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.Scopes = scopes;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TokenLastEight = tokenLastEight;
            this.HashedToken = hashedToken;
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Note = note;
            this.NoteUrl = noteUrl;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
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