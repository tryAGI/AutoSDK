//HintName: G.Models.DropsEntitlementFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entitlement’s fulfillment status. Possible values are:   
    ///   
    /// * CLAIMED
    /// * FULFILLED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DropsEntitlementFulfillmentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLAIMED")]
        CLAIMED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FULFILLED")]
        FULFILLED,
    }

    public static class DropsEntitlementFulfillmentStatusExtensions
    {
        public static string ToValueString(this DropsEntitlementFulfillmentStatus value)
        {
            return value switch
            {
                DropsEntitlementFulfillmentStatus.CLAIMED => "CLAIMED",
                DropsEntitlementFulfillmentStatus.FULFILLED => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DropsEntitlementFulfillmentStatus ToEnum(string value)
        {
            return value switch
            {
                "CLAIMED" => DropsEntitlementFulfillmentStatus.CLAIMED,
                "FULFILLED" => DropsEntitlementFulfillmentStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DropsEntitlementFulfillmentStatus ToEnum(int value)
        {
            return value switch
            {
                0 => DropsEntitlementFulfillmentStatus.CLAIMED,
                1 => DropsEntitlementFulfillmentStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}