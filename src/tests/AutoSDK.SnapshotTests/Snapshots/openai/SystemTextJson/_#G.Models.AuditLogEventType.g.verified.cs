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
        ApiKeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        InviteSent,
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
        LoginSucceeded,
        /// <summary>
        /// 
        /// </summary>
        LoginFailed,
        /// <summary>
        /// 
        /// </summary>
        LogoutSucceeded,
        /// <summary>
        /// 
        /// </summary>
        LogoutFailed,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUpdated,
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
        ProjectArchived,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountCreated,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountUpdated,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        RateLimitUpdated,
        /// <summary>
        /// 
        /// </summary>
        RateLimitDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserAdded,
        /// <summary>
        /// 
        /// </summary>
        UserUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserDeleted,
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
                AuditLogEventType.ApiKeyUpdated => "api_key.updated",
                AuditLogEventType.ApiKeyDeleted => "api_key.deleted",
                AuditLogEventType.InviteSent => "invite.sent",
                AuditLogEventType.InviteAccepted => "invite.accepted",
                AuditLogEventType.InviteDeleted => "invite.deleted",
                AuditLogEventType.LoginSucceeded => "login.succeeded",
                AuditLogEventType.LoginFailed => "login.failed",
                AuditLogEventType.LogoutSucceeded => "logout.succeeded",
                AuditLogEventType.LogoutFailed => "logout.failed",
                AuditLogEventType.OrganizationUpdated => "organization.updated",
                AuditLogEventType.ProjectCreated => "project.created",
                AuditLogEventType.ProjectUpdated => "project.updated",
                AuditLogEventType.ProjectArchived => "project.archived",
                AuditLogEventType.ServiceAccountCreated => "service_account.created",
                AuditLogEventType.ServiceAccountUpdated => "service_account.updated",
                AuditLogEventType.ServiceAccountDeleted => "service_account.deleted",
                AuditLogEventType.RateLimitUpdated => "rate_limit.updated",
                AuditLogEventType.RateLimitDeleted => "rate_limit.deleted",
                AuditLogEventType.UserAdded => "user.added",
                AuditLogEventType.UserUpdated => "user.updated",
                AuditLogEventType.UserDeleted => "user.deleted",
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
                "api_key.updated" => AuditLogEventType.ApiKeyUpdated,
                "api_key.deleted" => AuditLogEventType.ApiKeyDeleted,
                "invite.sent" => AuditLogEventType.InviteSent,
                "invite.accepted" => AuditLogEventType.InviteAccepted,
                "invite.deleted" => AuditLogEventType.InviteDeleted,
                "login.succeeded" => AuditLogEventType.LoginSucceeded,
                "login.failed" => AuditLogEventType.LoginFailed,
                "logout.succeeded" => AuditLogEventType.LogoutSucceeded,
                "logout.failed" => AuditLogEventType.LogoutFailed,
                "organization.updated" => AuditLogEventType.OrganizationUpdated,
                "project.created" => AuditLogEventType.ProjectCreated,
                "project.updated" => AuditLogEventType.ProjectUpdated,
                "project.archived" => AuditLogEventType.ProjectArchived,
                "service_account.created" => AuditLogEventType.ServiceAccountCreated,
                "service_account.updated" => AuditLogEventType.ServiceAccountUpdated,
                "service_account.deleted" => AuditLogEventType.ServiceAccountDeleted,
                "rate_limit.updated" => AuditLogEventType.RateLimitUpdated,
                "rate_limit.deleted" => AuditLogEventType.RateLimitDeleted,
                "user.added" => AuditLogEventType.UserAdded,
                "user.updated" => AuditLogEventType.UserUpdated,
                "user.deleted" => AuditLogEventType.UserDeleted,
                _ => null,
            };
        }
    }
}