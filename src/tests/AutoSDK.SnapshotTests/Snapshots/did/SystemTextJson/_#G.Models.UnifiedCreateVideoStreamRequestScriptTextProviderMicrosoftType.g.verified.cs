//HintName: G.Models.UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType value)
        {
            return value switch
            {
                UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => UnifiedCreateVideoStreamRequestScriptTextProviderMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}