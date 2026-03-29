//HintName: G.Models.StoreStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of a store.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StoreStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreStatus value)
        {
            return value switch
            {
                StoreStatus.Completed => "completed",
                StoreStatus.Expired => "expired",
                StoreStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => StoreStatus.Completed,
                "expired" => StoreStatus.Expired,
                "in_progress" => StoreStatus.InProgress,
                _ => null,
            };
        }
    }
}