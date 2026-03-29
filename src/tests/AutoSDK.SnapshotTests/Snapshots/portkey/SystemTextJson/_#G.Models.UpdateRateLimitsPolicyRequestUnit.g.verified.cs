//HintName: G.Models.UpdateRateLimitsPolicyRequestUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rate unit
    /// </summary>
    public enum UpdateRateLimitsPolicyRequestUnit
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
    public static class UpdateRateLimitsPolicyRequestUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRateLimitsPolicyRequestUnit value)
        {
            return value switch
            {
                UpdateRateLimitsPolicyRequestUnit.Rpd => "rpd",
                UpdateRateLimitsPolicyRequestUnit.Rph => "rph",
                UpdateRateLimitsPolicyRequestUnit.Rpm => "rpm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRateLimitsPolicyRequestUnit? ToEnum(string value)
        {
            return value switch
            {
                "rpd" => UpdateRateLimitsPolicyRequestUnit.Rpd,
                "rph" => UpdateRateLimitsPolicyRequestUnit.Rph,
                "rpm" => UpdateRateLimitsPolicyRequestUnit.Rpm,
                _ => null,
            };
        }
    }
}