//HintName: G.Models.GoogleLLMCreateDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleLLMCreateDtoProvider
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
    public static class GoogleLLMCreateDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleLLMCreateDtoProvider value)
        {
            return value switch
            {
                GoogleLLMCreateDtoProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleLLMCreateDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => GoogleLLMCreateDtoProvider.Google,
                _ => null,
            };
        }
    }
}