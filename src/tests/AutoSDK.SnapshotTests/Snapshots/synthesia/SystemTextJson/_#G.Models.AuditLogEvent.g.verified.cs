//HintName: G.Models.AuditLogEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Single audit log event.<br/>
    /// Represents one audit event with full details including actor, target,<br/>
    /// context, and domain-specific details.<br/>
    /// Example response:<br/>
    /// {<br/>
    ///     "id": "256eb609-72cb-4d42-a7a3-59a65d4e6726",<br/>
    ///     "action": "user.authentication.login",<br/>
    ///     "status": "success",<br/>
    ///     "actor": {<br/>
    ///         "type": "user",<br/>
    ///         "id": "93d3f26c-8bb1-4759-b0c7-eef01cb0321b",<br/>
    ///         "name": "local user",<br/>
    ///         "email": "dev_user@synthesia.io"<br/>
    ///     },<br/>
    ///     "target": {<br/>
    ///         "type": "user",<br/>
    ///         "id": "93d3f26c-8bb1-4759-b0c7-eef01cb0321b",<br/>
    ///         "name": "local user"<br/>
    ///     },<br/>
    ///     "context": {<br/>
    ///         "workspaceId": "b93d1427-06d8-412a-b158-6280e68b54d5",<br/>
    ///         "organizationId": null,<br/>
    ///         "ipAddress": null<br/>
    ///     },<br/>
    ///     "details": {<br/>
    ///         "authMethod": "username_password",<br/>
    ///         "isImpersonation": false,<br/>
    ///         "emailVerified": true,<br/>
    ///         "emailDomain": "synthesia.io",<br/>
    ///         "company": "Synthesia"<br/>
    ///     },<br/>
    ///     "metadata": {<br/>
    ///         "createdAt": "2025-10-05T06:58:28.321Z",<br/>
    ///         "processedAt": "2025-10-05T06:58:28.322Z"<br/>
    ///     }<br/>
    /// }
    /// </summary>
    public sealed partial class AuditLogEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Actor (who performed the action) information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Actor Actor { get; set; }

        /// <summary>
        /// Target (what was acted upon) information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Target Target { get; set; }

        /// <summary>
        /// Event context (workspace, organization, IP address).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Context Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Details { get; set; }

        /// <summary>
        /// Event metadata (timestamps).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Metadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="action"></param>
        /// <param name="status"></param>
        /// <param name="actor">
        /// Actor (who performed the action) information.
        /// </param>
        /// <param name="target">
        /// Target (what was acted upon) information.
        /// </param>
        /// <param name="context">
        /// Event context (workspace, organization, IP address).
        /// </param>
        /// <param name="details"></param>
        /// <param name="metadata">
        /// Event metadata (timestamps).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEvent(
            string id,
            string action,
            string status,
            global::G.Actor actor,
            global::G.Target target,
            global::G.Context context,
            object details,
            global::G.Metadata metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEvent" /> class.
        /// </summary>
        public AuditLogEvent()
        {
        }
    }
}