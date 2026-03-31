//HintName: G.Models.Create2RequestScriptTextProviderGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Create2RequestScriptTextProviderGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2RequestScriptTextProviderGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptTextProviderGoogleType value)
        {
            return value switch
            {
                Create2RequestScriptTextProviderGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptTextProviderGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => Create2RequestScriptTextProviderGoogleType.Google,
                _ => null,
            };
        }
    }
}