//HintName: G.Models.GetDropsEntitlementsFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDropsEntitlementsFulfillmentStatus
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
    public static class GetDropsEntitlementsFulfillmentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDropsEntitlementsFulfillmentStatus value)
        {
            return value switch
            {
                GetDropsEntitlementsFulfillmentStatus.Claimed => "CLAIMED",
                GetDropsEntitlementsFulfillmentStatus.Fulfilled => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDropsEntitlementsFulfillmentStatus? ToEnum(string value)
        {
            return value switch
            {
                "CLAIMED" => GetDropsEntitlementsFulfillmentStatus.Claimed,
                "FULFILLED" => GetDropsEntitlementsFulfillmentStatus.Fulfilled,
                _ => null,
            };
        }
    }
}