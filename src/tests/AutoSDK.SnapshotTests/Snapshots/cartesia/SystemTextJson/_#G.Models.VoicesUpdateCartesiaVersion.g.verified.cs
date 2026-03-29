//HintName: G.Models.VoicesUpdateCartesiaVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: 2025-04-16
    /// </summary>
    public enum VoicesUpdateCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20240610,
        /// <summary>
        /// 
        /// </summary>
        x20241113,
        /// <summary>
        /// 
        /// </summary>
        x20250416,
        /// <summary>
        /// 
        /// </summary>
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesUpdateCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesUpdateCartesiaVersion value)
        {
            return value switch
            {
                VoicesUpdateCartesiaVersion.x20240610 => "2024-06-10",
                VoicesUpdateCartesiaVersion.x20241113 => "2024-11-13",
                VoicesUpdateCartesiaVersion.x20250416 => "2025-04-16",
                VoicesUpdateCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesUpdateCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-06-10" => VoicesUpdateCartesiaVersion.x20240610,
                "2024-11-13" => VoicesUpdateCartesiaVersion.x20241113,
                "2025-04-16" => VoicesUpdateCartesiaVersion.x20250416,
                "2025-11-04" => VoicesUpdateCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}