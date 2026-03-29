//HintName: G.Models.GetConnectedAccountsByNanoidResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the connection
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsByNanoidResponseStatus
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
    public static class GetConnectedAccountsByNanoidResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStatus value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStatus.Active => "ACTIVE",
                GetConnectedAccountsByNanoidResponseStatus.Expired => "EXPIRED",
                GetConnectedAccountsByNanoidResponseStatus.Failed => "FAILED",
                GetConnectedAccountsByNanoidResponseStatus.Inactive => "INACTIVE",
                GetConnectedAccountsByNanoidResponseStatus.Initializing => "INITIALIZING",
                GetConnectedAccountsByNanoidResponseStatus.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => GetConnectedAccountsByNanoidResponseStatus.Active,
                "EXPIRED" => GetConnectedAccountsByNanoidResponseStatus.Expired,
                "FAILED" => GetConnectedAccountsByNanoidResponseStatus.Failed,
                "INACTIVE" => GetConnectedAccountsByNanoidResponseStatus.Inactive,
                "INITIALIZING" => GetConnectedAccountsByNanoidResponseStatus.Initializing,
                "INITIATED" => GetConnectedAccountsByNanoidResponseStatus.Initiated,
                _ => null,
            };
        }
    }
}