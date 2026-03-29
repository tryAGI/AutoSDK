//HintName: G.Models.FallbackDeepgramTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackDeepgramTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepgram")]
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackDeepgramTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackDeepgramTranscriberProvider value)
        {
            return value switch
            {
                FallbackDeepgramTranscriberProvider.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackDeepgramTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => FallbackDeepgramTranscriberProvider.Deepgram,
                _ => null,
            };
        }
    }
}