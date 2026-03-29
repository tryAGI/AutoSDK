//HintName: G.Models.ConfiguredRulesStyleAndToneInstructionsStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Instructions Style
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneInstructionsStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_imperative")]
        UseImperative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_indicative")]
        UseIndicative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_infinitive")]
        UseInfinitive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_modal_verbs")]
        UseModalVerbs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_passive_voice")]
        UsePassiveVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneInstructionsStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneInstructionsStyle value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneInstructionsStyle.UseImperative => "use_imperative",
                ConfiguredRulesStyleAndToneInstructionsStyle.UseIndicative => "use_indicative",
                ConfiguredRulesStyleAndToneInstructionsStyle.UseInfinitive => "use_infinitive",
                ConfiguredRulesStyleAndToneInstructionsStyle.UseModalVerbs => "use_modal_verbs",
                ConfiguredRulesStyleAndToneInstructionsStyle.UsePassiveVoice => "use_passive_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneInstructionsStyle? ToEnum(string value)
        {
            return value switch
            {
                "use_imperative" => ConfiguredRulesStyleAndToneInstructionsStyle.UseImperative,
                "use_indicative" => ConfiguredRulesStyleAndToneInstructionsStyle.UseIndicative,
                "use_infinitive" => ConfiguredRulesStyleAndToneInstructionsStyle.UseInfinitive,
                "use_modal_verbs" => ConfiguredRulesStyleAndToneInstructionsStyle.UseModalVerbs,
                "use_passive_voice" => ConfiguredRulesStyleAndToneInstructionsStyle.UsePassiveVoice,
                _ => null,
            };
        }
    }
}