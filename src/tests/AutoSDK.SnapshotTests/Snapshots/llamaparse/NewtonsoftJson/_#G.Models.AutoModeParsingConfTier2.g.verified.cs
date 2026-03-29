//HintName: G.Models.AutoModeParsingConfTier2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutoModeParsingConfTier2
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