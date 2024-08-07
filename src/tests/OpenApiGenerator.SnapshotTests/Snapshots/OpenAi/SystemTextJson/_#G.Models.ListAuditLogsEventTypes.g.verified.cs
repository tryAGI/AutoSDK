//HintName: G.Models.ListAuditLogsEventTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAuditLogsEventTypes
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