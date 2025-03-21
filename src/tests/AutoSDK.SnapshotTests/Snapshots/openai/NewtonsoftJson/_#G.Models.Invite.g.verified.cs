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
        [global::Newtonsoft.Json.JsonProperty("accepted_at")]
        public global::System.DateTimeOffset? AcceptedAt { get; set; }

        /// <summary>
        /// The email address of the individual to whom the invite was sent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite expires.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite was sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invited_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset InvitedAt { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `organization.invite`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.InviteObject Object { get; set; }

        /// <summary>
        /// The projects that were granted membership upon acceptance of the invite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects")]
        public global::System.Collections.Generic.IList<global::G.InviteProject>? Projects { get; set; }

        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InviteRole Role { get; set; } = default!;

        /// <summary>
        /// `accepted`,`expired`, or `pending`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InviteStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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