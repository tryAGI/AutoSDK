//HintName: G.Models.GetCustomRewardRedemptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetCustomRewardRedemptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FULFILLED")]
        Fulfilled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNFULFILLED")]
        Unfulfilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCustomRewardRedemptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCustomRewardRedemptionStatus value)
        {
            return value switch
            {
                GetCustomRewardRedemptionStatus.Canceled => "CANCELED",
                GetCustomRewardRedemptionStatus.Fulfilled => "FULFILLED",
                GetCustomRewardRedemptionStatus.Unfulfilled => "UNFULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCustomRewardRedemptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetCustomRewardRedemptionStatus.Canceled,
                "FULFILLED" => GetCustomRewardRedemptionStatus.Fulfilled,
                "UNFULFILLED" => GetCustomRewardRedemptionStatus.Unfulfilled,
                _ => null,
            };
        }
    }
}