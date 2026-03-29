//HintName: G.Models.RateLimitsPolicyUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rate unit
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RateLimitsPolicyUnit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rpd")]
        Rpd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rph")]
        Rph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rpm")]
        Rpm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitsPolicyUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitsPolicyUnit value)
        {
            return value switch
            {
                RateLimitsPolicyUnit.Rpd => "rpd",
                RateLimitsPolicyUnit.Rph => "rph",
                RateLimitsPolicyUnit.Rpm => "rpm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitsPolicyUnit? ToEnum(string value)
        {
            return value switch
            {
                "rpd" => RateLimitsPolicyUnit.Rpd,
                "rph" => RateLimitsPolicyUnit.Rph,
                "rpm" => RateLimitsPolicyUnit.Rpm,
                _ => null,
            };
        }
    }
}