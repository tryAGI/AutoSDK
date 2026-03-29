//HintName: G.Models.AgentRequestVocabSpecialization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If set, determines the vocabulary set to use for transcription. This setting only applies for English agents, for non English agent, this setting is a no-op. Default to general.<br/>
    /// Example: general
    /// </summary>
    public enum AgentRequestVocabSpecialization
    {
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        Medical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestVocabSpecializationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestVocabSpecialization value)
        {
            return value switch
            {
                AgentRequestVocabSpecialization.General => "general",
                AgentRequestVocabSpecialization.Medical => "medical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestVocabSpecialization? ToEnum(string value)
        {
            return value switch
            {
                "general" => AgentRequestVocabSpecialization.General,
                "medical" => AgentRequestVocabSpecialization.Medical,
                _ => null,
            };
        }
    }
}