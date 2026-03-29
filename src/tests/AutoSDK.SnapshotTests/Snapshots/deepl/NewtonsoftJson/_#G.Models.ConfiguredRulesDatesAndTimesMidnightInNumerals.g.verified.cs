//HintName: G.Models.ConfiguredRulesDatesAndTimesMidnightInNumerals.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Midnight In Numerals
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesMidnightInNumerals
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_00_00")]
        Use0000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_24_00")]
        Use2400,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesMidnightInNumeralsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesMidnightInNumerals value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesMidnightInNumerals.Use0000 => "use_00_00",
                ConfiguredRulesDatesAndTimesMidnightInNumerals.Use2400 => "use_24_00",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesMidnightInNumerals? ToEnum(string value)
        {
            return value switch
            {
                "use_00_00" => ConfiguredRulesDatesAndTimesMidnightInNumerals.Use0000,
                "use_24_00" => ConfiguredRulesDatesAndTimesMidnightInNumerals.Use2400,
                _ => null,
            };
        }
    }
}