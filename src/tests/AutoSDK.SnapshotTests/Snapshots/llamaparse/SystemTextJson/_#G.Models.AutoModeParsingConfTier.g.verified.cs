//HintName: G.Models.AutoModeParsingConfTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoModeParsingConfTier
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
    public static class AutoModeParsingConfTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoModeParsingConfTier value)
        {
            return value switch
            {
                AutoModeParsingConfTier.Agentic => "agentic",
                AutoModeParsingConfTier.AgenticPlus => "agentic_plus",
                AutoModeParsingConfTier.CostEffective => "cost_effective",
                AutoModeParsingConfTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoModeParsingConfTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => AutoModeParsingConfTier.Agentic,
                "agentic_plus" => AutoModeParsingConfTier.AgenticPlus,
                "cost_effective" => AutoModeParsingConfTier.CostEffective,
                "fast" => AutoModeParsingConfTier.Fast,
                _ => null,
            };
        }
    }
}