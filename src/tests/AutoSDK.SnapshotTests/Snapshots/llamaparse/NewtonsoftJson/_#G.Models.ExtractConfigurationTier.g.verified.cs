//HintName: G.Models.ExtractConfigurationTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extract tier: cost_effective (5 credits/page) or agentic (15 credits/page)<br/>
    /// Default Value: cost_effective
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractConfigurationTier
    {
        /// <summary>
        /// cost_effective (5 credits/page) or agentic (15 credits/page)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentic")]
        Agentic,
        /// <summary>
        /// cost_effective (5 credits/page) or agentic (15 credits/page)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost_effective")]
        CostEffective,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractConfigurationTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractConfigurationTier value)
        {
            return value switch
            {
                ExtractConfigurationTier.Agentic => "agentic",
                ExtractConfigurationTier.CostEffective => "cost_effective",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractConfigurationTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractConfigurationTier.Agentic,
                "cost_effective" => ExtractConfigurationTier.CostEffective,
                _ => null,
            };
        }
    }
}