//HintName: G.Models.LMNTVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum LMNTVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LMNTVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LMNTVoiceProvider value)
        {
            return value switch
            {
                LMNTVoiceProvider.Lmnt => "lmnt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LMNTVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "lmnt" => LMNTVoiceProvider.Lmnt,
                _ => null,
            };
        }
    }
}