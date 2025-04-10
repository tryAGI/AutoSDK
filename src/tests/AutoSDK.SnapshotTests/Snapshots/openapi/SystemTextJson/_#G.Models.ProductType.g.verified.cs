//HintName: G.Models.ProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProductType
    {
        /// <summary>
        /// 
        /// </summary>
        Membership30Days,
        /// <summary>
        /// 
        /// </summary>
        Membership365Days,
        /// <summary>
        /// 
        /// </summary>
        XTeraShare,
        /// <summary>
        /// 
        /// </summary>
        XTeraSoftwareFee,
        /// <summary>
        /// 
        /// </summary>
        XTeraShareSunday,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductType value)
        {
            return value switch
            {
                ProductType.Membership30Days => "Membership30Days",
                ProductType.Membership365Days => "Membership365Days",
                ProductType.XTeraShare => "XTeraShare",
                ProductType.XTeraSoftwareFee => "XTeraSoftwareFee",
                ProductType.XTeraShareSunday => "XTeraShareSunday",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductType? ToEnum(string value)
        {
            return value switch
            {
                "Membership30Days" => ProductType.Membership30Days,
                "Membership365Days" => ProductType.Membership365Days,
                "XTeraShare" => ProductType.XTeraShare,
                "XTeraSoftwareFee" => ProductType.XTeraSoftwareFee,
                "XTeraShareSunday" => ProductType.XTeraShareSunday,
                _ => null,
            };
        }
    }
}