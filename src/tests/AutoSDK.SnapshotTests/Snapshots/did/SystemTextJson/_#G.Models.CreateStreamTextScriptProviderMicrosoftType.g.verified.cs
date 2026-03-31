//HintName: G.Models.CreateStreamTextScriptProviderMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStreamTextScriptProviderMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStreamTextScriptProviderMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamTextScriptProviderMicrosoftType value)
        {
            return value switch
            {
                CreateStreamTextScriptProviderMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamTextScriptProviderMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateStreamTextScriptProviderMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}