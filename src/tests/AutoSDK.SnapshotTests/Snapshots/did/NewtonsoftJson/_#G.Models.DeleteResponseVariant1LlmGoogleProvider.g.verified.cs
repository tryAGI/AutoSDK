//HintName: G.Models.DeleteResponseVariant1LlmGoogleProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteResponseVariant1LlmGoogleProvider
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
    public static class DeleteResponseVariant1LlmGoogleProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1LlmGoogleProvider value)
        {
            return value switch
            {
                DeleteResponseVariant1LlmGoogleProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1LlmGoogleProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => DeleteResponseVariant1LlmGoogleProvider.Google,
                _ => null,
            };
        }
    }
}