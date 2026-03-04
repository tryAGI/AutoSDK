//HintName: G.Models.DropsEntitlementFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entitlement’s fulfillment status. Possible values are:   <br/>
    ///   <br/>
    /// * CLAIMED<br/>
    /// * FULFILLED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DropsEntitlementFulfillmentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLAIMED")]
        Claimed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FULFILLED")]
        Fulfilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DropsEntitlementFulfillmentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DropsEntitlementFulfillmentStatus value)
        {
            return value switch
            {
                DropsEntitlementFulfillmentStatus.Claimed => "CLAIMED",
                DropsEntitlementFulfillmentStatus.Fulfilled => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DropsEntitlementFulfillmentStatus? ToEnum(string value)
        {
            return value switch
            {
                "CLAIMED" => DropsEntitlementFulfillmentStatus.Claimed,
                "FULFILLED" => DropsEntitlementFulfillmentStatus.Fulfilled,
                _ => null,
            };
        }
    }
}