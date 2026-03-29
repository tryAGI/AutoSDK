//HintName: G.Models.AzureSpeechTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureSpeechTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure")]
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureSpeechTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureSpeechTranscriberProvider value)
        {
            return value switch
            {
                AzureSpeechTranscriberProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureSpeechTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure" => AzureSpeechTranscriberProvider.Azure,
                _ => null,
            };
        }
    }
}