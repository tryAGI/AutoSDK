//HintName: G.Models.SesameVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum SesameVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Sesame,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SesameVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SesameVoiceProvider value)
        {
            return value switch
            {
                SesameVoiceProvider.Sesame => "sesame",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SesameVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "sesame" => SesameVoiceProvider.Sesame,
                _ => null,
            };
        }
    }
}