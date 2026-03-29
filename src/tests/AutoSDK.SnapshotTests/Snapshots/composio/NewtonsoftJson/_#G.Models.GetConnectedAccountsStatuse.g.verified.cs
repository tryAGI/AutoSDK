//HintName: G.Models.GetConnectedAccountsStatuse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsStatuse
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
    public static class GetConnectedAccountsStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsStatuse value)
        {
            return value switch
            {
                GetConnectedAccountsStatuse.Active => "ACTIVE",
                GetConnectedAccountsStatuse.Expired => "EXPIRED",
                GetConnectedAccountsStatuse.Failed => "FAILED",
                GetConnectedAccountsStatuse.Inactive => "INACTIVE",
                GetConnectedAccountsStatuse.Initializing => "INITIALIZING",
                GetConnectedAccountsStatuse.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsStatuse? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => GetConnectedAccountsStatuse.Active,
                "EXPIRED" => GetConnectedAccountsStatuse.Expired,
                "FAILED" => GetConnectedAccountsStatuse.Failed,
                "INACTIVE" => GetConnectedAccountsStatuse.Inactive,
                "INITIALIZING" => GetConnectedAccountsStatuse.Initializing,
                "INITIATED" => GetConnectedAccountsStatuse.Initiated,
                _ => null,
            };
        }
    }
}