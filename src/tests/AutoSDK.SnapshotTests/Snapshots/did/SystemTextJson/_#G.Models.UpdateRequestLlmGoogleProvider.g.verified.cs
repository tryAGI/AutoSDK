//HintName: G.Models.UpdateRequestLlmGoogleProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum UpdateRequestLlmGoogleProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRequestLlmGoogleProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmGoogleProvider value)
        {
            return value switch
            {
                UpdateRequestLlmGoogleProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmGoogleProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => UpdateRequestLlmGoogleProvider.Google,
                _ => null,
            };
        }
    }
}