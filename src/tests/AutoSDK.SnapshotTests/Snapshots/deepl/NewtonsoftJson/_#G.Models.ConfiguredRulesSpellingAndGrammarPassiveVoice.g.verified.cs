//HintName: G.Models.ConfiguredRulesSpellingAndGrammarPassiveVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Passive Voice
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarPassiveVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avoid_passive_voice_when_agent_is_known")]
        AvoidPassiveVoiceWhenAgentIsKnown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarPassiveVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarPassiveVoice value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarPassiveVoice.AvoidPassiveVoiceWhenAgentIsKnown => "avoid_passive_voice_when_agent_is_known",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarPassiveVoice? ToEnum(string value)
        {
            return value switch
            {
                "avoid_passive_voice_when_agent_is_known" => ConfiguredRulesSpellingAndGrammarPassiveVoice.AvoidPassiveVoiceWhenAgentIsKnown,
                _ => null,
            };
        }
    }
}