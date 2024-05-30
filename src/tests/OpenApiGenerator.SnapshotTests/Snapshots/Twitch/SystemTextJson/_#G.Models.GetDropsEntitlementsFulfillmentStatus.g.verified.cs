//HintName: G.Models.GetDropsEntitlementsFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDropsEntitlementsFulfillmentStatus
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

    public static class GetDropsEntitlementsFulfillmentStatusExtensions
    {
        public static string ToValueString(this GetDropsEntitlementsFulfillmentStatus value)
        {
            return value switch
            {
                GetDropsEntitlementsFulfillmentStatus.CLAIMED => "CLAIMED",
                GetDropsEntitlementsFulfillmentStatus.FULFILLED => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetDropsEntitlementsFulfillmentStatus ToEnum(string value)
        {
            return value switch
            {
                "CLAIMED" => GetDropsEntitlementsFulfillmentStatus.CLAIMED,
                "FULFILLED" => GetDropsEntitlementsFulfillmentStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetDropsEntitlementsFulfillmentStatus ToEnum(int value)
        {
            return value switch
            {
                0 => GetDropsEntitlementsFulfillmentStatus.CLAIMED,
                1 => GetDropsEntitlementsFulfillmentStatus.FULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}