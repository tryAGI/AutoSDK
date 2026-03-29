//HintName: G.Models.ParseRequestConfigurationTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parsing tier: 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
    /// </summary>
    public enum ParseRequestConfigurationTier
    {
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        Agentic,
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        AgenticPlus,
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        CostEffective,
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseRequestConfigurationTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseRequestConfigurationTier value)
        {
            return value switch
            {
                ParseRequestConfigurationTier.Agentic => "agentic",
                ParseRequestConfigurationTier.AgenticPlus => "agentic_plus",
                ParseRequestConfigurationTier.CostEffective => "cost_effective",
                ParseRequestConfigurationTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseRequestConfigurationTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ParseRequestConfigurationTier.Agentic,
                "agentic_plus" => ParseRequestConfigurationTier.AgenticPlus,
                "cost_effective" => ParseRequestConfigurationTier.CostEffective,
                "fast" => ParseRequestConfigurationTier.Fast,
                _ => null,
            };
        }
    }
}