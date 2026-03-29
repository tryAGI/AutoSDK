//HintName: G.Models.FallbackCustomTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used. Use `custom-transcriber` for providers that are not natively supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackCustomTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-transcriber")]
        CustomTranscriber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackCustomTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCustomTranscriberProvider value)
        {
            return value switch
            {
                FallbackCustomTranscriberProvider.CustomTranscriber => "custom-transcriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCustomTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-transcriber" => FallbackCustomTranscriberProvider.CustomTranscriber,
                _ => null,
            };
        }
    }
}