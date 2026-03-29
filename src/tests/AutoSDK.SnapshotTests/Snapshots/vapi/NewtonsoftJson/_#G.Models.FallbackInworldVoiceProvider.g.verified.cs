//HintName: G.Models.FallbackInworldVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackInworldVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inworld")]
        Inworld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackInworldVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackInworldVoiceProvider value)
        {
            return value switch
            {
                FallbackInworldVoiceProvider.Inworld => "inworld",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackInworldVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "inworld" => FallbackInworldVoiceProvider.Inworld,
                _ => null,
            };
        }
    }
}