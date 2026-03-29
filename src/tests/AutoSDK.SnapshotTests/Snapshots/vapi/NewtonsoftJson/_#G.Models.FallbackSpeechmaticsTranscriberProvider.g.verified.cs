//HintName: G.Models.FallbackSpeechmaticsTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackSpeechmaticsTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speechmatics")]
        Speechmatics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSpeechmaticsTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSpeechmaticsTranscriberProvider value)
        {
            return value switch
            {
                FallbackSpeechmaticsTranscriberProvider.Speechmatics => "speechmatics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSpeechmaticsTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "speechmatics" => FallbackSpeechmaticsTranscriberProvider.Speechmatics,
                _ => null,
            };
        }
    }
}