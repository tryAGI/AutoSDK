//HintName: G.Models.UpdateDropsEntitlementsBodyFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fulfillment status to set the entitlements to. Possible values are:  
    ///   
    /// * CLAIMED — The user claimed the benefit.
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

    public static class UpdateDropsEntitlementsBodyFulfillmentStatusExtensions
    {
        public static string ToValueString(this UpdateDropsEntitlementsBodyFulfillmentStatus value)
        {
            return value switch
            {
                UpdateDropsEntitlementsBodyFulfillmentStatus.CLAIMED => "CLAIMED",
                UpdateDropsEntitlementsBodyFulfillmentStatus.FULFILLED => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateDropsEntitlementsBodyFulfillmentStatus ToEnum(string value)
        {
            return value switch
            {
                "CLAIMED" => UpdateDropsEntitlementsBodyFulfillmentStatus.CLAIMED,
                "FULFILLED" => UpdateDropsEntitlementsBodyFulfillmentStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateDropsEntitlementsBodyFulfillmentStatus ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateDropsEntitlementsBodyFulfillmentStatus.CLAIMED,
                1 => UpdateDropsEntitlementsBodyFulfillmentStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}