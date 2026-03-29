//HintName: G.Models.ConfiguredRulesStyleAndToneDeclarativeEndings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Declarative Endings
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneDeclarativeEndings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mix_hapsho_and_haeyo_styles")]
        MixHapshoAndHaeyoStyles,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hae_style")]
        UseHaeStyle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_haeyo_style")]
        UseHaeyoStyle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hapsho_style")]
        UseHapshoStyle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hara_style")]
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