//HintName: G.Models.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}