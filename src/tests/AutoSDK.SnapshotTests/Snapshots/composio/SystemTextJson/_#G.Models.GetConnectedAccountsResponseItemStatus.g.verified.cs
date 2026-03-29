//HintName: G.Models.GetConnectedAccountsResponseItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the connection
    /// </summary>
    public enum GetConnectedAccountsResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStatus value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStatus.Active => "ACTIVE",
                GetConnectedAccountsResponseItemStatus.Expired => "EXPIRED",
                GetConnectedAccountsResponseItemStatus.Failed => "FAILED",
                GetConnectedAccountsResponseItemStatus.Inactive => "INACTIVE",
                GetConnectedAccountsResponseItemStatus.Initializing => "INITIALIZING",
                GetConnectedAccountsResponseItemStatus.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => GetConnectedAccountsResponseItemStatus.Active,
                "EXPIRED" => GetConnectedAccountsResponseItemStatus.Expired,
                "FAILED" => GetConnectedAccountsResponseItemStatus.Failed,
                "INACTIVE" => GetConnectedAccountsResponseItemStatus.Inactive,
                "INITIALIZING" => GetConnectedAccountsResponseItemStatus.Initializing,
                "INITIATED" => GetConnectedAccountsResponseItemStatus.Initiated,
                _ => null,
            };
        }
    }
}