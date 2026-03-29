//HintName: G.Models.RateLimitsUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RateLimitsUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Rpd,
        /// <summary>
        /// 
        /// </summary>
        Rph,
        /// <summary>
        /// 
        /// </summary>
        Rpm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitsUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitsUnit value)
        {
            return value switch
            {
                RateLimitsUnit.Rpd => "rpd",
                RateLimitsUnit.Rph => "rph",
                RateLimitsUnit.Rpm => "rpm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitsUnit? ToEnum(string value)
        {
            return value switch
            {
                "rpd" => RateLimitsUnit.Rpd,
                "rph" => RateLimitsUnit.Rph,
                "rpm" => RateLimitsUnit.Rpm,
                _ => null,
            };
        }
    }
}