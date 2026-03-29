//HintName: G.Models.CustomTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used. Use `custom-transcriber` for providers that are not natively supported.
    /// </summary>
    public enum CustomTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomTranscriber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomTranscriberProvider value)
        {
            return value switch
            {
                CustomTranscriberProvider.CustomTranscriber => "custom-transcriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-transcriber" => CustomTranscriberProvider.CustomTranscriber,
                _ => null,
            };
        }
    }
}