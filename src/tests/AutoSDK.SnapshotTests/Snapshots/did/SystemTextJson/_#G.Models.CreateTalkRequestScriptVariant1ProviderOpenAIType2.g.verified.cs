//HintName: G.Models.CreateTalkRequestScriptVariant1ProviderOpenAIType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTalkRequestScriptVariant1ProviderOpenAIType2
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkRequestScriptVariant1ProviderOpenAIType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1ProviderOpenAIType2 value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1ProviderOpenAIType2.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1ProviderOpenAIType2? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateTalkRequestScriptVariant1ProviderOpenAIType2.AzureOpenai,
                _ => null,
            };
        }
    }
}