//HintName: G.Models.AuditLogEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuditLogEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key.created")]
        ApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key.updated")]
        ApiKeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key.deleted")]
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="checkpoint_permission.created")]
        CheckpointPermissionCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="checkpoint_permission.deleted")]
        CheckpointPermissionDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invite.sent")]
        InviteSent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invite.accepted")]
        InviteAccepted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invite.deleted")]
        InviteDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="login.succeeded")]
        LoginSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="login.failed")]
        LoginFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logout.succeeded")]
        LogoutSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logout.failed")]
        LogoutFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.updated")]
        OrganizationUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project.created")]
        ProjectCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project.updated")]
        ProjectUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project.archived")]
        ProjectArchived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account.created")]
        ServiceAccountCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account.updated")]
        ServiceAccountUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account.deleted")]
        ServiceAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit.updated")]
        RateLimitUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit.deleted")]
        RateLimitDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.added")]
        UserAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.updated")]
        UserUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.deleted")]
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
                AuditLogEventType.CheckpointPermissionCreated => "checkpoint_permission.created",
                AuditLogEventType.CheckpointPermissionDeleted => "checkpoint_permission.deleted",
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
                "checkpoint_permission.created" => AuditLogEventType.CheckpointPermissionCreated,
                "checkpoint_permission.deleted" => AuditLogEventType.CheckpointPermissionDeleted,
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