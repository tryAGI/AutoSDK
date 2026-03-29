//HintName: G.Models.ConfiguredRulesStyleAndToneDeclarativeEndings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Declarative Endings
    /// </summary>
    public enum ConfiguredRulesStyleAndToneDeclarativeEndings
    {
        /// <summary>
        /// 
        /// </summary>
        MixHapshoAndHaeyoStyles,
        /// <summary>
        /// 
        /// </summary>
        UseHaeStyle,
        /// <summary>
        /// 
        /// </summary>
        UseHaeyoStyle,
        /// <summary>
        /// 
        /// </summary>
        UseHapshoStyle,
        /// <summary>
        /// 
        /// </summary>
        UseHaraStyle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneDeclarativeEndingsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneDeclarativeEndings value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneDeclarativeEndings.MixHapshoAndHaeyoStyles => "mix_hapsho_and_haeyo_styles",
                ConfiguredRulesStyleAndToneDeclarativeEndings.UseHaeStyle => "use_hae_style",
                ConfiguredRulesStyleAndToneDeclarativeEndings.UseHaeyoStyle => "use_haeyo_style",
                ConfiguredRulesStyleAndToneDeclarativeEndings.UseHapshoStyle => "use_hapsho_style",
                ConfiguredRulesStyleAndToneDeclarativeEndings.UseHaraStyle => "use_hara_style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneDeclarativeEndings? ToEnum(string value)
        {
            return value switch
            {
                "mix_hapsho_and_haeyo_styles" => ConfiguredRulesStyleAndToneDeclarativeEndings.MixHapshoAndHaeyoStyles,
                "use_hae_style" => ConfiguredRulesStyleAndToneDeclarativeEndings.UseHaeStyle,
                "use_haeyo_style" => ConfiguredRulesStyleAndToneDeclarativeEndings.UseHaeyoStyle,
                "use_hapsho_style" => ConfiguredRulesStyleAndToneDeclarativeEndings.UseHapshoStyle,
                "use_hara_style" => ConfiguredRulesStyleAndToneDeclarativeEndings.UseHaraStyle,
                _ => null,
            };
        }
    }
}