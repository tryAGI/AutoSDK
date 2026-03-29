//HintName: G.Models.PlayHTVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlayHTVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Chris,
        /// <summary>
        /// 
        /// </summary>
        Davis,
        /// <summary>
        /// 
        /// </summary>
        Donna,
        /// <summary>
        /// 
        /// </summary>
        Jack,
        /// <summary>
        /// 
        /// </summary>
        Jennifer,
        /// <summary>
        /// 
        /// </summary>
        Matt,
        /// <summary>
        /// 
        /// </summary>
        Melissa,
        /// <summary>
        /// 
        /// </summary>
        Michael,
        /// <summary>
        /// 
        /// </summary>
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        Will,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayHTVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayHTVoiceVoiceId value)
        {
            return value switch
            {
                PlayHTVoiceVoiceId.Chris => "chris",
                PlayHTVoiceVoiceId.Davis => "davis",
                PlayHTVoiceVoiceId.Donna => "donna",
                PlayHTVoiceVoiceId.Jack => "jack",
                PlayHTVoiceVoiceId.Jennifer => "jennifer",
                PlayHTVoiceVoiceId.Matt => "matt",
                PlayHTVoiceVoiceId.Melissa => "melissa",
                PlayHTVoiceVoiceId.Michael => "michael",
                PlayHTVoiceVoiceId.Ruby => "ruby",
                PlayHTVoiceVoiceId.Will => "will",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayHTVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "chris" => PlayHTVoiceVoiceId.Chris,
                "davis" => PlayHTVoiceVoiceId.Davis,
                "donna" => PlayHTVoiceVoiceId.Donna,
                "jack" => PlayHTVoiceVoiceId.Jack,
                "jennifer" => PlayHTVoiceVoiceId.Jennifer,
                "matt" => PlayHTVoiceVoiceId.Matt,
                "melissa" => PlayHTVoiceVoiceId.Melissa,
                "michael" => PlayHTVoiceVoiceId.Michael,
                "ruby" => PlayHTVoiceVoiceId.Ruby,
                "will" => PlayHTVoiceVoiceId.Will,
                _ => null,
            };
        }
    }
}