//HintName: G.Models.AutoModeParsingConfTier2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoModeParsingConfTier2
    {
        /// <summary>
        /// 
        /// </summary>
        Agentic,
        /// <summary>
        /// 
        /// </summary>
        AgenticPlus,
        /// <summary>
        /// 
        /// </summary>
        CostEffective,
        /// <summary>
        /// 
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoModeParsingConfTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoModeParsingConfTier2 value)
        {
            return value switch
            {
                AutoModeParsingConfTier2.Agentic => "agentic",
                AutoModeParsingConfTier2.AgenticPlus => "agentic_plus",
                AutoModeParsingConfTier2.CostEffective => "cost_effective",
                AutoModeParsingConfTier2.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoModeParsingConfTier2? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => AutoModeParsingConfTier2.Agentic,
                "agentic_plus" => AutoModeParsingConfTier2.AgenticPlus,
                "cost_effective" => AutoModeParsingConfTier2.CostEffective,
                "fast" => AutoModeParsingConfTier2.Fast,
                _ => null,
            };
        }
    }
}