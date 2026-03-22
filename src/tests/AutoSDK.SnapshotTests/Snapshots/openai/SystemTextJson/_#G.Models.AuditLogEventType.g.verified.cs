//HintName: G.Models.AuditLogEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum AuditLogEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        CheckpointPermissionCreated,
        /// <summary>
        /// 
        /// </summary>
        CheckpointPermissionDeleted,
        /// <summary>
        /// 
        /// </summary>
        InviteAccepted,
        /// <summary>
        /// 
        /// </summary>
        InviteDeleted,
        /// <summary>
        /// 
        /// </summary>
        InviteSent,
        /// <summary>
        /// 
        /// </summary>
        LoginFailed,
        /// <summary>
        /// 
        /// </summary>
        LoginSucceeded,
        /// <summary>
        /// 
        /// </summary>
        LogoutFailed,
        /// <summary>
        /// 
        /// </summary>
        LogoutSucceeded,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectArchived,
        /// <summary>
        /// 
        /// </summary>
        ProjectCreated,
        /// <summary>
        /// 
        /// </summary>
        ProjectUpdated,
        /// <summary>
        /// 
        /// </summary>
        RateLimitDeleted,
        /// <summary>
        /// 
        /// </summary>
        RateLimitUpdated,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountCreated,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserAdded,
        /// <summary>
        /// 
        /// </summary>
        UserDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEventType value)
        {
            return value switch
            {
                AuditLogEventType.ApiKeyCreated => "api_key.created",
                AuditLogEventType.ApiKeyDeleted => "api_key.deleted",
                AuditLogEventType.ApiKeyUpdated => "api_key.updated",
                AuditLogEventType.CheckpointPermissionCreated => "checkpoint_permission.created",
                AuditLogEventType.CheckpointPermissionDeleted => "checkpoint_permission.deleted",
                AuditLogEventType.InviteAccepted => "invite.accepted",
                AuditLogEventType.InviteDeleted => "invite.deleted",
                AuditLogEventType.InviteSent => "invite.sent",
                AuditLogEventType.LoginFailed => "login.failed",
                AuditLogEventType.LoginSucceeded => "login.succeeded",
                AuditLogEventType.LogoutFailed => "logout.failed",
                AuditLogEventType.LogoutSucceeded => "logout.succeeded",
                AuditLogEventType.OrganizationUpdated => "organization.updated",
                AuditLogEventType.ProjectArchived => "project.archived",
                AuditLogEventType.ProjectCreated => "project.created",
                AuditLogEventType.ProjectUpdated => "project.updated",
                AuditLogEventType.RateLimitDeleted => "rate_limit.deleted",
                AuditLogEventType.RateLimitUpdated => "rate_limit.updated",
                AuditLogEventType.ServiceAccountCreated => "service_account.created",
                AuditLogEventType.ServiceAccountDeleted => "service_account.deleted",
                AuditLogEventType.ServiceAccountUpdated => "service_account.updated",
                AuditLogEventType.UserAdded => "user.added",
                AuditLogEventType.UserDeleted => "user.deleted",
                AuditLogEventType.UserUpdated => "user.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEventType? ToEnum(string value)
        {
            return value switch
            {
                "api_key.created" => AuditLogEventType.ApiKeyCreated,
                "api_key.deleted" => AuditLogEventType.ApiKeyDeleted,
                "api_key.updated" => AuditLogEventType.ApiKeyUpdated,
                "checkpoint_permission.created" => AuditLogEventType.CheckpointPermissionCreated,
                "checkpoint_permission.deleted" => AuditLogEventType.CheckpointPermissionDeleted,
                "invite.accepted" => AuditLogEventType.InviteAccepted,
                "invite.deleted" => AuditLogEventType.InviteDeleted,
                "invite.sent" => AuditLogEventType.InviteSent,
                "login.failed" => AuditLogEventType.LoginFailed,
                "login.succeeded" => AuditLogEventType.LoginSucceeded,
                "logout.failed" => AuditLogEventType.LogoutFailed,
                "logout.succeeded" => AuditLogEventType.LogoutSucceeded,
                "organization.updated" => AuditLogEventType.OrganizationUpdated,
                "project.archived" => AuditLogEventType.ProjectArchived,
                "project.created" => AuditLogEventType.ProjectCreated,
                "project.updated" => AuditLogEventType.ProjectUpdated,
                "rate_limit.deleted" => AuditLogEventType.RateLimitDeleted,
                "rate_limit.updated" => AuditLogEventType.RateLimitUpdated,
                "service_account.created" => AuditLogEventType.ServiceAccountCreated,
                "service_account.deleted" => AuditLogEventType.ServiceAccountDeleted,
                "service_account.updated" => AuditLogEventType.ServiceAccountUpdated,
                "user.added" => AuditLogEventType.UserAdded,
                "user.deleted" => AuditLogEventType.UserDeleted,
                "user.updated" => AuditLogEventType.UserUpdated,
                _ => null,
            };
        }
    }
}