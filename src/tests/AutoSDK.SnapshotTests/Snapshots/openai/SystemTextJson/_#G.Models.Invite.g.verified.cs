//HintName: G.Models.Invite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual `invite` to the organization.
    /// </summary>
    public sealed partial class Invite
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite was accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? AcceptedAt { get; set; }

        /// <summary>
        /// The email address of the individual to whom the invite was sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset InvitedAt { get; set; }

        /// <summary>
        /// The object type, which is always `organization.invite`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteObjectJsonConverter))]
        public global::G.InviteObject Object { get; set; }

        /// <summary>
        /// The projects that were granted membership upon acceptance of the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::G.InviteProject>? Projects { get; set; }

        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InviteRole Role { get; set; }

        /// <summary>
        /// `accepted`,`expired`, or `pending`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InviteStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        /// <param name="acceptedAt">
        /// The Unix timestamp (in seconds) of when the invite was accepted.
        /// </param>
        /// <param name="email">
        /// The email address of the individual to whom the invite was sent
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) of when the invite expires.
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="invitedAt">
        /// The Unix timestamp (in seconds) of when the invite was sent.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.invite`
        /// </param>
        /// <param name="projects">
        /// The projects that were granted membership upon acceptance of the invite.
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="status">
        /// `accepted`,`expired`, or `pending`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invite(
            string email,
            global::System.DateTimeOffset expiresAt,
            string id,
            global::System.DateTimeOffset invitedAt,
            global::G.InviteRole role,
            global::G.InviteStatus status,
            global::System.DateTimeOffset? acceptedAt,
            global::G.InviteObject @object,
            global::System.Collections.Generic.IList<global::G.InviteProject>? projects)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InvitedAt = invitedAt;
            this.Role = role;
            this.Status = status;
            this.AcceptedAt = acceptedAt;
            this.Object = @object;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        public Invite()
        {
        }
    }
}