//HintName: G.Models.AgentsTemplatesCartesiaVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: 2025-04-16
    /// </summary>
    public enum AgentsTemplatesCartesiaVersion
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
    public static class AgentsTemplatesCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsTemplatesCartesiaVersion value)
        {
            return value switch
            {
                AgentsTemplatesCartesiaVersion.x20240610 => "2024-06-10",
                AgentsTemplatesCartesiaVersion.x20241113 => "2024-11-13",
                AgentsTemplatesCartesiaVersion.x20250416 => "2025-04-16",
                AgentsTemplatesCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsTemplatesCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-06-10" => AgentsTemplatesCartesiaVersion.x20240610,
                "2024-11-13" => AgentsTemplatesCartesiaVersion.x20241113,
                "2025-04-16" => AgentsTemplatesCartesiaVersion.x20250416,
                "2025-11-04" => AgentsTemplatesCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}