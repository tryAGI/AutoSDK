//HintName: G.Models.PostConnectedAccountsByNanoidRefreshResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the connected account (e.g., active, pending, failed)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsByNanoidRefreshResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ACTIVE")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXPIRED")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INACTIVE")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INITIALIZING")]
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INITIATED")]
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsByNanoidRefreshResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsByNanoidRefreshResponseStatus value)
        {
            return value switch
            {
                PostConnectedAccountsByNanoidRefreshResponseStatus.Active => "ACTIVE",
                PostConnectedAccountsByNanoidRefreshResponseStatus.Expired => "EXPIRED",
                PostConnectedAccountsByNanoidRefreshResponseStatus.Failed => "FAILED",
                PostConnectedAccountsByNanoidRefreshResponseStatus.Inactive => "INACTIVE",
                PostConnectedAccountsByNanoidRefreshResponseStatus.Initializing => "INITIALIZING",
                PostConnectedAccountsByNanoidRefreshResponseStatus.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsByNanoidRefreshResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PostConnectedAccountsByNanoidRefreshResponseStatus.Active,
                "EXPIRED" => PostConnectedAccountsByNanoidRefreshResponseStatus.Expired,
                "FAILED" => PostConnectedAccountsByNanoidRefreshResponseStatus.Failed,
                "INACTIVE" => PostConnectedAccountsByNanoidRefreshResponseStatus.Inactive,
                "INITIALIZING" => PostConnectedAccountsByNanoidRefreshResponseStatus.Initializing,
                "INITIATED" => PostConnectedAccountsByNanoidRefreshResponseStatus.Initiated,
                _ => null,
            };
        }
    }
}