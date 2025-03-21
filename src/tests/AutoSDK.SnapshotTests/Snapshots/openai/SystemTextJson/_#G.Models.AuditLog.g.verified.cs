//HintName: G.Models.AuditLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A log of a user action or configuration change within this organization.
    /// </summary>
    public sealed partial class AuditLog
    {
        /// <summary>
        /// The actor who performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuditLogActor Actor { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.created")]
        public global::G.AuditLogApiKeyCreated? ApiKeyCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.deleted")]
        public global::G.AuditLogApiKeyDeleted? ApiKeyDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.updated")]
        public global::G.AuditLogApiKeyUpdated? ApiKeyUpdated { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// The ID of this log.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.accepted")]
        public global::G.AuditLogInviteAccepted? InviteAccepted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.deleted")]
        public global::G.AuditLogInviteDeleted? InviteDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.sent")]
        public global::G.AuditLogInviteSent? InviteSent { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login.failed")]
        public global::G.AuditLogLoginFailed? LoginFailed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logout.failed")]
        public global::G.AuditLogLogoutFailed? LogoutFailed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization.updated")]
        public global::G.AuditLogOrganizationUpdated? OrganizationUpdated { get; set; }

        /// <summary>
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::G.AuditLogProject? Project { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.archived")]
        public global::G.AuditLogProjectArchived? ProjectArchived { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.created")]
        public global::G.AuditLogProjectCreated? ProjectCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.updated")]
        public global::G.AuditLogProjectUpdated? ProjectUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit.deleted")]
        public global::G.AuditLogRateLimitDeleted? RateLimitDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit.updated")]
        public global::G.AuditLogRateLimitUpdated? RateLimitUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.created")]
        public global::G.AuditLogServiceAccountCreated? ServiceAccountCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.deleted")]
        public global::G.AuditLogServiceAccountDeleted? ServiceAccountDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.updated")]
        public global::G.AuditLogServiceAccountUpdated? ServiceAccountUpdated { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuditLogEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuditLogEventType Type { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.added")]
        public global::G.AuditLogUserAdded? UserAdded { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.deleted")]
        public global::G.AuditLogUserDeleted? UserDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.updated")]
        public global::G.AuditLogUserUpdated? UserUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLog" /> class.
        /// </summary>
        /// <param name="actor">
        /// The actor who performed the audit logged action.
        /// </param>
        /// <param name="apiKeyCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="apiKeyDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="apiKeyUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="effectiveAt">
        /// The Unix timestamp (in seconds) of the event.
        /// </param>
        /// <param name="id">
        /// The ID of this log.
        /// </param>
        /// <param name="inviteAccepted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteSent">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="loginFailed">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="logoutFailed">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="organizationUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="project">
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
        /// </param>
        /// <param name="projectArchived">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="userAdded">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="userDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="userUpdated">
        /// The details for events with this `type`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLog(
            global::G.AuditLogActor actor,
            global::System.DateTimeOffset effectiveAt,
            string id,
            global::G.AuditLogEventType type,
            global::G.AuditLogApiKeyCreated? apiKeyCreated,
            global::G.AuditLogApiKeyDeleted? apiKeyDeleted,
            global::G.AuditLogApiKeyUpdated? apiKeyUpdated,
            global::G.AuditLogInviteAccepted? inviteAccepted,
            global::G.AuditLogInviteDeleted? inviteDeleted,
            global::G.AuditLogInviteSent? inviteSent,
            global::G.AuditLogLoginFailed? loginFailed,
            global::G.AuditLogLogoutFailed? logoutFailed,
            global::G.AuditLogOrganizationUpdated? organizationUpdated,
            global::G.AuditLogProject? project,
            global::G.AuditLogProjectArchived? projectArchived,
            global::G.AuditLogProjectCreated? projectCreated,
            global::G.AuditLogProjectUpdated? projectUpdated,
            global::G.AuditLogRateLimitDeleted? rateLimitDeleted,
            global::G.AuditLogRateLimitUpdated? rateLimitUpdated,
            global::G.AuditLogServiceAccountCreated? serviceAccountCreated,
            global::G.AuditLogServiceAccountDeleted? serviceAccountDeleted,
            global::G.AuditLogServiceAccountUpdated? serviceAccountUpdated,
            global::G.AuditLogUserAdded? userAdded,
            global::G.AuditLogUserDeleted? userDeleted,
            global::G.AuditLogUserUpdated? userUpdated)
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.EffectiveAt = effectiveAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ApiKeyCreated = apiKeyCreated;
            this.ApiKeyDeleted = apiKeyDeleted;
            this.ApiKeyUpdated = apiKeyUpdated;
            this.InviteAccepted = inviteAccepted;
            this.InviteDeleted = inviteDeleted;
            this.InviteSent = inviteSent;
            this.LoginFailed = loginFailed;
            this.LogoutFailed = logoutFailed;
            this.OrganizationUpdated = organizationUpdated;
            this.Project = project;
            this.ProjectArchived = projectArchived;
            this.ProjectCreated = projectCreated;
            this.ProjectUpdated = projectUpdated;
            this.RateLimitDeleted = rateLimitDeleted;
            this.RateLimitUpdated = rateLimitUpdated;
            this.ServiceAccountCreated = serviceAccountCreated;
            this.ServiceAccountDeleted = serviceAccountDeleted;
            this.ServiceAccountUpdated = serviceAccountUpdated;
            this.UserAdded = userAdded;
            this.UserDeleted = userDeleted;
            this.UserUpdated = userUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLog" /> class.
        /// </summary>
        public AuditLog()
        {
        }
    }
}