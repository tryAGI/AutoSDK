//HintName: G.Models.LLMConfigGoogleProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigGoogleProvider
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
    public static class LLMConfigGoogleProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigGoogleProvider value)
        {
            return value switch
            {
                LLMConfigGoogleProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigGoogleProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => LLMConfigGoogleProvider.Google,
                _ => null,
            };
        }
    }
}