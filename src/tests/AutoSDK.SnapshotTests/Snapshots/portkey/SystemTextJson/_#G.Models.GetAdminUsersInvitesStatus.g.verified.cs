//HintName: G.Models.GetAdminUsersInvitesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAdminUsersInvitesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAdminUsersInvitesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAdminUsersInvitesStatus value)
        {
            return value switch
            {
                GetAdminUsersInvitesStatus.Accepted => "accepted",
                GetAdminUsersInvitesStatus.Cancelled => "cancelled",
                GetAdminUsersInvitesStatus.Expired => "expired",
                GetAdminUsersInvitesStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAdminUsersInvitesStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => GetAdminUsersInvitesStatus.Accepted,
                "cancelled" => GetAdminUsersInvitesStatus.Cancelled,
                "expired" => GetAdminUsersInvitesStatus.Expired,
                "pending" => GetAdminUsersInvitesStatus.Pending,
                _ => null,
            };
        }
    }
}