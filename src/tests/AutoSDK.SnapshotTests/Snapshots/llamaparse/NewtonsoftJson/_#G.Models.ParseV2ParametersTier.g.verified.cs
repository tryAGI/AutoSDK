//HintName: G.Models.ParseV2ParametersTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parsing tier: 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ParseV2ParametersTier
    {
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentic")]
        Agentic,
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentic_plus")]
        AgenticPlus,
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost_effective")]
        CostEffective,
        /// <summary>
        /// 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseV2ParametersTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseV2ParametersTier value)
        {
            return value switch
            {
                ParseV2ParametersTier.Agentic => "agentic",
                ParseV2ParametersTier.AgenticPlus => "agentic_plus",
                ParseV2ParametersTier.CostEffective => "cost_effective",
                ParseV2ParametersTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseV2ParametersTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ParseV2ParametersTier.Agentic,
                "agentic_plus" => ParseV2ParametersTier.AgenticPlus,
                "cost_effective" => ParseV2ParametersTier.CostEffective,
                "fast" => ParseV2ParametersTier.Fast,
                _ => null,
            };
        }
    }
}