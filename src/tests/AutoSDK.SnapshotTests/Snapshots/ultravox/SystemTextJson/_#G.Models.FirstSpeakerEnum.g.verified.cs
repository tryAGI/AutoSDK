//HintName: G.Models.FirstSpeakerEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FirstSpeakerEnum
    {
        /// <summary>
        /// 
        /// </summary>
        FirstSpeakerAgent,
        /// <summary>
        /// 
        /// </summary>
        FirstSpeakerUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FirstSpeakerEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FirstSpeakerEnum value)
        {
            return value switch
            {
                FirstSpeakerEnum.FirstSpeakerAgent => "FIRST_SPEAKER_AGENT",
                FirstSpeakerEnum.FirstSpeakerUser => "FIRST_SPEAKER_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FirstSpeakerEnum? ToEnum(string value)
        {
            return value switch
            {
                "FIRST_SPEAKER_AGENT" => FirstSpeakerEnum.FirstSpeakerAgent,
                "FIRST_SPEAKER_USER" => FirstSpeakerEnum.FirstSpeakerUser,
                _ => null,
            };
        }
    }
}