//HintName: G.Models.PostConnectedAccountsResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DEPRECATED: This field will be removed in a future version
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsResponseStatus
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
    public static class PostConnectedAccountsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseStatus value)
        {
            return value switch
            {
                PostConnectedAccountsResponseStatus.Active => "ACTIVE",
                PostConnectedAccountsResponseStatus.Expired => "EXPIRED",
                PostConnectedAccountsResponseStatus.Failed => "FAILED",
                PostConnectedAccountsResponseStatus.Inactive => "INACTIVE",
                PostConnectedAccountsResponseStatus.Initializing => "INITIALIZING",
                PostConnectedAccountsResponseStatus.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PostConnectedAccountsResponseStatus.Active,
                "EXPIRED" => PostConnectedAccountsResponseStatus.Expired,
                "FAILED" => PostConnectedAccountsResponseStatus.Failed,
                "INACTIVE" => PostConnectedAccountsResponseStatus.Inactive,
                "INITIALIZING" => PostConnectedAccountsResponseStatus.Initializing,
                "INITIATED" => PostConnectedAccountsResponseStatus.Initiated,
                _ => null,
            };
        }
    }
}