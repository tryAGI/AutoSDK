//HintName: G.Models.GoogleTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleTranscriberProvider value)
        {
            return value switch
            {
                GoogleTranscriberProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => GoogleTranscriberProvider.Google,
                _ => null,
            };
        }
    }
}