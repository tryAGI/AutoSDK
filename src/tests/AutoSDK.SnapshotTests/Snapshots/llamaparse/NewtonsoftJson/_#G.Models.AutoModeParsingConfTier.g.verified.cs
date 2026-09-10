//HintName: G.Models.AutoModeParsingConfTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutoModeParsingConfTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentic")]
        Agentic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentic_plus")]
        AgenticPlus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost_effective")]
        CostEffective,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
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