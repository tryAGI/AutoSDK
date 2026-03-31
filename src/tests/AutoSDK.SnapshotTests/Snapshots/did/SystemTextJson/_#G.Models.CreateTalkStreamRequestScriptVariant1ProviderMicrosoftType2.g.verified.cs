//HintName: G.Models.CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2 value)
        {
            return value switch
            {
                CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateTalkStreamRequestScriptVariant1ProviderMicrosoftType2.Microsoft,
                _ => null,
            };
        }
    }
}