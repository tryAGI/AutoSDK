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
        Eve,
        /// <summary>
        /// 
        /// </summary>
        Ara,
        /// <summary>
        /// 
        /// </summary>
        Rex,
        /// <summary>
        /// 
        /// </summary>
        Sal,
        /// <summary>
        /// 
        /// </summary>
        Leo,
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
                SessionConfigVoice.Eve => "Eve",
                SessionConfigVoice.Ara => "Ara",
                SessionConfigVoice.Rex => "Rex",
                SessionConfigVoice.Sal => "Sal",
                SessionConfigVoice.Leo => "Leo",
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
                "Eve" => SessionConfigVoice.Eve,
                "Ara" => SessionConfigVoice.Ara,
                "Rex" => SessionConfigVoice.Rex,
                "Sal" => SessionConfigVoice.Sal,
                "Leo" => SessionConfigVoice.Leo,
                _ => null,
            };
        }
    }
}