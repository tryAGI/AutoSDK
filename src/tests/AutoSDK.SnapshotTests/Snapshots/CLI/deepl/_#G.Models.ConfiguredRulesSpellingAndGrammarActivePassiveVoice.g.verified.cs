//HintName: G.Models.ConfiguredRulesSpellingAndGrammarActivePassiveVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Active Passive Voice
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarActivePassiveVoice
    {
        /// <summary>
        /// 
        /// </summary>
        UseActiveVoiceIfSubjectIsProminentAndAgentIsClear,
        /// <summary>
        /// 
        /// </summary>
        UseActiveVoiceToDescribeOperationsWithUserAsSubject,
        /// <summary>
        /// 
        /// </summary>
        UseActiveVoiceUnlessAgentIsUnknownOrIrrelevant,
        /// <summary>
        /// 
        /// </summary>
        UsePassiveVoiceAsNeeded,
        /// <summary>
        /// 
        /// </summary>
        UsePassiveVoiceForAutomaticOperationsFromUserPerspective,
        /// <summary>
        /// 
        /// </summary>
        UsePassiveVoiceIfAgentIsUnknownOrIrrelevant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarActivePassiveVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarActivePassiveVoice value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UseActiveVoiceIfSubjectIsProminentAndAgentIsClear => "use_active_voice_if_subject_is_prominent_and_agent_is_clear",
                ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UseActiveVoiceToDescribeOperationsWithUserAsSubject => "use_active_voice_to_describe_operations_with_user_as_subject",
                ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UseActiveVoiceUnlessAgentIsUnknownOrIrrelevant => "use_active_voice_unless_agent_is_unknown_or_irrelevant",
                ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UsePassiveVoiceAsNeeded => "use_passive_voice_as_needed",
                ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UsePassiveVoiceForAutomaticOperationsFromUserPerspective => "use_passive_voice_for_automatic_operations_from_user_perspective",
                ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UsePassiveVoiceIfAgentIsUnknownOrIrrelevant => "use_passive_voice_if_agent_is_unknown_or_irrelevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarActivePassiveVoice? ToEnum(string value)
        {
            return value switch
            {
                "use_active_voice_if_subject_is_prominent_and_agent_is_clear" => ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UseActiveVoiceIfSubjectIsProminentAndAgentIsClear,
                "use_active_voice_to_describe_operations_with_user_as_subject" => ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UseActiveVoiceToDescribeOperationsWithUserAsSubject,
                "use_active_voice_unless_agent_is_unknown_or_irrelevant" => ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UseActiveVoiceUnlessAgentIsUnknownOrIrrelevant,
                "use_passive_voice_as_needed" => ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UsePassiveVoiceAsNeeded,
                "use_passive_voice_for_automatic_operations_from_user_perspective" => ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UsePassiveVoiceForAutomaticOperationsFromUserPerspective,
                "use_passive_voice_if_agent_is_unknown_or_irrelevant" => ConfiguredRulesSpellingAndGrammarActivePassiveVoice.UsePassiveVoiceIfAgentIsUnknownOrIrrelevant,
                _ => null,
            };
        }
    }
}