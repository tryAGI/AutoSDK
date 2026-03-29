//HintName: G.Models.FallbackPlayHTVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackPlayHTVoiceVoiceId
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
    public static class FallbackPlayHTVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackPlayHTVoiceVoiceId value)
        {
            return value switch
            {
                FallbackPlayHTVoiceVoiceId.Chris => "chris",
                FallbackPlayHTVoiceVoiceId.Davis => "davis",
                FallbackPlayHTVoiceVoiceId.Donna => "donna",
                FallbackPlayHTVoiceVoiceId.Jack => "jack",
                FallbackPlayHTVoiceVoiceId.Jennifer => "jennifer",
                FallbackPlayHTVoiceVoiceId.Matt => "matt",
                FallbackPlayHTVoiceVoiceId.Melissa => "melissa",
                FallbackPlayHTVoiceVoiceId.Michael => "michael",
                FallbackPlayHTVoiceVoiceId.Ruby => "ruby",
                FallbackPlayHTVoiceVoiceId.Will => "will",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackPlayHTVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "chris" => FallbackPlayHTVoiceVoiceId.Chris,
                "davis" => FallbackPlayHTVoiceVoiceId.Davis,
                "donna" => FallbackPlayHTVoiceVoiceId.Donna,
                "jack" => FallbackPlayHTVoiceVoiceId.Jack,
                "jennifer" => FallbackPlayHTVoiceVoiceId.Jennifer,
                "matt" => FallbackPlayHTVoiceVoiceId.Matt,
                "melissa" => FallbackPlayHTVoiceVoiceId.Melissa,
                "michael" => FallbackPlayHTVoiceVoiceId.Michael,
                "ruby" => FallbackPlayHTVoiceVoiceId.Ruby,
                "will" => FallbackPlayHTVoiceVoiceId.Will,
                _ => null,
            };
        }
    }
}