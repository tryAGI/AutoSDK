//HintName: G.Models.ConfiguredRulesStyleAndToneReferringToNonBinaryPeople.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Referring To Non Binary People
    /// </summary>
    public enum ConfiguredRulesStyleAndToneReferringToNonBinaryPeople
    {
        /// <summary>
        /// 
        /// </summary>
        UseTheSingularAndPluralSchwa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneReferringToNonBinaryPeopleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneReferringToNonBinaryPeople value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneReferringToNonBinaryPeople.UseTheSingularAndPluralSchwa => "use_the_singular_and_plural_schwa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneReferringToNonBinaryPeople? ToEnum(string value)
        {
            return value switch
            {
                "use_the_singular_and_plural_schwa" => ConfiguredRulesStyleAndToneReferringToNonBinaryPeople.UseTheSingularAndPluralSchwa,
                _ => null,
            };
        }
    }
}