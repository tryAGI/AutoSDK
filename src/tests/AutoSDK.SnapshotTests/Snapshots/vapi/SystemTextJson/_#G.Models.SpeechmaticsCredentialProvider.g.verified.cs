//HintName: G.Models.SpeechmaticsCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechmaticsCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Speechmatics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechmaticsCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechmaticsCredentialProvider value)
        {
            return value switch
            {
                SpeechmaticsCredentialProvider.Speechmatics => "speechmatics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechmaticsCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "speechmatics" => SpeechmaticsCredentialProvider.Speechmatics,
                _ => null,
            };
        }
    }
}