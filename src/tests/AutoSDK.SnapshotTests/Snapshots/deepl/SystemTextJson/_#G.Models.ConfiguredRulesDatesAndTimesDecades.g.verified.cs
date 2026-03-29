//HintName: G.Models.ConfiguredRulesDatesAndTimesDecades.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Decades
    /// </summary>
    public enum ConfiguredRulesDatesAndTimesDecades
    {
        /// <summary>
        /// 
        /// </summary>
        SpellOut,
        /// <summary>
        /// 
        /// </summary>
        UseApostropheYy,
        /// <summary>
        /// 
        /// </summary>
        UseYyFor20thCenturyButYyyyForOtherCenturies,
        /// <summary>
        /// 
        /// </summary>
        UseYyWithoutApostrophe,
        /// <summary>
        /// 
        /// </summary>
        UseYyyy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesDecadesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesDecades value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesDecades.SpellOut => "spell_out",
                ConfiguredRulesDatesAndTimesDecades.UseApostropheYy => "use_apostrophe_yy",
                ConfiguredRulesDatesAndTimesDecades.UseYyFor20thCenturyButYyyyForOtherCenturies => "use_yy_for_20th_century_but_yyyy_for_other_centuries",
                ConfiguredRulesDatesAndTimesDecades.UseYyWithoutApostrophe => "use_yy_without_apostrophe",
                ConfiguredRulesDatesAndTimesDecades.UseYyyy => "use_yyyy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesDecades? ToEnum(string value)
        {
            return value switch
            {
                "spell_out" => ConfiguredRulesDatesAndTimesDecades.SpellOut,
                "use_apostrophe_yy" => ConfiguredRulesDatesAndTimesDecades.UseApostropheYy,
                "use_yy_for_20th_century_but_yyyy_for_other_centuries" => ConfiguredRulesDatesAndTimesDecades.UseYyFor20thCenturyButYyyyForOtherCenturies,
                "use_yy_without_apostrophe" => ConfiguredRulesDatesAndTimesDecades.UseYyWithoutApostrophe,
                "use_yyyy" => ConfiguredRulesDatesAndTimesDecades.UseYyyy,
                _ => null,
            };
        }
    }
}