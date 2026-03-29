//HintName: G.Models.ConfiguredRulesStyleAndToneTone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Tone
    /// </summary>
    public enum ConfiguredRulesStyleAndToneTone
    {
        /// <summary>
        /// 
        /// </summary>
        UseDearuStyleToGiveImpressionContentIsAccurateAndRigorousOrToConveySenseOfConfidenceAndReliability,
        /// <summary>
        /// 
        /// </summary>
        UseDesuMasuStyleToGiveImpressionContentIsPlainAndStraightforwardOrToGiveReaderReassuringOrSoftImpression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneTone value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneTone.UseDearuStyleToGiveImpressionContentIsAccurateAndRigorousOrToConveySenseOfConfidenceAndReliability => "use_dearu_style_to_give_impression_content_is_accurate_and_rigorous_or_to_convey_sense_of_confidence_and_reliability",
                ConfiguredRulesStyleAndToneTone.UseDesuMasuStyleToGiveImpressionContentIsPlainAndStraightforwardOrToGiveReaderReassuringOrSoftImpression => "use_desu_masu_style_to_give_impression_content_is_plain_and_straightforward_or_to_give_reader_reassuring_or_soft_impression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneTone? ToEnum(string value)
        {
            return value switch
            {
                "use_dearu_style_to_give_impression_content_is_accurate_and_rigorous_or_to_convey_sense_of_confidence_and_reliability" => ConfiguredRulesStyleAndToneTone.UseDearuStyleToGiveImpressionContentIsAccurateAndRigorousOrToConveySenseOfConfidenceAndReliability,
                "use_desu_masu_style_to_give_impression_content_is_plain_and_straightforward_or_to_give_reader_reassuring_or_soft_impression" => ConfiguredRulesStyleAndToneTone.UseDesuMasuStyleToGiveImpressionContentIsPlainAndStraightforwardOrToGiveReaderReassuringOrSoftImpression,
                _ => null,
            };
        }
    }
}