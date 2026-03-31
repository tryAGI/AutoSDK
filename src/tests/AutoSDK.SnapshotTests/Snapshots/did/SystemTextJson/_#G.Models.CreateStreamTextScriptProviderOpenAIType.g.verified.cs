//HintName: G.Models.CreateStreamTextScriptProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStreamTextScriptProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStreamTextScriptProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamTextScriptProviderOpenAIType value)
        {
            return value switch
            {
                CreateStreamTextScriptProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamTextScriptProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateStreamTextScriptProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}