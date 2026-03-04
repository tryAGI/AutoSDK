//HintName: G.Models.UpdateRedemptionStatusBodyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status to set the redemption to. Possible values are:  <br/>
    ///   <br/>
    /// * CANCELED<br/>
    /// * FULFILLED<br/>
    ///   <br/>
    /// Setting the status to CANCELED refunds the user’s channel points.
    /// </summary>
    public enum UpdateRedemptionStatusBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Fulfilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRedemptionStatusBodyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRedemptionStatusBodyStatus value)
        {
            return value switch
            {
                UpdateRedemptionStatusBodyStatus.Canceled => "CANCELED",
                UpdateRedemptionStatusBodyStatus.Fulfilled => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRedemptionStatusBodyStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => UpdateRedemptionStatusBodyStatus.Canceled,
                "FULFILLED" => UpdateRedemptionStatusBodyStatus.Fulfilled,
                _ => null,
            };
        }
    }
}