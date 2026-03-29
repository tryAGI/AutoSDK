//HintName: G.Models.ConfiguredRulesStyleAndToneReaderActionRequired.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Reader Action Required
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneReaderActionRequired
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_you_must_when_action_is_required_from_reader")]
        UseYouMustWhenActionIsRequiredFromReader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneReaderActionRequiredExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneReaderActionRequired value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneReaderActionRequired.UseYouMustWhenActionIsRequiredFromReader => "use_you_must_when_action_is_required_from_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneReaderActionRequired? ToEnum(string value)
        {
            return value switch
            {
                "use_you_must_when_action_is_required_from_reader" => ConfiguredRulesStyleAndToneReaderActionRequired.UseYouMustWhenActionIsRequiredFromReader,
                _ => null,
            };
        }
    }
}