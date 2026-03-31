//HintName: G.Models.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressiveRequestDtoScriptVariant1ProviderGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType.Google,
                _ => null,
            };
        }
    }
}