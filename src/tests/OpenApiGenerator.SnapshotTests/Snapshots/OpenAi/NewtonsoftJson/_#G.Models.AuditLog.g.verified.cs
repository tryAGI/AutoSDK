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
        /// The ID of this log.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuditLogEventType? Type { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int EffectiveAt { get; set; } = default!;

        /// <summary>
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public global::G.AuditLogProject? Project { get; set; }

        /// <summary>
        /// The actor who performed the audit logged action.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuditLogActor? Actor { get; set; } = default!;

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key.created")]
        public global::G.AuditLogApiKeyCreated? ApiKeyCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key.updated")]
        public global::G.AuditLogApiKeyUpdated? ApiKeyUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key.deleted")]
        public global::G.AuditLogApiKeyDeleted? ApiKeyDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invite.sent")]
        public global::G.AuditLogInviteSent? InviteSent { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invite.accepted")]
        public global::G.AuditLogInviteAccepted? InviteAccepted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invite.deleted")]
        public global::G.AuditLogInviteDeleted? InviteDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login.failed")]
        public global::G.AuditLogLoginFailed? LoginFailed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logout.failed")]
        public global::G.AuditLogLogoutFailed? LogoutFailed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization.updated")]
        public global::G.AuditLogOrganizationUpdated? OrganizationUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project.created")]
        public global::G.AuditLogProjectCreated? ProjectCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project.updated")]
        public global::G.AuditLogProjectUpdated? ProjectUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project.archived")]
        public global::G.AuditLogProjectArchived? ProjectArchived { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account.created")]
        public global::G.AuditLogServiceAccountCreated? ServiceAccountCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account.updated")]
        public global::G.AuditLogServiceAccountUpdated? ServiceAccountUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account.deleted")]
        public global::G.AuditLogServiceAccountDeleted? ServiceAccountDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user.added")]
        public global::G.AuditLogUserAdded? UserAdded { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user.updated")]
        public global::G.AuditLogUserUpdated? UserUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user.deleted")]
        public global::G.AuditLogUserDeleted? UserDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}