//HintName: G.Models.SessionConfigVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice to use for audio output.
    /// </summary>
    public enum SessionConfigVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Ara,
        /// <summary>
        /// 
        /// </summary>
        Eve,
        /// <summary>
        /// 
        /// </summary>
        Leo,
        /// <summary>
        /// 
        /// </summary>
        Rex,
        /// <summary>
        /// 
        /// </summary>
        Sal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionConfigVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionConfigVoice value)
        {
            return value switch
            {
                SessionConfigVoice.Ara => "Ara",
                SessionConfigVoice.Eve => "Eve",
                SessionConfigVoice.Leo => "Leo",
                SessionConfigVoice.Rex => "Rex",
                SessionConfigVoice.Sal => "Sal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionConfigVoice? ToEnum(string value)
        {
            return value switch
            {
                "Ara" => SessionConfigVoice.Ara,
                "Eve" => SessionConfigVoice.Eve,
                "Leo" => SessionConfigVoice.Leo,
                "Rex" => SessionConfigVoice.Rex,
                "Sal" => SessionConfigVoice.Sal,
                _ => null,
            };
        }
    }
}