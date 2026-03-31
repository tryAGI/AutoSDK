//HintName: G.Models.CreateSceneRequestDtoScriptTextProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSceneRequestDtoScriptTextProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSceneRequestDtoScriptTextProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneRequestDtoScriptTextProviderOpenAIType value)
        {
            return value switch
            {
                CreateSceneRequestDtoScriptTextProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneRequestDtoScriptTextProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateSceneRequestDtoScriptTextProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}