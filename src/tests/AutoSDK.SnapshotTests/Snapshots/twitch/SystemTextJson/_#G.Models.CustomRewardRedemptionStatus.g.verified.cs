//HintName: G.Models.CustomRewardRedemptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the redemption. Possible values are:  <br/>
    ///   <br/>
    /// * CANCELED<br/>
    /// * FULFILLED<br/>
    /// * UNFULFILLED
    /// </summary>
    public enum CustomRewardRedemptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Fulfilled,
        /// <summary>
        /// 
        /// </summary>
        Unfulfilled,
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
                CustomRewardRedemptionStatus.Canceled => "CANCELED",
                CustomRewardRedemptionStatus.Fulfilled => "FULFILLED",
                CustomRewardRedemptionStatus.Unfulfilled => "UNFULFILLED",
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
                "CANCELED" => CustomRewardRedemptionStatus.Canceled,
                "FULFILLED" => CustomRewardRedemptionStatus.Fulfilled,
                "UNFULFILLED" => CustomRewardRedemptionStatus.Unfulfilled,
                _ => null,
            };
        }
    }
}