//HintName: G.Models.ConfiguredRulesStyleAndToneAddressingNonBinaryPeople.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Addressing Non Binary People
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneAddressingNonBinaryPeople
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_spanish_word_elle")]
        UseSpanishWordElle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_spanish_word_ellx")]
        UseSpanishWordEllx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneAddressingNonBinaryPeopleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneAddressingNonBinaryPeople value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneAddressingNonBinaryPeople.UseSpanishWordElle => "use_spanish_word_elle",
                ConfiguredRulesStyleAndToneAddressingNonBinaryPeople.UseSpanishWordEllx => "use_spanish_word_ellx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneAddressingNonBinaryPeople? ToEnum(string value)
        {
            return value switch
            {
                "use_spanish_word_elle" => ConfiguredRulesStyleAndToneAddressingNonBinaryPeople.UseSpanishWordElle,
                "use_spanish_word_ellx" => ConfiguredRulesStyleAndToneAddressingNonBinaryPeople.UseSpanishWordEllx,
                _ => null,
            };
        }
    }
}