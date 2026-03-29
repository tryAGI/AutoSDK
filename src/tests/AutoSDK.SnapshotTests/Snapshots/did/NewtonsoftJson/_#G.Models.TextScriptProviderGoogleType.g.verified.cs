//HintName: G.Models.TextScriptProviderGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextScriptProviderGoogleType
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
    public static class TextScriptProviderGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScriptProviderGoogleType value)
        {
            return value switch
            {
                TextScriptProviderGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScriptProviderGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => TextScriptProviderGoogleType.Google,
                _ => null,
            };
        }
    }
}