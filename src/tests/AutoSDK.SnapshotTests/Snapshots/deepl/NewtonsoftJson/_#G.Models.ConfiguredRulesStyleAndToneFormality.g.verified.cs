//HintName: G.Models.ConfiguredRulesStyleAndToneFormality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Formality
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneFormality
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_casual_tone")]
        UseCasualTone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_formal_tone")]
        UseFormalTone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneFormalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneFormality value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneFormality.UseCasualTone => "use_casual_tone",
                ConfiguredRulesStyleAndToneFormality.UseFormalTone => "use_formal_tone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneFormality? ToEnum(string value)
        {
            return value switch
            {
                "use_casual_tone" => ConfiguredRulesStyleAndToneFormality.UseCasualTone,
                "use_formal_tone" => ConfiguredRulesStyleAndToneFormality.UseFormalTone,
                _ => null,
            };
        }
    }
}