//HintName: G.Models.UpdateResponseVariant1LlmGoogleProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateResponseVariant1LlmGoogleProvider
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
    public static class UpdateResponseVariant1LlmGoogleProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1LlmGoogleProvider value)
        {
            return value switch
            {
                UpdateResponseVariant1LlmGoogleProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1LlmGoogleProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => UpdateResponseVariant1LlmGoogleProvider.Google,
                _ => null,
            };
        }
    }
}