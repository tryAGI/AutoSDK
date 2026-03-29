//HintName: G.Models.FallbackCustomVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used. Use `custom-voice` for providers that are not natively supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackCustomVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-voice")]
        CustomVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackCustomVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCustomVoiceProvider value)
        {
            return value switch
            {
                FallbackCustomVoiceProvider.CustomVoice => "custom-voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCustomVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-voice" => FallbackCustomVoiceProvider.CustomVoice,
                _ => null,
            };
        }
    }
}