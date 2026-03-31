//HintName: G.Models.CreateVideoStreamRequestScriptTextProviderMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoStreamRequestScriptTextProviderMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoStreamRequestScriptTextProviderMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextProviderMicrosoftType value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextProviderMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextProviderMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateVideoStreamRequestScriptTextProviderMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}