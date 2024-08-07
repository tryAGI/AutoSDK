//HintName: G.Models.ListAuditLogsEventTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAuditLogsEventTypes
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
    public static class ListAuditLogsEventTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAuditLogsEventTypes value)
        {
            return value switch
            {
                ListAuditLogsEventTypes.ApiKeyCreated => "api_key.created",
                ListAuditLogsEventTypes.ApiKeyUpdated => "api_key.updated",
                ListAuditLogsEventTypes.ApiKeyDeleted => "api_key.deleted",
                ListAuditLogsEventTypes.InviteSent => "invite.sent",
                ListAuditLogsEventTypes.InviteAccepted => "invite.accepted",
                ListAuditLogsEventTypes.InviteDeleted => "invite.deleted",
                ListAuditLogsEventTypes.LoginSucceeded => "login.succeeded",
                ListAuditLogsEventTypes.LoginFailed => "login.failed",
                ListAuditLogsEventTypes.LogoutSucceeded => "logout.succeeded",
                ListAuditLogsEventTypes.LogoutFailed => "logout.failed",
                ListAuditLogsEventTypes.OrganizationUpdated => "organization.updated",
                ListAuditLogsEventTypes.ProjectCreated => "project.created",
                ListAuditLogsEventTypes.ProjectUpdated => "project.updated",
                ListAuditLogsEventTypes.ProjectArchived => "project.archived",
                ListAuditLogsEventTypes.ServiceAccountCreated => "service_account.created",
                ListAuditLogsEventTypes.ServiceAccountUpdated => "service_account.updated",
                ListAuditLogsEventTypes.ServiceAccountDeleted => "service_account.deleted",
                ListAuditLogsEventTypes.UserAdded => "user.added",
                ListAuditLogsEventTypes.UserUpdated => "user.updated",
                ListAuditLogsEventTypes.UserDeleted => "user.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAuditLogsEventTypes? ToEnum(string value)
        {
            return value switch
            {
                "api_key.created" => ListAuditLogsEventTypes.ApiKeyCreated,
                "api_key.updated" => ListAuditLogsEventTypes.ApiKeyUpdated,
                "api_key.deleted" => ListAuditLogsEventTypes.ApiKeyDeleted,
                "invite.sent" => ListAuditLogsEventTypes.InviteSent,
                "invite.accepted" => ListAuditLogsEventTypes.InviteAccepted,
                "invite.deleted" => ListAuditLogsEventTypes.InviteDeleted,
                "login.succeeded" => ListAuditLogsEventTypes.LoginSucceeded,
                "login.failed" => ListAuditLogsEventTypes.LoginFailed,
                "logout.succeeded" => ListAuditLogsEventTypes.LogoutSucceeded,
                "logout.failed" => ListAuditLogsEventTypes.LogoutFailed,
                "organization.updated" => ListAuditLogsEventTypes.OrganizationUpdated,
                "project.created" => ListAuditLogsEventTypes.ProjectCreated,
                "project.updated" => ListAuditLogsEventTypes.ProjectUpdated,
                "project.archived" => ListAuditLogsEventTypes.ProjectArchived,
                "service_account.created" => ListAuditLogsEventTypes.ServiceAccountCreated,
                "service_account.updated" => ListAuditLogsEventTypes.ServiceAccountUpdated,
                "service_account.deleted" => ListAuditLogsEventTypes.ServiceAccountDeleted,
                "user.added" => ListAuditLogsEventTypes.UserAdded,
                "user.updated" => ListAuditLogsEventTypes.UserUpdated,
                "user.deleted" => ListAuditLogsEventTypes.UserDeleted,
                _ => null,
            };
        }
    }
}