//HintName: G.Models.CustomVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used. Use `custom-voice` for providers that are not natively supported.
    /// </summary>
    public enum CustomVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomVoiceProvider value)
        {
            return value switch
            {
                CustomVoiceProvider.CustomVoice => "custom-voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-voice" => CustomVoiceProvider.CustomVoice,
                _ => null,
            };
        }
    }
}