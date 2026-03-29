//HintName: G.Models.CreateRateLimitsPolicyRequestUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rate unit:<br/>
    /// - `rpm` - Requests/Tokens per minute<br/>
    /// - `rph` - Requests/Tokens per hour<br/>
    /// - `rpd` - Requests/Tokens per day
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRateLimitsPolicyRequestUnit
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
    public static class CreateRateLimitsPolicyRequestUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRateLimitsPolicyRequestUnit value)
        {
            return value switch
            {
                CreateRateLimitsPolicyRequestUnit.Rpd => "rpd",
                CreateRateLimitsPolicyRequestUnit.Rph => "rph",
                CreateRateLimitsPolicyRequestUnit.Rpm => "rpm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRateLimitsPolicyRequestUnit? ToEnum(string value)
        {
            return value switch
            {
                "rpd" => CreateRateLimitsPolicyRequestUnit.Rpd,
                "rph" => CreateRateLimitsPolicyRequestUnit.Rph,
                "rpm" => CreateRateLimitsPolicyRequestUnit.Rpm,
                _ => null,
            };
        }
    }
}