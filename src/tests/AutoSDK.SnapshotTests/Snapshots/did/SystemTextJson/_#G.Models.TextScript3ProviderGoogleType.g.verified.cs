//HintName: G.Models.TextScript3ProviderGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextScript3ProviderGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextScript3ProviderGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScript3ProviderGoogleType value)
        {
            return value switch
            {
                TextScript3ProviderGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScript3ProviderGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => TextScript3ProviderGoogleType.Google,
                _ => null,
            };
        }
    }
}