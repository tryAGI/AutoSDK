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
        [global::System.Runtime.Serialization.EnumMember(Value="api_key.deleted")]
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key.updated")]
        ApiKeyUpdated,
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
        [global::System.Runtime.Serialization.EnumMember(Value="invite.sent")]
        InviteSent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="login.failed")]
        LoginFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="login.succeeded")]
        LoginSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logout.failed")]
        LogoutFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logout.succeeded")]
        LogoutSucceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.updated")]
        OrganizationUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project.archived")]
        ProjectArchived,
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
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit.deleted")]
        RateLimitDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit.updated")]
        RateLimitUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account.created")]
        ServiceAccountCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account.deleted")]
        ServiceAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account.updated")]
        ServiceAccountUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.added")]
        UserAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.deleted")]
        UserDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.updated")]
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