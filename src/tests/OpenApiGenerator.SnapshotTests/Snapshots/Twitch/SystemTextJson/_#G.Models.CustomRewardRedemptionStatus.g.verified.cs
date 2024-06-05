//HintName: G.Models.CustomRewardRedemptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the redemption. Possible values are:  
    ///   
    /// * CANCELED
    /// * FULFILLED
    /// * UNFULFILLED
    /// </summary>
    public enum CustomRewardRedemptionStatus
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
    public static class CustomRewardRedemptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomRewardRedemptionStatus value)
        {
            return value switch
            {
                CustomRewardRedemptionStatus.CANCELED => "CANCELED",
                CustomRewardRedemptionStatus.FULFILLED => "FULFILLED",
                CustomRewardRedemptionStatus.UNFULFILLED => "UNFULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomRewardRedemptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CustomRewardRedemptionStatus.CANCELED,
                "FULFILLED" => CustomRewardRedemptionStatus.FULFILLED,
                "UNFULFILLED" => CustomRewardRedemptionStatus.UNFULFILLED,
                _ => null,
            };
        }
    }
}