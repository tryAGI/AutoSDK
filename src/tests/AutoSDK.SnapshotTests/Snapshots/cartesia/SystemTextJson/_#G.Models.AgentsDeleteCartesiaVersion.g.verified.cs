//HintName: G.Models.AgentsDeleteCartesiaVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: 2025-04-16
    /// </summary>
    public enum AgentsDeleteCartesiaVersion
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
    public static class AgentsDeleteCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsDeleteCartesiaVersion value)
        {
            return value switch
            {
                AgentsDeleteCartesiaVersion.x20240610 => "2024-06-10",
                AgentsDeleteCartesiaVersion.x20241113 => "2024-11-13",
                AgentsDeleteCartesiaVersion.x20250416 => "2025-04-16",
                AgentsDeleteCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsDeleteCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-06-10" => AgentsDeleteCartesiaVersion.x20240610,
                "2024-11-13" => AgentsDeleteCartesiaVersion.x20241113,
                "2025-04-16" => AgentsDeleteCartesiaVersion.x20250416,
                "2025-11-04" => AgentsDeleteCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}