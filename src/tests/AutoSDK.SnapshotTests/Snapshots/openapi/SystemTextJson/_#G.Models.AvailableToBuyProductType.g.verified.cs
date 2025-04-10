//HintName: G.Models.AvailableToBuyProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AvailableToBuyProductType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AvailableToBuyProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AvailableToBuyProductType value)
        {
            return value switch
            {
                AvailableToBuyProductType.Membership30Days => "Membership30Days",
                AvailableToBuyProductType.Membership365Days => "Membership365Days",
                AvailableToBuyProductType.XTeraShare => "XTeraShare",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AvailableToBuyProductType? ToEnum(string value)
        {
            return value switch
            {
                "Membership30Days" => AvailableToBuyProductType.Membership30Days,
                "Membership365Days" => AvailableToBuyProductType.Membership365Days,
                "XTeraShare" => AvailableToBuyProductType.XTeraShare,
                _ => null,
            };
        }
    }
}