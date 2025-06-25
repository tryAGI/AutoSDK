//HintName: G.Models.UpdateDropsEntitlementsBodyFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fulfillment status to set the entitlements to. Possible values are:  <br/>
    ///   <br/>
    /// * CLAIMED — The user claimed the benefit.<br/>
    /// * FULFILLED — The developer granted the benefit that the user claimed.
    /// </summary>
    public enum UpdateDropsEntitlementsBodyFulfillmentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CLAIMED,
        /// <summary>
        /// 
        /// </summary>
        FULFILLED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDropsEntitlementsBodyFulfillmentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDropsEntitlementsBodyFulfillmentStatus value)
        {
            return value switch
            {
                UpdateDropsEntitlementsBodyFulfillmentStatus.CLAIMED => "CLAIMED",
                UpdateDropsEntitlementsBodyFulfillmentStatus.FULFILLED => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDropsEntitlementsBodyFulfillmentStatus? ToEnum(string value)
        {
            return value switch
            {
                "CLAIMED" => UpdateDropsEntitlementsBodyFulfillmentStatus.CLAIMED,
                "FULFILLED" => UpdateDropsEntitlementsBodyFulfillmentStatus.FULFILLED,
                _ => null,
            };
        }
    }
}