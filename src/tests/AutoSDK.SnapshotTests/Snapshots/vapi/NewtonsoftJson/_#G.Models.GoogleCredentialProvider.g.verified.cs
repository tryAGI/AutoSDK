//HintName: G.Models.GoogleCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the key for Gemini in Google AI Studio. Get it from here: https://aistudio.google.com/app/apikey
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleCredentialProvider
    {
        /// <summary>
        /// https://aistudio.google.com/app/apikey
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleCredentialProvider value)
        {
            return value switch
            {
                GoogleCredentialProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => GoogleCredentialProvider.Google,
                _ => null,
            };
        }
    }
}