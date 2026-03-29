//HintName: G.Models.ExtractV2ParametersTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extract tier: cost_effective (5 credits/page) or agentic (15 credits/page)<br/>
    /// Default Value: cost_effective
    /// </summary>
    public enum ExtractV2ParametersTier
    {
        /// <summary>
        /// cost_effective (5 credits/page) or agentic (15 credits/page)
        /// </summary>
        Agentic,
        /// <summary>
        /// cost_effective (5 credits/page) or agentic (15 credits/page)
        /// </summary>
        CostEffective,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractV2ParametersTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractV2ParametersTier value)
        {
            return value switch
            {
                ExtractV2ParametersTier.Agentic => "agentic",
                ExtractV2ParametersTier.CostEffective => "cost_effective",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractV2ParametersTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractV2ParametersTier.Agentic,
                "cost_effective" => ExtractV2ParametersTier.CostEffective,
                _ => null,
            };
        }
    }
}