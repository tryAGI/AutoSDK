//HintName: G.Models.CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2 value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateClipStreamRequestScriptVariant1ProviderMicrosoftType2.Microsoft,
                _ => null,
            };
        }
    }
}