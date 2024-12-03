//HintName: G.Models.GetCustomRewardRedemptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCustomRewardRedemptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CANCELED,
        /// <summary>
        /// 
        /// </summary>
        FULFILLED,
        /// <summary>
        /// 
        /// </summary>
        UNFULFILLED,
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
                GetCustomRewardRedemptionStatus.CANCELED => "CANCELED",
                GetCustomRewardRedemptionStatus.FULFILLED => "FULFILLED",
                GetCustomRewardRedemptionStatus.UNFULFILLED => "UNFULFILLED",
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
                "CANCELED" => GetCustomRewardRedemptionStatus.CANCELED,
                "FULFILLED" => GetCustomRewardRedemptionStatus.FULFILLED,
                "UNFULFILLED" => GetCustomRewardRedemptionStatus.UNFULFILLED,
                _ => null,
            };
        }
    }
}