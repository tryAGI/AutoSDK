//HintName: G.Models.ConfiguredRulesStyleAndToneDirectionalLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Directional Language
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneDirectionalLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_directional_language")]
        DoNotUseDirectionalLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneDirectionalLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneDirectionalLanguage value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneDirectionalLanguage.DoNotUseDirectionalLanguage => "do_not_use_directional_language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneDirectionalLanguage? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_directional_language" => ConfiguredRulesStyleAndToneDirectionalLanguage.DoNotUseDirectionalLanguage,
                _ => null,
            };
        }
    }
}